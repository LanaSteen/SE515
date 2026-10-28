using System;
using System.Collections.Generic;
using System.Text;

namespace HospitallApp.Models
{
	internal class Diagnose
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int RegistryId { get; set; } //fk
		public Registry Registry { get; set; } /// navigational property
	}
}
