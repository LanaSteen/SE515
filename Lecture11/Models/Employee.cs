using Lecture11.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Models
{
	public class Employee
	{
		private DateTime _dateOfBirth;

		public Employee(string name, string surname, DateTime dateOfBirth, Country country, Gender gender, Contact contact)
		{
			Name = name;
			Surname = surname;
			DateOfBirth = dateOfBirth;
			Country = country;
			Gender = gender;
			Contact = contact;
		}
		public string Name { get; set; }
		public string Surname { get; set; }

		public DateTime DateOfBirth
		{
			get {return _dateOfBirth; }
			set 
			{ 
			   if(value > DateTime.Now)
				{
					Console.WriteLine("Date of birth cannot be in the future");
					return;
				}
				
					_dateOfBirth = value;
				
			}
		}

		public Country Country { get; set; }
		public Gender Gender { get; set; }
		public Contact Contact { get; set; }




		public byte GetAge()
		{
			int age = DateTime.Now.Year - DateOfBirth.Year;

			if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
			{
				age--;
			}

			return (byte)age;
		}

		public override string? ToString()
		{
			return $"Name: {Name}, Surname: {Surname}, Age: {GetAge()}, Country: {Country}, Gender: {Gender}, Contact: {Contact}";
		}
	}
}
