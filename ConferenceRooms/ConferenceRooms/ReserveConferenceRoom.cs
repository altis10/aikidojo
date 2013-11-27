using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceRooms
{
	public class ReserveConferenceRoom
	{
		public void ReserveAConferenceRoom( string size, DateTime reservedInterval)
		{
			switch (size)
			{
				case "small":
					SmallConferenceRoom smallConferenceRoom = SmallConferenceRoom.reserveSmallCF( reservedInterval);
					break;
				case "medium":
					MediumConferenceRoom mediumConferenceRoom = MediumConferenceRoom.reserveMediumCF( reservedInterval);
					break;
				case "large":
					LargeConferenceRoom largeConferenceRoom = LargeConferenceRoom.reserveLargeCF( reservedInterval);
					break;
			}
		}
	}
}
