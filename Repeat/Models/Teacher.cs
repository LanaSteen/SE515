using System;
using System.Collections.Generic;
using System.Text;

namespace Repeat.Models
{
	internal class Teacher : Person
	{
		public Teacher(string firstName, string lastName, byte age) : base(firstName, lastName, age)
		{
		}

		public int WorkExperience { get; set; } // 6

	}
}
