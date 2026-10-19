using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelApp.Models.Entities
{
	internal class Hotel
	{

		public int Id { get; set; }  // ID HottelId
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }   // nvarchar(50) not null
		public string Location { get; set; }  // nvarchar // 

		public ICollection<Room> Rooms { get; set; }  // Navigation property for related rooms

	}
}
