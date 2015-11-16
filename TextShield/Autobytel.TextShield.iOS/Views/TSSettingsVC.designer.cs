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
	[Register ("TSSettingsView")]
	partial class TSSettingsView
	{
		[Outlet]
		UIKit.UIView AccontViewIPad { get; set; }

		[Outlet]
		UIKit.UIView ContentViewIPad { get; set; }

		[Outlet]
		UIKit.UILabel lblDealerAssoiciationIPad { get; set; }

		[Outlet]
		UIKit.UILabel lblPartnerAssociationIPad { get; set; }

		[Outlet]
		UIKit.UILabel lblPartnerDesignationIPad { get; set; }

		[Outlet]
		UIKit.UIScrollView scrollIPad { get; set; }

		[Outlet]
		UIKit.UITableView tblSettings { get; set; }

		[Outlet]
		UIKit.UITableView tblSettingsIPad { get; set; }

		[Outlet]
		UIKit.UITextField txtAddress1IPad { get; set; }

		[Outlet]
		UIKit.UITextField txtAddress2IPad { get; set; }

		[Outlet]
		UIKit.UITextField txtCityIPad { get; set; }

		[Outlet]
		UIKit.UITextField txtDealerShipName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tblSettings != null) {
				tblSettings.Dispose ();
				tblSettings = null;
			}

			if (tblSettingsIPad != null) {
				tblSettingsIPad.Dispose ();
				tblSettingsIPad = null;
			}

			if (ContentViewIPad != null) {
				ContentViewIPad.Dispose ();
				ContentViewIPad = null;
			}

			if (scrollIPad != null) {
				scrollIPad.Dispose ();
				scrollIPad = null;
			}

			if (AccontViewIPad != null) {
				AccontViewIPad.Dispose ();
				AccontViewIPad = null;
			}

			if (txtCityIPad != null) {
				txtCityIPad.Dispose ();
				txtCityIPad = null;
			}

			if (txtAddress2IPad != null) {
				txtAddress2IPad.Dispose ();
				txtAddress2IPad = null;
			}

			if (txtAddress1IPad != null) {
				txtAddress1IPad.Dispose ();
				txtAddress1IPad = null;
			}

			if (txtDealerShipName != null) {
				txtDealerShipName.Dispose ();
				txtDealerShipName = null;
			}

			if (lblDealerAssoiciationIPad != null) {
				lblDealerAssoiciationIPad.Dispose ();
				lblDealerAssoiciationIPad = null;
			}

			if (lblPartnerAssociationIPad != null) {
				lblPartnerAssociationIPad.Dispose ();
				lblPartnerAssociationIPad = null;
			}

			if (lblPartnerDesignationIPad != null) {
				lblPartnerDesignationIPad.Dispose ();
				lblPartnerDesignationIPad = null;
			}
		}
	}
}
