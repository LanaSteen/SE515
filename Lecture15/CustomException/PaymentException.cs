using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.CustomException
{
	internal class PaymentException : Exception
	{
		public PaymentException(string? message) : base(message)
		{
		}
		public PaymentException() : base("Payment failed")
		{
		}
	
	}
}
