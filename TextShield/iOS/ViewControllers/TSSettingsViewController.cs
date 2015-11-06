using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace TextShield.iOS
{
	partial class TSSettingsViewController : UITableViewController
	{

		LeftMenuTableItem currentTask {get;set;}
		public TSLeftMenuViewController Delegate {get;set;} // will be used to Save, Delete later

		public TSSettingsViewController (IntPtr handle) : base (handle)
		{
			
		}

		// when displaying, set-up the properties
		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			SaveButton.TouchUpInside += (sender, e) => {
				currentTask.Name = TitleText.Text;
				currentTask.Notes = NotesText.Text;
				currentTask.Done = DoneSwitch.On;
				Delegate.SaveTask(currentTask);
			};
			DeleteButton.TouchUpInside += (sender, e) => {
				Delegate.DeleteTask(currentTask);
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
//			TitleText.Text = currentTask.Name;
//			NotesText.Text = currentTask.Notes;
//			DoneSwitch.On = currentTask.Done;
		}

		// this will be called before the view is displayed
		public void SetTask (TSLeftMenuViewController d, LeftMenuTableItem task) {
			Delegate = d;
			currentTask = task;
		}


	}
}
