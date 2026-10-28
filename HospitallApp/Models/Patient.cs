using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitallApp.Models
{
	internal class Patient
	{
		
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
		 
		public Registry Registry { get; set; } // navigational property

	}
}
