using System;
using UIKit;

namespace Autobytel.TextShield.iOS
{
	public class TSPhoneSpec
	{
		public static nfloat ScreenWidth = UIScreen.MainScreen.Bounds.Width;

		public static nfloat ScreenHeight = UIScreen.MainScreen.Bounds.Height;

		public static nfloat IPadContentWidth = 220;

		public static bool UserInterfaceIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public static nfloat MenuWidth{ get { return UserInterfaceIsPhone ? ((int)TSPhoneSpec.ScreenWidth - 100) : 200; } }

	}
}

