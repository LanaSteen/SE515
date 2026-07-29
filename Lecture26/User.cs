using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture26
{
	public class User
	{
		public string Username { get; set; }
		public int Age { get; set; }
		public string Password { get; set; }

		public User(string username, int age, string password)
		{
			Username = username;
			Age = age;
			Password = password;

			var validator = new UserValidator();
			
			var result = validator.Validate(this);
			
			if (!result.IsValid)
			{
				foreach (var item in result.Errors)
				{
					Console.WriteLine(item.ErrorMessage);
				}
				throw new ArgumentException("Invalid user");
			}
		}


	}

	public class  UserValidator : AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(user => user.Age)
				.InclusiveBetween(1, 120)
				.WithMessage("Age must be between 1 and 120");
			RuleFor(user => user.Username)
				.NotEmpty()
				.WithMessage("Username is required");
			RuleFor(user => user.Password)
				.NotEmpty()
				.WithMessage("Password is required")
				.MinimumLength(8)
				.WithMessage("password must be at least 8 characters")
				.Matches(@"[A-Z]")
				.WithMessage("Password must contain at least one uppercase letter")
				.Matches(@"[a-z]")
				.WithMessage("Password must contain at least one lowercase letter")
				.Matches(@"[0-9]")
				.WithMessage("Password must contain at least one digit letter");
				
		}
	}

}
