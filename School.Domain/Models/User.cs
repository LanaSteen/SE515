using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace School.Domain.Models
{
	public class User
	{

		private string _email;
		public int Id { get; set; }
		public string UserName { get; set; }

		public string Email { 
			get 
			
			{
				return _email;
			} 
			
			
			set
			{
				if (!value.Contains("@"))
				{
					throw new ArgumentException("Email must contain '@'");
				}
				if(!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") )
				{
					throw new ArgumentException("Email is not valid");
				}
				_email = value;
			}


		}



		public string VerificationCode { get; set; }



		//public bool IsDeleted { get; set; } = false;
	}
}
