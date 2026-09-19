using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models
{
	public class Student
	{

		int Id { get; set; }
		string Name { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string Password { get; set; }
	}
}
