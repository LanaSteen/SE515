using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Domain.Models.Entities
{
	public class Trainer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }

		public List<Member> Members { get; set; }
	
	}
}
