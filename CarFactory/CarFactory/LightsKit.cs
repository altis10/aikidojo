using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class LightsKit
	{
		// classic, sport, LED
		public string LightsType
		{
			get { return _lightstype; }
			set { _lightstype = value; }
		}
		private string _lightstype;
	}
}
