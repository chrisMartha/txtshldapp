using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;
using Foundation;

namespace Autobytel.TextShield.iOS
{
	public class TSSettingsTableSource: UITableViewSource
	{
		static readonly string changeLoginCellId = "ChangeLoginCell";

		float fontSize = 15f;

		List<TSSettingsItems> Data;

		IGrouping<string, TSSettingsItems>[] GroupedData;

		TSSettingsView controller;

		TSSettingsView settingVC;

		public TSSettingsTableSource (TSSettingsView tvc, List<TSSettingsItems> data)
		{
			controller = tvc;
			Data = data;
			GroupedData = GetEntriesBySectionName ();
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return GroupedData [section].Count ();
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			tableView.DeselectRow (indexPath, true);
			var changeLoginGroup = GroupedData [indexPath.Section];
			var changeLoginEntry = changeLoginGroup.ElementAt (indexPath.Row);
			if (changeLoginEntry.OnClickAction != null) {
				if (TSPhoneSpec.UserInterfaceIsPhone) {
					if (changeLoginEntry.OnClickAction.Equals ("PushAccountbasic")) {
						controller.NavigationController.PushViewController (new TSAccountBasicView (), true);
					} 
				} else {
					if (settingVC == null)
						settingVC = new TSSettingsView ();
					if (changeLoginEntry.OnClickAction.Equals ("PushAccountbasic")) {
						UITableViewCell cell = tableView.CellAt (indexPath);
						cell.BackgroundColor = UIColor.FromRGB (220, 220, 220);
						cell.TextLabel.TextColor = UIColor.Orange;
						controller.SetAccountBasicLayoytIPad ();
					}
				}
			}
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var changeLoginGroup = GroupedData [indexPath.Section];
			var changeLoginEntry = changeLoginGroup.ElementAt (indexPath.Row);

			var cell = (TSSettingsTableViewCell)tableView.DequeueReusableCell (changeLoginCellId);

			if (cell == null) {
				cell = new TSSettingsTableViewCell (changeLoginCellId, fontSize);
			}

			if (UIDevice.CurrentDevice.CheckSystemVersion (8, 0)) {
				cell.LayoutMargins = UIEdgeInsets.Zero;
				cell.PreservesSuperviewLayoutMargins = false;
			}

			cell.TextLabel.Text = changeLoginEntry.EntryData.Title;
			cell.TextLabel.Font = UIFont.SystemFontOfSize (14);
			cell.TextLabel.HighlightedTextColor = UIColor.Orange;
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			cell.SelectionStyle = UITableViewCellSelectionStyle.Gray;
			return cell;
		}

		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return (nfloat)50;
		}



		IGrouping<string, TSSettingsItems>[] GetEntriesBySectionName ()
		{
			var EntriesGrouped = (from e in Data
			                      group e by e.SectionName into g
			                      select g).ToArray ();

			return EntriesGrouped;
		}
	}
}

