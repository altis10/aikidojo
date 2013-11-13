using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CarFactory
{
	class Body
	{
		public string Colour
		{
			get { return _colour; }
			set { _colour = value; }
		}
		private string _colour;

		// limousine, hatchback, break
		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}
		private string _type;

		public string Material
		{
			get { return _material; }
			set { _material = value; }
		}
		private string _material
			;

	}
}
