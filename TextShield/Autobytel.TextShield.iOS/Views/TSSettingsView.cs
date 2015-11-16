
using System;

using Foundation;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;

namespace Autobytel.TextShield.iOS
{
	public partial class TSSettingsView : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public TSSettingsView () : base (UserInterfaceIdiomIsPhone ? "TSSettingsVC_IPhone" : "TSSettingsVC_IPad", null)
		{
		}

		public  override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var SettingsTableData = new List<TSSettingsItems> ();

			var accountItem = new TSSettingsItems {
				EntryData = new TableData {
					Title = "Account Basics"
				},
				OnClickAction = "PushAccountbasic"
			};
			SettingsTableData.Add (accountItem);
			var setupItem = new TSSettingsItems {
				EntryData = new TableData {
					Title = "Setup Codes"
				},
				OnClickAction = "push"
			};

			SettingsTableData.Add (setupItem);

			var DepartmentsItem = new TSSettingsItems {
				EntryData = new TableData {
					Title = "Departments"
				},
				OnClickAction = "Push"
			};
			SettingsTableData.Add (DepartmentsItem);

			var advancedItem = new TSSettingsItems {
				EntryData = new TableData {
					Title = "Advanced"
				},
				OnClickAction = "Push"
			};
			SettingsTableData.Add (advancedItem);

			var inviteAgentsItem = new TSSettingsItems {
				EntryData = new TableData {
					Title = "Invite Agents"
				},
				OnClickAction = "Push"
			};
			SettingsTableData.Add (inviteAgentsItem);

			var FooterView = new UIView (new CGRect (0, 0, View.Frame.Width, 100));
			FooterView.BackgroundColor = UIColor.White;
			//	FooterView.Layer.BorderWidth = 1;
			//FooterView.Layer.BorderColor = UIColor.FromRGB(222, 222, 222).CGColor;

			var btnNew = new UIButton (new CGRect (TSPhoneSpec.ScreenWidth / 2 - 75, 50, 150, 50));
			btnNew.SetTitle ("+ Add Account", UIControlState.Normal);
			btnNew.SetTitleColor (UIColor.FromRGB (0, 32, 70), UIControlState.Normal);
			btnNew.Font = UIFont.SystemFontOfSize (15.0f);
			FooterView.Add (btnNew);

			var TableViewSource = new TSSettingsTableSource (this, SettingsTableData);

			if (UserInterfaceIdiomIsPhone) {
				tblSettings.SeparatorInset = new UIEdgeInsets (0, 0, 0, 0);

				

				tblSettings.BackgroundColor = UIColor.White;
				tblSettings.SeparatorStyle = UITableViewCellSeparatorStyle.SingleLine;
				tblSettings.TableFooterView = FooterView;
				tblSettings.Source = TableViewSource;
				tblSettings.ReloadData ();
			} else {

				tblSettingsIPad.SeparatorInset = new UIEdgeInsets (0, 0, 0, 0);
				tblSettingsIPad.BackgroundColor = UIColor.White;
				tblSettingsIPad.SeparatorStyle = UITableViewCellSeparatorStyle.SingleLine;
				tblSettingsIPad.TableFooterView = FooterView;
				tblSettingsIPad.Source = TableViewSource;
				tblSettingsIPad.ReloadData ();
				SetAccountBasicLayoytIPad ();
			}
			//	View.AddSubview(ChangeLoginTableView);
		}


		public void SetAccountBasicLayoytIPad ()
		{
			if (scrollIPad != null) {
				ContentViewIPad.Add (scrollIPad);
			}

			txtDealerShipName.Layer.CornerRadius = 15;
			txtDealerShipName.ClipsToBounds = true;
			txtDealerShipName.Layer.BorderWidth = 1;

			txtAddress1IPad.Layer.CornerRadius = 15;
			txtAddress1IPad.ClipsToBounds = true;
			txtAddress1IPad.Layer.BorderWidth = 1;

			txtAddress2IPad.Layer.CornerRadius = 15;
			txtAddress2IPad.ClipsToBounds = true;
			txtAddress2IPad.Layer.BorderWidth = 1;

			txtCityIPad.Layer.CornerRadius = 15;
			txtCityIPad.ClipsToBounds = true;
			txtCityIPad.Layer.BorderWidth = 1;

		}
	}
}