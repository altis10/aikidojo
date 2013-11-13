using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class Engine
	{
		// 2 or 4
		public int StrokeNumber
		{
			get { return _strokenmbr; }
			set { _strokenmbr = value; }
		}
		private int _strokenmbr;

		// petrol or diesel
		public string Fuel
		{
			get { return _fuel; }
			set { _fuel = value; }
		}
		private string _fuel;

		public int EgineCapacity
		{
			get { return _engcapacity; }
			set { _engcapacity = value; }
		}
		private int _engcapacity;

	}
}
