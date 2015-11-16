
using System;

using Foundation;
using UIKit;
using CoreGraphics;

namespace Autobytel.TextShield.iOS
{
	public partial class TSAccountBasicView : UIViewController
	{
		static bool UserInterfaceIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public TSAccountBasicView () : base (UserInterfaceIsPhone ? "TSAccountBasicView_IPhone" : "TSAccountBasicView_IPad", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			if (UserInterfaceIsPhone)
				SetLayoytIPhone ();
			this.NavigationItem.HidesBackButton = true;
		}

		private void SetLayoytIPhone ()
		{
			AcountBasicScrollView.ContentSize = new CGSize (TSPhoneSpec.ScreenWidth, 590);

			txtDealerShipName.Layer.CornerRadius = 15;
			txtDealerShipName.ClipsToBounds = true;
			txtDealerShipName.Layer.BorderWidth = 1;

			txtAddress1.Layer.CornerRadius = 15;
			txtAddress1.ClipsToBounds = true;
			txtAddress1.Layer.BorderWidth = 1;

			txtAddress2.Layer.CornerRadius = 15;
			txtAddress2.ClipsToBounds = true;
			txtAddress2.Layer.BorderWidth = 1;

			txtCity.Layer.CornerRadius = 15;
			txtCity.ClipsToBounds = true;
			txtCity.Layer.BorderWidth = 1;

			btnBack.TouchUpInside += (sender, e) => {
				this.NavigationController.PopViewController (true);
			};
		}
	}
}

