using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture19.Exceptions
{
	internal class InvalidGPAException : Exception
	{
		public InvalidGPAException() : base("Invalid GPA") { }
	}
}
