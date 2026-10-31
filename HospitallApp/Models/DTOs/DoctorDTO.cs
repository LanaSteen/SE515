using System;
using System.Collections.Generic;
using System.Text;

namespace HospitallApp.Models.DTOs
{
	internal class DoctorDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Specialization { get; set; }
		public int RoomNumber { get; set; }

		public override string? ToString()
		{
			return $"Id: {Id}, Name: {Name}, Specialization: {Specialization}, Room Number: {RoomNumber}";
		}
	}
}
