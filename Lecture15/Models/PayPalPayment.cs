using Lecture15.CustomException;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lecture15.Models
{
	internal class PayPalPayment : PaymentMethod
	{

		private string _email;
		public string Email 
		{
		
		   get { return _email; }
			set 
			{ 
				
				string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
				           
				if(!Regex.IsMatch(value, pattern))
				{
					throw new ArgumentException();
				}

				_email = value; 
			
			
			
			}
		}


		public override void ProcessPayment(decimal amount)
		{
			if(amount < 0)
			{
				throw new PaymentException("Invalid amount");
			}
			Console.WriteLine($"Processing PayPal payment for {amount}");
		}
	}
}
