using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Repeat.Models
{
	internal class Student : Person 
	{
		public Student()
		{
		}

		public Student(string firstName, string lastName, byte age) : base(firstName, lastName, age)
		{
		}

		public Student(string firstName) : base(firstName)
		{
		}

		public decimal Point { get; set; } // 99.3


		public bool Attend { get; set; }


		public void Print(string name)
		{
			
		}
		public void Print(string name, string surname)
		{

		}
		public void Print(int num)
		{

		}

		public override void PrintAge()
		{
			Console.WriteLine($"my age is: {Age}");
		}

	
		public override void Print()
		{
			Console.WriteLine($" Student: {FirstName} {LastName}, Age: {Age}, Point: {Point}, Attend: {Attend}");
		}


		public override string? ToString()
		{
			return $" Student: {FirstName} {LastName}, Age: {Age}, Point: {Point}, Attend: {Attend}";
		}

		public override bool Equals(object? obj)
		{
			if (obj is Student student)
			{
				return FirstName == student.FirstName && LastName == student.LastName && Age == student.Age;
			}
			else
			{
				return false;
			}
		}

		public override int GetHashCode() /// 2147483647
		{
			return HashCode.Combine(FirstName, LastName, Age);
		}
	}
}





//MD5 bcryypt


// overload
// override


// virtual
// abstract
