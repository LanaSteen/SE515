using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore2.Models.Entities
{
	internal class User
	{
		[Key]
		public int Id { get; set; }
		[EmailAddress]
		[Required]
		[MaxLength(100)]
		public string Email { get; set; }
		
		public string UserName { get; set; }
		public UserProfile UserProfile { get; set; }  // one-to-one navigation property
	}
}
