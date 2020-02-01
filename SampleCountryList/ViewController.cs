using System;
using System.Collections.Generic;
using System.Linq;
using Countries;
using Foundation;
using UIKit;

namespace SampleCountryList
{
    public partial class ViewController : UIViewController
    {
        private List<Country> Countries;
        public UINavigationController NavController;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Countries = GlobalCountries.GetCountries();

            CountriesTableView.Source = new TableSource(Countries, NavController);
            CountriesTableView.ReloadData();

            CountriesSearchBar.AutocorrectionType =  UITextAutocorrectionType.No;
            CountriesSearchBar.TextChanged += CountriesSearchBar_TextChanged;
        }

        private void CountriesSearchBar_TextChanged(object sender, UISearchBarTextChangedEventArgs e)
        {
            if (CountriesSearchBar.Text != string.Empty)
            {
                var data = Countries.Where(a => a.CountryName.ToLowerInvariant().StartsWith(CountriesSearchBar.Text.ToLowerInvariant())).ToList();
                CountriesTableView.Source = new TableSource(data, NavController);
            }
            else
            {
                CountriesTableView.Source = new TableSource(Countries, NavController);
            }
            CountriesTableView.ReloadData();
        }
    }

    public class TableSource : UITableViewSource
    {
        private List<Country> TableItems;
        private string CellIdentifier = "TableCell";
        private UINavigationController _navController;

        public TableSource(List<Country> items, UINavigationController navigationController)
        {
            TableItems = items;
            _navController = navigationController;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UIImage uIImage = null;
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            var item = TableItems[indexPath.Row];
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Value1, CellIdentifier);
            }
            try
            {
                if (item.CountryFlag != null)
                {
                    var data = NSData.FromArray(item.CountryFlag);
                    uIImage = UIImage.LoadFromData(data);
                }

                cell.TextLabel.Text = item.CountryName;
                cell.ImageView.Image = uIImage != null ? uIImage : new UIImage();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, false);
            var country = TableItems[indexPath.Row];
            var controller = _navController.TopViewController as MainViewController;
            if (controller != null)
            {
                controller.GetCountry(country.CountryName, country.CountryFlag);
                _navController.DismissModalViewController(true);
            }
        }
    }
}