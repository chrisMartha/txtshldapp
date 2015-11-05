using System;

namespace TextShield.iOS {

	/// <summary>
	/// Represents a Chore.
	/// </summary>
	///
	public class Chore {

		public Chore ()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
	}
}

