using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture18
{
	internal class User : IComparable<User>
	{
		public string FirstName { get; set; }
		public int Age { get; set; }
		public int CompareTo(User? other)
		{


			return this.Age.CompareTo(other?.Age ?? 0);


		}
	}

}

