using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceRooms
{
	public class SmallConferenceRoom : ConferenceRoom
	{
		private static SmallConferenceRoom _smallCFInstance;

		private SmallConferenceRoom() { }

		public static SmallConferenceRoom reserveSmallCF(DateTime hour)
		{ 
			if ( _smallCFInstance == null)
			{
				_smallCFInstance = new SmallConferenceRoom();
			}
			
			return _smallCFInstance;
		}
	}
}
