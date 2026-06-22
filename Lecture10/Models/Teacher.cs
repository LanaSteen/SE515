using Lecture10.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10.Models
{
	internal class Teacher : Emloyee
	{
		//public string Name { get; set; }
		//public int Age { get; set; }

		//public decimal Salary { get; set; }

		public Sublect Sublect { get; set; }
		public Lesson[] Lessons { get; set; }

		public Teacher(string name, int age, decimal salary, Sublect sublect, Lesson[] lessons) : base(name, age, salary)
		{
			Sublect = sublect;
			Lessons = lessons;
		}

		public Teacher()
		{
		}

		public override decimal GetSalary()
		{
			return Salary * 1.5m;
		}
	}
}
