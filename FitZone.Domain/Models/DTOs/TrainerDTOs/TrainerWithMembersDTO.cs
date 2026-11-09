using FitZone.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Domain.Models.DTOs.TrainerDTOs
{
	public class TrainerWithMembersDTO
	{
		public string Name { get; set; }
		public string Surname { get; set; }

		public List<Member> Members { get; set; }
	}
}
