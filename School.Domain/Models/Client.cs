using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace School.Domain.Models
{
	public class Client : User
	{
		public string Address{ get; set; }

		private int _age;  // field    25

		public int Age
		{
			get { return _age; }
			set { 
			
			   if(value > 0 && value < 121)
				{
					_age = value;
				}
				else
				{
					throw new ArgumentException("Age must be between 1 and 120");
				}

			}
		}




		private string _rame;

		public  string printName()
		{
			
			return _rame;
		}






	}
}



