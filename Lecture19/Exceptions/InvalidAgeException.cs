using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture19.Exceptions
{
	internal class InvalidAgeException : Exception
	{
		public InvalidAgeException(string? mesage) : base(mesage)
		{
		}

		public InvalidAgeException() : base("Invalid age")
		{
		}
	}
}
