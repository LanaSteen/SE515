using Lecture19.Enums;
using Lecture19.Exceptions;
using Lecture19.Interfaces;
using Lecture19.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lecture19.Models
{
	internal class Student : Person, Iprintable, IComparable<Student>
	{
		private double _gpa;
		public double GPA { 
			get => _gpa;
			set
			{
				if (value <0 || value > 4) 
				{ 
	               throw new InvalidGPAException();
				}
				this._gpa = value;
			}
		}
		public Faculty Faculty { get; set; }

		public void Print()
		{
			Console.WriteLine(this);
		}

		public override string? ToString()
		{
			return $"Name: {this.Name}, LastName: {this.LastName}, Age {this.Age}, Email: {this.Email}, Phone: {this.Phone}, GPA: {this.GPA}, Faculty: {this.Faculty}";
		}

		public int CompareTo(Student? other)
		{
			return this.GPA.CompareTo(other.GPA);
		}

		public override bool Equals(object? obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}



		//-1
		//0
		//1
		//sort



		public static bool operator > (Student student, Student other)
		{
			if (student.GPA > other.GPA)
			{
				return true;
			}
			return false;
		}

		public static bool operator <(Student student, Student other)
		{
			if (student.GPA < other.GPA)
			{
				return true;
			}
			return false;
		}

		public static bool operator ==(Student student, Student other)
		{
			if (student.GPA == other.GPA)
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Student student, Student other)
		{
			if (student.GPA != other.GPA)
			{
				return true;
			}
			return false;
		}
	
	
	
	
	}
}


