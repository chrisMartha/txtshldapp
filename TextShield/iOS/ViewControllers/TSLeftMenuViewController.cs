using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace TextShield.iOS
{
	//Left Menu for the Selection Items
	partial class TSLeftMenuViewController : UITableViewController
	{
		
		List<LeftMenuTableItem> chores;

		public TSLeftMenuViewController (IntPtr handle) : base (handle)
		{
			Title = "ChoreBoard";

			// Custom initialization
			chores = new List<LeftMenuTableItem> {
				new LeftMenuTableItem() {Name="Conversations", Notes="Buy bread, cheese, apples", Done=false},
				new LeftMenuTableItem() {Name="Contacts", Notes="Buy Nexus, Galaxy, Droid", Done=false},
				new LeftMenuTableItem() {Name="Settings", Notes="Buy Nexus, Galaxy, Droid", Done=false},
				new LeftMenuTableItem() {Name="Reports", Notes="Buy Nexus, Galaxy, Droid", Done=false}

			};

		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "TaskSegue") { // set in Storyboard
				var nav = segue.DestinationViewController as UINavigationController;
				var navctlr = nav.ViewControllers[0] as TSSettingsViewController;
				if (navctlr != null) {
					var source = TableView.Source as LeftMenuTableSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					navctlr.SetTask (this, item); // to be defined on the TaskDetailViewController
				}
			}
		}

		public void CreateTask ()
		{
			// first, add the task to the underlying data
			var newId = chores[chores.Count - 1].Id + 1;
			var newChore = new LeftMenuTableItem(){Id=newId};
			chores.Add (newChore);

			// then open the detail view to edit it
			var detail = Storyboard.InstantiateViewController("detail") as TSSettingsViewController;
			detail.SetTask (this, newChore);
			NavigationController.PushViewController (detail, true);
		}

		public void SaveTask (LeftMenuTableItem chore)
		{
			//var oldTask = chores.Find(t => t.Id == chore.Id);
			NavigationController.PopViewController(true);
		}

		public void DeleteTask (LeftMenuTableItem chore)
		{
			var oldTask = chores.Find(t => t.Id == chore.Id);
			chores.Remove (oldTask);
			NavigationController.PopViewController(true);
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			AddButton.Clicked += (sender, e) => {
				CreateTask ();
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			// bind every time, to reflect deletion in the Detail view
			TableView.Source = new LeftMenuTableSource(chores.ToArray ());
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}
