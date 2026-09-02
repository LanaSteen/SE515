using System;
using System.Collections.Generic;
using System.Text;

namespace Repeat.Models
{
	internal class Student : Person
	{
		public Student(string firstName, string lastName, byte age, decimal point, bool attend) : base(firstName, lastName, age)
		{
			Point = point;
			Attend	= attend;
		}

		public decimal Point { get; set; } // 99.3


		public bool Attend { get; set; }


		public void Print(string name)
		{
			
		}
		public void Print(string name, string surname)
		{

		}

		public override string? ToString()
		{
			return $" Student: {FirstName} {LastName}, Age: {Age}, Point: {Point}, Attend: {Attend}";
		}
	}
}

//overload
