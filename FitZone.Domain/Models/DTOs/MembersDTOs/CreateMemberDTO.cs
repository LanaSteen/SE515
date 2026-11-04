using FitZone.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace FitZone.Domain.Models.DTOs.MembersDTOs
{
	public class CreateMemberDTO
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }

		public int MembershipTypeId { get; set; }
		public int TrainerId { get; set; }
		public MembershipType MembershipType { get; set; }
	}
}
