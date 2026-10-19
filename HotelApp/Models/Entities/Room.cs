using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp.Models.Entities
{
	internal class Room
	{
		public int Id { get; set; }
		public int RoomNumber { get; set; }
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }

	}
}
