using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Enums;

namespace University.Core.Models
{
	public class Student
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string VerificationCode { get; set; }
		public bool IsVerified { get; set; } = false;
		public List<Subject> Subject { get; set; }
		public Gender Gender { get; set; }
	}
}


//DTO