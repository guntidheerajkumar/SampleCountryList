// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SampleCountryList
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIButton ButtonCountries { get; set; }

		[Outlet]
		UIKit.UIImageView SelectedCountryImage { get; set; }

		[Outlet]
		UIKit.UILabel SelectedCountryNameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ButtonCountries != null) {
				ButtonCountries.Dispose ();
				ButtonCountries = null;
			}

			if (SelectedCountryImage != null) {
				SelectedCountryImage.Dispose ();
				SelectedCountryImage = null;
			}

			if (SelectedCountryNameLabel != null) {
				SelectedCountryNameLabel.Dispose ();
				SelectedCountryNameLabel = null;
			}
		}
	}
}
