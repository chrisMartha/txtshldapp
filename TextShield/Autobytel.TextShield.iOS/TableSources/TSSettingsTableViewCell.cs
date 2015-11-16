using System;
using UIKit;
using CoreGraphics;

namespace Autobytel.TextShield.iOS
{
	public class TSSettingsTableViewCell : UITableViewCell
	{
		public UILabel CellText { get; set; }

		public UIImageView imgCheckmark;
		public UIImageView imgArrow;

		public TSSettingsTableViewCell (string reuseIdentifier, float size) : base (UITableViewCellStyle.Default, reuseIdentifier)
		{
			CellText = new UILabel { 
				BackgroundColor = UIColor.Clear, 
				TextColor = UIColor.FromRGB (51, 51, 51),
				Font = UIFont.BoldSystemFontOfSize (size),
				TextAlignment = UITextAlignment.Left,
				ContentMode = UIViewContentMode.Center
			};
			if (TSPhoneSpec.UserInterfaceIsPhone) {
				imgCheckmark = new UIImageView (new CGRect (TSPhoneSpec.ScreenWidth - 80, 17, 20, 20)) {
					Image = new UIImage ("Checkmark.png"),
				};
			} else {
				imgCheckmark = new UIImageView (new CGRect (TSPhoneSpec.IPadContentWidth - 70, 17, 20, 20)) {
					Image = new UIImage ("Checkmark.png"),
				};
			}
			ContentView.AddSubview (CellText);
			//	ContentView.AddSubview (imgArrow);
			ContentView.AddSubview (imgCheckmark);
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			CGRect bounds = ContentView.Bounds;

			var CellTextRect = new CGRect (bounds.Left + 15f, bounds.Top, bounds.Width - 30f, bounds.Height);
			CellText.Frame = CellTextRect;
		}
	}
}