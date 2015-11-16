
using System;

using Foundation;
using UIKit;
using SidebarNavigation;

namespace Autobytel.TextShield.iOS
{
	public partial class TSHomeView : UIViewController
	{

		#region varibales and constructor

		public SidebarController SidebarController { get; private set; }

		public TSCustomNavController customnav;

		static bool UserInterfaceIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public TSHomeView () : base (null, null)
		{
		}

		#endregion

		#region page lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			customnav = new TSCustomNavController ();
			//if (UserInterfaceIsPhone)
			customnav.PushViewController (new TSSettingsView (), false);
			//else
			//	customnav.PushViewController (new TSSplitVCIPad (), false);
			SidebarController = new SidebarNavigation.SidebarController (this, customnav, new TSLeftSideMenuController ());
			SidebarController.MenuLocation = SidebarNavigation.SidebarController.MenuLocations.Left;
			SidebarController.FlingVelocity = 300f;
			SidebarController.MenuWidth = (int)TSPhoneSpec.MenuWidth;
			customnav.MenuButton.TouchUpInside += (sender, e) => {
				SidebarController.ToggleMenu ();
			};
		}

		#endregion
	}
}

