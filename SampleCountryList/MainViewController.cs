// This file has been autogenerated from a class added in the UI designer.

using System;
using Countries;
using Foundation;
using UIKit;

namespace SampleCountryList
{
	public partial class MainViewController : UIViewController, MainViewControllerDelegate
    {
		public MainViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ButtonCountries.TouchUpInside += ButtonCountries_TouchUpInside;
        }

        private void ButtonCountries_TouchUpInside(object sender, EventArgs e)
        {
            var storyBoard = UIStoryboard.FromName("Main", null);
            var controller = storyBoard.InstantiateViewController("ViewController") as ViewController;
            controller.NavController = NavigationController;
            controller.WeakTransitioningDelegate = this;
            NavigationController.PresentViewController(controller, true, null);
        } 

        public void GetCountry(string name, byte[] image)
        {
            if (image != null)
            {
                var data = NSData.FromArray(image);
                SelectedCountryImage.Image = UIImage.LoadFromData(data);
            }
            SelectedCountryNameLabel.Text = name;
        }
    }

    public interface MainViewControllerDelegate
    {
        void GetCountry(string name, Byte[] image);
    }
}