using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitZone.Domain.Models.Entities
{
	public class Member
	{
		public int Id { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		
		public int MembershipTypeId { get; set; }

	}
}
