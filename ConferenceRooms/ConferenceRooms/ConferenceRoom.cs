using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceRooms
{
	public class ConferenceRoom
	{
		public DateTime hourlyInterval;

		public bool CleanRoom(bool cleaned)
		{
			if (cleaned) return true;
			else return false;
		}

		public bool GetCatering(bool getCatering)
		{
			if (getCatering) return true;
			else return false;
		}

		public bool NeedProjector(bool getProjector)
		{
			if (getProjector) return true;
			else return false;
		}
	}
}
