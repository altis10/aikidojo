using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class Manufacturer
	{
		public Manufacturer(string MnName)
		{
			ManufacturerName = MnName;
		}

		public string ManufacturerName
		{
			get { return _manufacturername; }
			set { _manufacturername = value; }
		}
		private string _manufacturername;
	}
}
