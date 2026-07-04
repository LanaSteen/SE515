using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lecture15.Models
{
	internal class CreditCardPayment : PaymentMethod
	{

		private string _cardNumber;
		public string CardNumber { 
			get 
			{
				return _cardNumber;
			} set 
			{
				//char[] cardNumberArray = value.ToCharArray();
				//foreach (var item in cardNumberArray)
				//{
				//	//if (!char.IsDigit(item) || value != " ")
				//	//{
				//	//	throw new ArgumentException();
				//	//}




				//}
				string pattern = @"^\d{4}\s\d{4}\s\d{4}\s\d{4}$";
				bool isValid = Regex.IsMatch(value, pattern);
				if (!isValid)
				{
					throw new ArgumentException();
				}


				_cardNumber = value;
		
			}
		}

		public string CardHolder { get; set; }



		public override void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing Credit Card payment for {amount}");
		}
	}
}
