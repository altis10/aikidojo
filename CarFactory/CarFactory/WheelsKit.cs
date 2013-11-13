using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class WheelsKit
	{
		public int WheelNumber
		{
			get { return _wheelnmbr; }
			set { _wheelnmbr = value; }
		}
		private int _wheelnmbr;

		public string WheelMaterial
		{
			get { return _wheelmaterial; }
			set { _wheelmaterial = value; }
		}
		private string _wheelmaterial;

		// summer/winter
		public string TireType
		{
			get { return _tiretype; }
			set { _tiretype = value; }
		}
		private string _tiretype;

		public int TireWidth
		{
			get { return _tirewidth; }
			set { _tirewidth = value; }
		}
		private int _tirewidth;

		public int TireRatio
		{
			get { return _tireratio; }
			set { _tireratio = value; }
		}
		private int _tireratio;		
	}
}
