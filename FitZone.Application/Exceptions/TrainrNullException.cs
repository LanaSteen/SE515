using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Exceptions
{
	internal class TrainerNullException : Exception
	{

		public TrainerNullException() : base("Trainer can't be null")
		{
		}

		public TrainerNullException(string? message) : base(message)
		{
		}
	}
}
