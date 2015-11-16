using System;

namespace Autobytel.TextShield.iOS
{
	public class TSSettingsItems
	{
		public string SectionName {
			get;
			set;
		}

		public TableData EntryData {
			get;
			set;
		}

		public string OnClickAction {
			get;
			set;
		}
	}

	public class TableData
	{
		public string Title {
			get;
			set;
		}

		public string Detail {
			get;
			set;
		}
	}
}

