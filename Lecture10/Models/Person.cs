using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10.Models
{
	internal class Person 
	{
		public Person()
		{
		}

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Name { get; set; }
		public int Age { get; set; }
	}
}



//აბსტრაქტული კალსი  მისი new ვერ მოხდება