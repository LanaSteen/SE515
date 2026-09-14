using School.Domain.Interfaces;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructure
{
	public class UserRepository  : IUserRepository
	{


		string path = @"C:\Users\l4nst\Desktop\new515\School.Infrastructure\Data\users.json";

		public async Task<List<User>> GetUsers()
		{
			var json = await File.ReadAllTextAsync(path);
			var users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(json);
			return users;
		}

		public async Task<User> GetUserById(int id)
		{
			var json = await File.ReadAllTextAsync(path);
			var user = System.Text.Json.JsonSerializer.Deserialize<User>(json);
			return user;
		}
		public async Task<User> GetUserByUsername(string username)
		{
			var json = await File.ReadAllTextAsync(path);
			var user = System.Text.Json.JsonSerializer.Deserialize<User>(json);
			return user;
		}

		public async Task AddUser(User user)
		{
			var users = await GetUsers();
			users.Add(user);
			var json = System.Text.Json.JsonSerializer.Serialize(users);
			File.WriteAllText(path, json);
		}

		public async Task DeleteUser(int id) {
			var users = await GetUsers();
			users.Remove(await GetUserById(id));
			var json = System.Text.Json.JsonSerializer.Serialize(users);
			File.WriteAllText(path, json);
		}
		public async Task UpdateUser(User user) {
			var users = await GetUsers();
			var index = users.FindIndex(u => u.Id == user.Id);
			if (index != -1) {
				users[index] = user;
				var json = System.Text.Json.JsonSerializer.Serialize(users);
				File.WriteAllText(path, json);
			}
		}
	}
}
