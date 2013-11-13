using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class FuelTank
	{
		public int Capacity
		{
			get { return _capacity; }
			set { _capacity = value; }
		}
		private int _capacity;

		public string Material
		{
			get { return _material; }
			set { _material = value; }
		}
		private string _material;
	}
}
