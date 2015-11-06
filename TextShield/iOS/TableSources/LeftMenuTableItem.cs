using System;

namespace TextShield.iOS {

	/// <summary>
	/// Represents a LeftMenuTableItem.
	/// </summary>
	///
	public class LeftMenuTableItem {

		public LeftMenuTableItem ()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
	}
}

