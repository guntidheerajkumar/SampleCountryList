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
	[Register ("CountryTableViewCell")]
	partial class CountryTableViewCell
	{
		[Outlet]
		UIKit.UIImageView CountryImageView { get; set; }

		[Outlet]
		UIKit.UILabel CountryName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CountryImageView != null) {
				CountryImageView.Dispose ();
				CountryImageView = null;
			}

			if (CountryName != null) {
				CountryName.Dispose ();
				CountryName = null;
			}
		}
	}
}
