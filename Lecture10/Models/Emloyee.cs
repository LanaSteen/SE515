using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10.Models
{
	internal class Emloyee : Person
	{
		public Emloyee()
		{
		}

		public Emloyee(string name, int age) : base(name, age)
		{
		}
		public Emloyee(string name, int age, decimal salary) : base(name, age)
		{
			Salary = salary;
		}

		public decimal Salary { get; set; }


		public  virtual decimal GetSalary()
		{
			return Salary;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
		}
	}
}




//virtual   - შეუძლია შვილმა ovverride გაუკეთოს და შეუძლია არ გაუკეთოს  - არჩევითია
//abstract - სავალდებულო ovverride
