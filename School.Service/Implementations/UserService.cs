using School.Domain.Interfaces;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Implementations
{
	public class UserService
	{
		//DI
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository) 
		{
			_userRepository = userRepository;
		}


		public async Task<List<User>> GetUsers()
		{
		    var users =	_userRepository.GetUsers();
			if(users == null)
			{
				throw new Exception("No users found");
			}


			return await _userRepository.GetUsers();
		}

		public async Task<User> GetUserById(int id)
		{
			var user = await _userRepository.GetUserById(id);
			if (user == null)
			{
				throw new Exception("User not found");
			}
			return user;
		}

		public async Task<User> GetUserByUsername(string name) 
		{ 
		  if(string.IsNullOrEmpty(name))
			{
				throw new Exception("Name is null or empty");
			}
			return await _userRepository.GetUserByUsername(name);
		}


		public async Task AddUser(User user)
		{
		
			if (user == null)
			{
				throw new Exception("User is null");
			}
			
			List<User> users =await _userRepository.GetUsers();
			int nextId = users.MaxBy(u => u.Id).Id++;
			user.Id = nextId;
			_userRepository.AddUser(user);
		}



		public async Task DeleteUser(int id)
		{  
			if(id < 0)
			{
				throw new Exception("Id is less than or equal to 0");
			}
			await _userRepository.DeleteUser(id); 
		
		}

		public async Task UpdateUser(User user)
		{
			if (user == null)
			{
				throw new Exception("User is null");
			}
		  await _userRepository.UpdateUser(user);
		}
	}
}
