using System;
using System.Collections.Generic;
using System.Text;

namespace HospitallApp.Models
{
	internal class Doctor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Specialization { get; set; }
		public int RoomNumber { get; set; }
		public ICollection<Patient> Patients { get; set; } = new List<Patient>();


	}
}
