using Lecture10.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10.Models
{
	internal class Student : Person
	{
		public Student()
		{
		}

		public Student(string name, int age, double gpa, Lesson[] lessons, Sublect[] subjects) : base(name, age)
		{
			GPA = gpa;
			Lessons = lessons;
			Subjects = subjects;
		}

		//public string Name { get; set; }
		//public int Age { get; set; }

		public double GPA { get; set; }

		public Sublect[] Subjects { get; set; }

		public Lesson[] Lessons { get; set; }
	}



}

//object