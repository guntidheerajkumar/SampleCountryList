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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton ButtonReturn { get; set; }

		[Outlet]
		UIKit.UISearchBar CountriesSearchBar { get; set; }

		[Outlet]
		UIKit.UITableView CountriesTableView { get; set; }

		[Outlet]
		UIKit.UITextField CountriesTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CountriesSearchBar != null) {
				CountriesSearchBar.Dispose ();
				CountriesSearchBar = null;
			}

			if (CountriesTableView != null) {
				CountriesTableView.Dispose ();
				CountriesTableView = null;
			}

			if (CountriesTextField != null) {
				CountriesTextField.Dispose ();
				CountriesTextField = null;
			}

			if (ButtonReturn != null) {
				ButtonReturn.Dispose ();
				ButtonReturn = null;
			}
		}
	}
}
