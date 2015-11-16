using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace Autobytel.TextShield.iOS
{
	public class TSBaseController : UIViewController
	{
		protected SidebarNavigation.SidebarController SidebarController { 
			get {
				return (UIApplication.SharedApplication.Delegate as AppDelegate).HomeVC.SidebarController;
			} 
		}

		protected TSCustomNavController NavController { 
			get {
				return (UIApplication.SharedApplication.Delegate as AppDelegate).HomeVC.customnav;
			} 
		}

		public TSBaseController (string nibName, NSBundle bundle) : base (nibName, bundle)
		{

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void ViewDidLayoutSubviews ()
		{
			TSPhoneSpec.ScreenWidth = UIScreen.MainScreen.Bounds.Width;
			TSPhoneSpec.ScreenHeight = UIScreen.MainScreen.Bounds.Height;
			if (NavController != null && NavController.SearchButton != null)
				NavController.SearchButton.Frame = new CGRect (TSPhoneSpec.ScreenWidth - 70, 10, 60, 30);
		}
	}
}

