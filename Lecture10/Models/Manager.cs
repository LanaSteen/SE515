using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10.Models
{
	internal class Manager : Emloyee
	{
		public Manager()
		{
		}

		//public string Name { get; set; }
		//public int Age { get; set; }
		//public decimal Salary { get; set; }
		public Manager(string name, int age, decimal salary) : base(name, age, salary)
		{
		}


		public override decimal GetSalary()
		{
			return Salary * 2;
		}

	}
}



//მხოლოდ ერთი კლასის მემკვიდრე შეუძლია იყოს
//ინტეფეისის ბევრის