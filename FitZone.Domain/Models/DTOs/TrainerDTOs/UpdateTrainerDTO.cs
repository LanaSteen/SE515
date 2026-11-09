using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Domain.Models.DTOs.TrainerDTOs
{
	public class UpdateTrainerDTO
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
	}
}
