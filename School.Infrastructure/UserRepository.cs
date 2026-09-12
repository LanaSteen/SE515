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

		public List<User> GetUsers()
		{
			var json = File.ReadAllText(path);
			var users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(json);
			return users;
		}

		public User GetUserById(int id)
		{
			var json = File.ReadAllText(path);
			var user = System.Text.Json.JsonSerializer.Deserialize<User>(json);
			return user;
		}
		public User GetUserByUsername(string username)
		{
			var json = File.ReadAllText(path);
			var user = System.Text.Json.JsonSerializer.Deserialize<User>(json);
			return user;
		}

		public void AddUser(User user)
		{
			var users = GetUsers();
			users.Add(user);
			var json = System.Text.Json.JsonSerializer.Serialize(users);
			File.WriteAllText(path, json);
		}

		public void DeleteUser(int id) {
			var users = GetUsers();
			users.Remove(GetUserById(id));
			var json = System.Text.Json.JsonSerializer.Serialize(users);
			File.WriteAllText(path, json);
		}
		public void UpdateUser(User user) {
			var users = GetUsers();
			var index = users.FindIndex(u => u.Id == user.Id);
			if (index != -1) {
				users[index] = user;
				var json = System.Text.Json.JsonSerializer.Serialize(users);
				File.WriteAllText(path, json);
			}
		}
	}
}
