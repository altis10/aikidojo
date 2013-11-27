using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConferenceRooms
{
	class MediumConferenceRoom : ConferenceRoom
	{
		private static MediumConferenceRoom _mediumCFInstance;

		private MediumConferenceRoom() { }

		public static MediumConferenceRoom reserveMediumCF(DateTime hour)
		{
			if (_mediumCFInstance == null)
			{
				_mediumCFInstance = new MediumConferenceRoom();
			}

			return _mediumCFInstance;
		}
	}
}
