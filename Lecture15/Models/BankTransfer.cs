using Lecture15.customException;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Models
{
	internal class BankTransfer : PaymentMethod
	{

	    private string _iban;

		public BankTransfer(string iBAN, string bank)
		{
			IBAN = iBAN;
			Bank = bank;
		}

		public string IBAN
		{
			get
			{
				return _iban;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					//throw new InvalidIbanException();
					throw new InvalidIbanException("IBAN cannot be empty");
				}
				_iban = value;
		
		   }
		}
		public string Bank { get; set; }

		public override void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing Bank Transfer payment for {amount}");
		}


	}
}
