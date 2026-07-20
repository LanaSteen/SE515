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

		public List<Subject> Subject { get; set; }
		public Gender Gender { get; set; }
	}
}


//DTO