using System;

namespace TextShield.iOS {

	/// <summary>
	/// Represents a LeftMenuSelectionItem.
	/// </summary>
	///
	public class LeftMenuSelectionItem {

		public LeftMenuSelectionItem ()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
	}
}

