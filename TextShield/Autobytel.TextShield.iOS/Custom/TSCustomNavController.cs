using System;
using UIKit;
using CoreGraphics;
using SidebarNavigation;

namespace Autobytel.TextShield.iOS
{
	public class TSCustomNavController :UINavigationController
	{
		#region Variables and constructor

		public UIButton MenuButton;
		public UIButton SearchButton;
		public UITextField txtSearch;
		public UILabel lblName;
		public UIImageView imgUser;

		public TSCustomNavController ()
		{
			MenuButton = new UIButton (new CGRect (10, 5, 25, 25));
			MenuButton.SetImage (new UIImage ("menu_icon.png"), UIControlState.Normal);

			if (TSPhoneSpec.UserInterfaceIsPhone) {
				lblName = new UILabel (new CGRect (MenuButton.Frame.X + MenuButton.Frame.Width + 5, 5, 130, 30)) {
					Text = "John Anderson",
					Font = UIFont.SystemFontOfSize (15.0f),
					TextAlignment = UITextAlignment.Left,
					TextColor = UIColor.DarkGray,
				};
			} else {

				imgUser = new UIImageView (new CGRect (MenuButton.Frame.X + MenuButton.Frame.Width + 5, 5, 30, 30));
				imgUser.Image = new UIImage ("user_icon.png");
				imgUser.Layer.CornerRadius = 17;
				imgUser.ClipsToBounds = true;
				this.NavigationBar.AddSubview (imgUser);
				lblName = new UILabel (new CGRect (imgUser.Frame.X + imgUser.Frame.Width + 10, 5, 130, 30)) {
					Text = "John Anderson",
					Font = UIFont.SystemFontOfSize (15.0f),
					TextAlignment = UITextAlignment.Left,
					TextColor = UIColor.DarkGray,
				};
			}
			SearchButton = new UIButton (new CGRect (TSPhoneSpec.ScreenWidth - 70, 10, 60, 30));

			SearchButton.SetBackgroundImage (new UIImage ("logo.PNG"), UIControlState.Normal);

			txtSearch = new UITextField (new CGRect (20, 5, 200, 30));

			this.NavigationBar.AddSubview (MenuButton);
			this.NavigationBar.AddSubview (SearchButton);
			this.NavigationBar.AddSubview (lblName);
			this.NavigationBar.BackgroundColor = UIColor.FromRGB (255, 255, 255);

		}

		#endregion

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			//NavigationBar.BarStyle = UIBarStyle.Default;
			//n

		}
	}
}

