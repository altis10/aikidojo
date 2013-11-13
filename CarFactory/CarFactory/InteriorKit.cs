using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class InteriorKit
	{
		public bool Leather
		{
			get { return _leather; }
			set { _leather = value; }
		}
		private bool _leather;

		public bool SportPackage
		{
			get { return _sportpackage; }
			set { _sportpackage = value; }
		}
		private bool _sportpackage;

		public bool RaceCar
		{
			get { return _racecar; }
			set { _racecar = value; }
		}
		private bool _racecar;
	}
}
