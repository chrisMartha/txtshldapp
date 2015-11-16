
using System;

using Foundation;
using UIKit;

namespace Autobytel.TextShield.iOS
{
	public partial class TSConversationView : TSBaseController
	{
		static bool UserInterfaceIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public TSConversationView () : base (UserInterfaceIsPhone ? "TSConversationView_IPhone" : "TSConversationView_IPad", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.NavigationItem.HidesBackButton = true;
		}
	}
}

