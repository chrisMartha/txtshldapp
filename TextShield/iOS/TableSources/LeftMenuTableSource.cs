using System;
using UIKit;

namespace TextShield.iOS
{
	public class LeftMenuTableSource : UITableViewSource {

		// there is NO database or storage of Tasks in this example, just an in-memory List<>
		LeftMenuTableItem[] tableItems;
		string cellIdentifier = "taskcell"; // set in the Storyboard

		public LeftMenuTableSource (LeftMenuTableItem[] items)
		{
			tableItems = items;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell,
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			// now set the properties as normal
			cell.TextLabel.Text = tableItems[indexPath.Row].Name;
			if (tableItems[indexPath.Row].Done)
				cell.Accessory = UITableViewCellAccessory.Checkmark;
			else
				cell.Accessory = UITableViewCellAccessory.None;
			return cell;
		}
		public LeftMenuTableItem GetItem(int id) {
			return tableItems[id];
		}
	}
}
