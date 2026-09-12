using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IUserRepository
	{
		List<User> GetUsers();
		User GetUserById(int id);
		User GetUserByUsername(string username);
		void AddUser(User user);
		void DeleteUser(int id);
		void UpdateUser(User user);
	}
}
