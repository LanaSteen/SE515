using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Services.Implementationns
{
	public class UserService
	{

		private readonly IUserRepository _userRepository;
		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}


		public ICollection<User> GetAllUses()
		{

			var users = _userRepository.GetAll();
			if(users == null)
			{
				 throw new Exception("Users not found");
			}

			return users;

		}
	}
}
