using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12.Models
{
	internal class Student 
	{
		public Student()
		{
		}

		public Student(int age, string name)
		{
			Age = age;
			Name = name;
		}

		public Student(int age)
		{
			Age = age;
		}

		public int Age { get; set; }
		public string Name { get; set; }

		public override string? ToString()  // ""
		{
			return $"Name: {Name}, Age: {Age}";
		}

		public override bool Equals(object? obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		//public override string? ToString()
		//{
		//	return $"Name: {Name}, Age: {Age}";
		//}
	}
}
