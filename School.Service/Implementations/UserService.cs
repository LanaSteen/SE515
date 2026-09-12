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


		public List<User> GetUsers()
		{
		    var users =	_userRepository.GetUsers();
			if(users == null)
			{
				throw new Exception("No users found");
			}


			return _userRepository.GetUsers();
		}

		public User GetUserById(int id)
		{
			var user = _userRepository.GetUserById(id);
			if (user == null)
			{
				throw new Exception("User not found");
			}
			return user;
		}

		public User GetUserByUsername(string name) 
		{ 
		  if(string.IsNullOrEmpty(name))
			{
				throw new Exception("Name is null or empty");
			}
			return _userRepository.GetUserByUsername(name);
		}


		public void AddUser(User user)
		{
		
			if (user == null)
			{
				throw new Exception("User is null");
			}
			
			List<User> users = _userRepository.GetUsers();
			int nextId = users.MaxBy(u => u.Id).Id++;
			user.Id = nextId;
			_userRepository.AddUser(user);
		}


		public void DeleteUser(int id)
		{  
			if(id < 0)
			{
				throw new Exception("Id is less than or equal to 0");
			}
			_userRepository.DeleteUser(id); 
		
		}

		public void UpdateUser(User user)
		{
			if (user == null)
			{
				throw new Exception("User is null");
			}
			_userRepository.UpdateUser(user);
		}
	}
}
