using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture17.Models
{
	internal class User
	{
		public User(string userName)
		{
			UserName = userName;
		}

		public string UserName { get; set; }

		public override bool Equals(object? obj)
		{
			if (obj is User user)
			{
				return user.UserName == UserName;
			}
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return UserName.GetHashCode();
		}

		public override string? ToString()
		{
			return $"{UserName}";
		}
	}
}
