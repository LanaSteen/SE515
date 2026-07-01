using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture14.Exeptions
{
	internal class InvalidAgeExcepton : Exception
	{
		public InvalidAgeExcepton() : base("Age is Invalid")
		{
		}

	

		public InvalidAgeExcepton(string message) : base(message)
		{
		}

		public InvalidAgeExcepton(string message, Exception innerException) : base(message, innerException)
		{
		}
	}




}
