using System;
using System.Drawing;
using UIKit;
using Foundation;
using CoreGraphics;

namespace Autobytel.TextShield.iOS
{
	public partial class TSLeftSideMenuController : TSBaseController
	{
		#region Variables and constructor

		private  nfloat X_Margin = 25f;
		private  nfloat Width = (int)TSPhoneSpec.MenuWidth;
		private  nfloat btnHeight = 55;
		private UIImageView arrowIcon;

		public TSLeftSideMenuController () : base (null, null)
		{
		}

		#endregion

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.FromRGB (75, 75, 75);

			var HeaderView = new UIView (new CGRect (0, 0, Width, 63)) {
				BackgroundColor = UIColor.White
			};

			var menuImage = new UIImageView (new CGRect (10, 20, 30, 30));
			menuImage.Image = new UIImage ("menu_icon.png");


			var title = new UILabel (new CGRect (X_Margin, 15, Width, 40)) {

				Font = UIFont.SystemFontOfSize (15.0f),
				TextAlignment = UITextAlignment.Left,
				TextColor = UIColor.DarkGray,
				Text = "John Anderson",
			};

			HeaderView.Add (title);
			//HeaderView.Add (menuImage);
			arrowIcon = new UIImageView ();
			arrowIcon.Image = new UIImage ("arrow_icon.png");

			var conversationsButton = new UIButton (UIButtonType.System);
			conversationsButton.Frame = new CGRect (0, 63, Width + X_Margin, btnHeight);
			conversationsButton.SetTitle ("Conversations", UIControlState.Normal);
			conversationsButton.ContentEdgeInsets = new UIEdgeInsets (0, X_Margin, 0, 0);
			conversationsButton.SetTitleColor (UIColor.White, UIControlState.Normal);
			conversationsButton.Font = UIFont.BoldSystemFontOfSize (15);
			conversationsButton.BackgroundColor = UIColor.FromRGB (99, 99, 99);
			conversationsButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
			conversationsButton.TouchUpInside += (sender, e) => {
				arrowIcon.Frame = new CGRect (Width - 50, conversationsButton.Frame.Y + 15, 25, 25);
				//SidebarController.ChangeContentView (new TSConversationVC());
				NavController.PushViewController (new TSConversationView (), true);
				SidebarController.CloseMenu ();
			};


			var ContactsButton = new UIButton (UIButtonType.System);
			ContactsButton.Frame = new CGRect (0, conversationsButton.Frame.Y + conversationsButton.Frame.Height + 5, Width + X_Margin, btnHeight);
			ContactsButton.SetTitle ("Contacts", UIControlState.Normal);
			ContactsButton.ContentEdgeInsets = new UIEdgeInsets (0, X_Margin, 0, 0);
			ContactsButton.SetTitleColor (UIColor.White, UIControlState.Normal);
			ContactsButton.Font = UIFont.BoldSystemFontOfSize (15);
			ContactsButton.BackgroundColor = UIColor.FromRGB (99, 99, 99);
			ContactsButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
			ContactsButton.TouchUpInside += (sender, e) => {
				//	newsButton.BackgroundColor = UIColor.LightGray;
				//	SidebarController.ChangeContentView (new IntroController ());
			};


			var settingsButton = new UIButton (UIButtonType.System);
			settingsButton.Frame = new CGRect (0, ContactsButton.Frame.Y + ContactsButton.Frame.Height + 5, Width + X_Margin, btnHeight);
			settingsButton.SetTitle ("Settings", UIControlState.Normal);
			settingsButton.BackgroundColor = UIColor.FromRGB (99, 99, 99);
			settingsButton.ContentEdgeInsets = new UIEdgeInsets (0, X_Margin, 0, 0);
			settingsButton.SetTitleColor (UIColor.White, UIControlState.Normal);
			settingsButton.Font = UIFont.BoldSystemFontOfSize (15);
			settingsButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
			arrowIcon.Frame = new CGRect (Width - 50, settingsButton.Frame.Y + 15, 25, 25);

			settingsButton.TouchUpInside += (sender, e) => {
				NavController.PopToRootViewController (false);
				arrowIcon.Frame = new CGRect (Width - 50, settingsButton.Frame.Y + 15, 25, 25);
				SidebarController.CloseMenu ();
			};


			var reportingButton = new UIButton (UIButtonType.System);
			reportingButton.Frame = new CGRect (0, settingsButton.Frame.Y + settingsButton.Frame.Height + 5, Width + X_Margin, btnHeight);
			reportingButton.SetTitle ("Reporting", UIControlState.Normal);
			reportingButton.BackgroundColor = UIColor.FromRGB (99, 99, 99);
			reportingButton.ContentEdgeInsets = new UIEdgeInsets (0, X_Margin, 0, 0);
			reportingButton.SetTitleColor (UIColor.White, UIControlState.Normal);
			reportingButton.Font = UIFont.BoldSystemFontOfSize (15);
			reportingButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
			reportingButton.TouchUpInside += (sender, e) => {
				//intheaterButton.BackgroundColor = UIColor.LightGray;
				//SidebarController.ChangeContentView (new IntroController ());
			};

			var AutoBytleIcon = new UIImageView (new CGRect (30, reportingButton.Frame.Y + reportingButton.Frame.Height + 20, 150, 40));
			AutoBytleIcon.Image = new UIImage ("autobytle.PNG");

			var scroll = new UIScrollView (new CGRect (0, 0, Width, 360));
			scroll.ContentSize = new CGSize (Width, 360);
			View.Add (scroll);
			scroll.Add (conversationsButton);
			scroll.Add (ContactsButton);
			scroll.Add (settingsButton);
			scroll.Add (arrowIcon);
			scroll.Add (reportingButton);
			scroll.Add (HeaderView);
			scroll.Add (AutoBytleIcon);
		}

		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			//if(
		}
	}
}

