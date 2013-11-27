using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceRooms
{
	class LargeConferenceRoom : ConferenceRoom
	{
		private static LargeConferenceRoom _largeCFInstance;

		private LargeConferenceRoom() { }

		public static LargeConferenceRoom reserveLargeCF(DateTime hour)
		{
			if (_largeCFInstance == null)
				lock (typeof(LargeConferenceRoom))
				{ 
					if (_largeCFInstance == null)
					{
						_largeCFInstance = new LargeConferenceRoom();
					}
				}

			return _largeCFInstance;
		}
	}
}
