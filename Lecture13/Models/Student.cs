using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture13.Models
{
	internal class Student
	{
		public Student()
		{
		}

		public Student(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Name { get; set; }
		public int Age { get; set; }

		public override bool Equals(object? obj)
		{
			return Name.Equals(((Student)obj).Name);
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode() + Age.GetHashCode();
		}

		public override string? ToString()
		{
			return $"Name: {Name}, Age: {Age}";
		}
	}
}
