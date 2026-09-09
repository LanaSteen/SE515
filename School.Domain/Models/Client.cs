using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace School.Domain.Models
{
	internal class Client : User
	{
		public string Address{ get; set; }
	}
}
