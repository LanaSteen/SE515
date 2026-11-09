using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Exceptions
{
	internal class TrainerNotFoundException : Exception
	{
	
		public TrainerNotFoundException() : base("Trainer not found.")
		{
		}

		public TrainerNotFoundException(string? message) : base(message)
		{
		}
	}
}
