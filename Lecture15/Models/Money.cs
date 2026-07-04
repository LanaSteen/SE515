using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Models
{
	internal class Money : IComparable<Money>
	{
		public string Currency { get; set; }
		public decimal Amount { get; set; }

		public int CompareTo(Money? other)
		{
			return this.Amount.CompareTo(other?.Amount);
		}

		public override string? ToString()
		{
			return $"{this.Amount} {this.Currency}";
		}
	}
}
