using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IUserRepository
	{
		Task<List<User>> GetUsers();
		Task<User> GetUserById(int id);
		Task<User> GetUserByUsername(string username);
		Task AddUser(User user);
		Task DeleteUser(int id);
		Task UpdateUser(User user);
	}
}
