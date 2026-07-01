
using Lecture14.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture14
{
	internal class User
	{
		public User()
		{

		}

		public User(int age)
		{
			Age = age;
		}
		public User(string name)
		{
			Name = name;
		}
		public User(string name, int age)
		{
			Name = name;
			Age = age;
		}

		//200


		private int _age;

		public int Age
		{
			get { return _age; }
			set 
			{
			  if(value < 0 || value > 120)
				{

					//throw new ArgumentException("Age must be between 0 and 120");

					//throw new InvalidAgeExcepton();
					throw new InvalidAgeExcepton("Age must be between 0 and 120");
				}

			  _age = value;
			
			}
		}





		public string Name { get; set; }


		public void PrintUser()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
		}


		public static void SayHi(string greeting)
		{
			Console.WriteLine(greeting);
		}
	}
}



//გადატვირთვა - overloading