using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.customException
{
	internal class InvalidIbanException : Exception
	{

		public InvalidIbanException(string? message) : base(message)
		{
		}

		public InvalidIbanException() : base("Invalid IBAN")
		{
		}
	}
}
