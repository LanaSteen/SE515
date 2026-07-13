using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture19.Exceptions
{
	internal class InvalidEmailException : Exception
	{
		public InvalidEmailException() : base("Invalid Email") { }
		

		public InvalidEmailException(string? message) : base(message)
		{
		}
	}
}
