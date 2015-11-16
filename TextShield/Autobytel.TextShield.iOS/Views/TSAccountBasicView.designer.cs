// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Autobytel.TextShield.iOS
{
	[Register ("TSAccountBasicView")]
	partial class TSAccountBasicView
	{
		[Outlet]
		UIKit.UIScrollView AcountBasicScrollView { get; set; }

		[Outlet]
		UIKit.UIButton btnBack { get; set; }

		[Outlet]
		UIKit.UILabel lblDealerAssociation { get; set; }

		[Outlet]
		UIKit.UILabel lblPartnerAssociation { get; set; }

		[Outlet]
		UIKit.UILabel lblPartnerDesignation { get; set; }

		[Outlet]
		UIKit.UITextField txtAddress1 { get; set; }

		[Outlet]
		UIKit.UITextField txtAddress2 { get; set; }

		[Outlet]
		UIKit.UITextField txtCity { get; set; }

		[Outlet]
		UIKit.UITextField txtDealerShipName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnBack != null) {
				btnBack.Dispose ();
				btnBack = null;
			}

			if (txtDealerShipName != null) {
				txtDealerShipName.Dispose ();
				txtDealerShipName = null;
			}

			if (txtAddress1 != null) {
				txtAddress1.Dispose ();
				txtAddress1 = null;
			}

			if (txtAddress2 != null) {
				txtAddress2.Dispose ();
				txtAddress2 = null;
			}

			if (txtCity != null) {
				txtCity.Dispose ();
				txtCity = null;
			}

			if (lblDealerAssociation != null) {
				lblDealerAssociation.Dispose ();
				lblDealerAssociation = null;
			}

			if (lblPartnerAssociation != null) {
				lblPartnerAssociation.Dispose ();
				lblPartnerAssociation = null;
			}

			if (lblPartnerDesignation != null) {
				lblPartnerDesignation.Dispose ();
				lblPartnerDesignation = null;
			}

			if (AcountBasicScrollView != null) {
				AcountBasicScrollView.Dispose ();
				AcountBasicScrollView = null;
			}
		}
	}
}
