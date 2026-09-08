
using RepeatGeneric.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatGeneric
{
	internal class Student
	{


		public decimal Point { get; set; } // 99.3


		public bool Attend { get; set; }

		private string _email; // შემნახველლი
		public string Email
		{

			get => _email; 

			set 
			{
			  if(value.Contains("@")) 
				{
				_email = value;
			   }
				//throw new ArgumentException();
				throw new InvalidEmailException(); //  Invalid email
			}
		}


		// full property -- incapsulation








	}
}




// record
// struct