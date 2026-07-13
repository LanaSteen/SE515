using Lecture19.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Lecture19.Models
{
	internal abstract class Person
	{
		private string _email;
		private int _age;

		public string Name { get; set; }
		public string LastName { get; set; }
		public int Age
		{
			get => _age; 
			set 
			{ 
				if(value < 0 || value > 120)
				{
					throw new InvalidAgeException();
				}
				_age = value; 
			
			}
		}
		public string Email
		{
			get => _email; 
			set 
			{
				if (!value.Contains("@"))
				{
					throw new InvalidEmailException("email must contain @");
				}

				if(!Regex.IsMatch(value, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
				{
					throw new InvalidEmailException("email is not valid");
				}

				_email = value;

			}
		}
	    public string Phone { get; set; }

		

		//=>

		//Name
		//LastName
		//Age
		//Email
		//Phone

	}
}
