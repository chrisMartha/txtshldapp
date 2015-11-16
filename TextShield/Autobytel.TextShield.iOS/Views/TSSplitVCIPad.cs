using System;
using UIKit;
using CoreFoundation;

namespace Autobytel.TextShield.iOS
{
	public class TSSplitVCIPad: UISplitViewController
	{
		protected TSSettingsView masterView;
		protected TSAccountBasicView detailView;

		public TSSplitVCIPad () : base ()
		{
			// create our master and detail views
			masterView = new TSSettingsView ();
			detailView = new TSAccountBasicView ();
			this.HidesBottomBarWhenPushed = false;
			this.PreferredDisplayMode = UISplitViewControllerDisplayMode.AllVisible;
			// in this example, i expose an event on the master view called RowClicked, and i listen
			// for it in here, and then call a method on the detail view to update. this class thereby
			// becomes the defacto controller for the screen (both views).
//			masterView.RowClicked += (object sender, MasterView.MasterTableView.RowClickedEventArgs e) => {
//				detailView.Text = e.Item;
//			};
//
			// when the master view controller is hid (portrait mode), we add a button to
			// the detail view that when clicked will show the master view in a popover controller
			this.WillHideViewController += (object sender, UISplitViewHideEventArgs e) => {
				//detailView.AddContentsButton (e.BarButtonItem);
			};

			//this.hid
			// when the master view controller is shown (landscape mode), remove the button
			// since the controller is shown.
			this.WillShowViewController += (object sender, UISplitViewShowEventArgs e) => {
				//detailView.RemoveContentsButton ();
			};

			// this method was introduced in iOS5
			// return true to hide the master list (can still be 'dragged out') or false to force it to show
			this.ShouldHideViewController = (svc, vc, orientation) => {
				return false;//orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
			};

			// ALWAYS SET THIS LAST (since iOS5.1)
			// https://bugzilla.xamarin.com/show_bug.cgi?id=3803
			// http://spouliot.wordpress.com/2012/03/26/events-vs-objective-c-delegates/
			// create an array of controllers from them and then assign it to the
			// controllers property
			ViewControllers = new UIViewController[] { masterView, detailView };
		}


	}
}

