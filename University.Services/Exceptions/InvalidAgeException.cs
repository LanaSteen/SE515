using System;
using System.Collections.Generic;
using System.Text;
using University.Core;

namespace University.Services.Exceptions
{
	public class InvalidAgeException : Exception
	{
		public InvalidAgeException()
		{
		}

		public InvalidAgeException(string? message) : base(message)
		{
			ColloringConsole.Error(message);
		}
	}
}
