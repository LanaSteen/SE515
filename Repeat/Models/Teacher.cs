using Repeat.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repeat.Models
{
	internal class Teacher : Person, IWorker, IComparable<Teacher>
	{
		public Teacher()
		{
		}

		public int WorkExperience { get; set; } // 6

		public int CompareTo(Teacher? other)
		{
			return this.WorkExperience.CompareTo(other?.WorkExperience);
		}

		public override void Print()
		{
			throw new NotImplementedException();
		}

		public override void PrintAge()
		{
			base.PrintAge();
		}

		public void Work()
		{
			Console.WriteLine("I am working");
		}
	}
}
