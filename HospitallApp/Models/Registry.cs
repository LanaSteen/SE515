using System;
using System.Collections.Generic;
using System.Text;

namespace HospitallApp.Models
{
	internal class Registry
	{
		public int Id { get; set; }
		public DateTime OpenDate { get; set; }
		public int PatientId { get; set; } //fk
		public Patient Patient { get; set; } /// navigational property
		public ICollection<Diagnose> Diagnoses { get; set; } = new List<Diagnose>();

	}
}
