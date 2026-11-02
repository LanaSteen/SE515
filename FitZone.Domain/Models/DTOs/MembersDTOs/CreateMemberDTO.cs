using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
	}
}
