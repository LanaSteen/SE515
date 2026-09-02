using System;
using System.Collections.Generic;
using System.Text;

namespace Repeat.Models
{
	internal abstract class Person 
	{
		protected Person(string firstName, string lastName, byte age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public byte Age { get; set; }  //0-255


	}
}


// objet