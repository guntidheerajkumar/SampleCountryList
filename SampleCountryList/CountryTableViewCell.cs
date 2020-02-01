using System;

using Foundation;
using UIKit;

namespace SampleCountryList
{
    public partial class CountryTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CountryTableViewCell");
        public static readonly UINib Nib;

        static CountryTableViewCell()
        {
            Nib = UINib.FromName("CountryTableViewCell", NSBundle.MainBundle);
        }

        protected CountryTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void SetUp(string name, Byte[] image)
        {
            if (image != null)
            {
                var data = NSData.FromArray(image);
                CountryImageView.Image = UIImage.LoadFromData(data);
            }
            CountryName.Text = name;
        }
    }
}
