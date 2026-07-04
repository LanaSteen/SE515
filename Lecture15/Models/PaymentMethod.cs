using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Models
{
	internal abstract class PaymentMethod
	{

		public abstract void ProcessPayment(decimal amount); /// შვილისთვის სავალდებულოად გადაწერა
	}
}
