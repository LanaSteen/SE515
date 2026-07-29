using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture26.Attributes
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	internal class AuthorAttribute : Attribute
	{
		public string Name;
		public double Version;

		public AuthorAttribute(string name)
		{
			Name = name;
			Version = 1.0;
		}

	}
}

