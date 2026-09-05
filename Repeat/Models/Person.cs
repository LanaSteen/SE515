using Repeat.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repeat.Models
{
	internal abstract class Person 
	{
		public Person()
		{

		}
		public Person(string firstName)
		{

		}
		protected Person(string firstName, string lastName, byte age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public byte Age { get; set; }  //0-255


		public virtual void PrintAge() // შვილს შეუძლია გადაფაროს მეთოდი
		{
			Console.WriteLine(Age); // ჩემი ასაკი არის age
		}

		public abstract void Print(); // აბსტრაქტული მეთოდი არ აქვს იმპლემენტაცია, შვილს სჭირდება გადაფაროს მეთოდი
	}
}


// objet


//Person.Print()
//	Person per = new();
//per.PrintAge()

//	სტატიკური მეთოდი არ იყენებს კლასი ფროფერთებს 