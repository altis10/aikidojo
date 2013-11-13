using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class GearShift
	{
		// Automatic/manual.
		public string GearShiftType
		{
			get { return _gearshifttype; }
			set { _gearshifttype = value; }
		}
		private string _gearshifttype;
	}
}
