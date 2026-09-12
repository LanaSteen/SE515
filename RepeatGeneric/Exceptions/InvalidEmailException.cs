using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatGeneric.Exceptions
{
	internal class InvalidEmailException : Exception
	{
		//public InvalidEmailException()
		//{
		//}

		public InvalidEmailException(string? message) : base(message)
		{
		}

		public InvalidEmailException() : base("Invalid email")
		{
		}
	}
}

