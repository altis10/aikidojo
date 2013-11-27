using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceRooms
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime interval = new DateTime();
			ReserveConferenceRoom ConfRoomReserved = new ReserveConferenceRoom();
			ConfRoomReserved.ReserveAConferenceRoom("small", interval);
		}
	}
}
