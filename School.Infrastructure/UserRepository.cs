using School.Domain.Interfaces;
using School.Domain.Models;
using System.Text.Json;

namespace School.Infrastructure
{
	public class UserRepository : IUserRepository
	{
		private readonly string path = Path.GetFullPath(
	Path.Combine(
		AppContext.BaseDirectory,
		"..",
		"..",
		"..",
		"..",
		"School.Infrastructure",
		"Data",
		"users.json"
	)
);
		public async Task<List<User>> GetUsers()
		{
			if (!File.Exists(path))
			{
				return new List<User>();
			}

			var json = await File.ReadAllTextAsync(path);

			if (string.IsNullOrWhiteSpace(json))
			{
				return new List<User>();
			}

			var users = JsonSerializer.Deserialize<List<User>>(json);

			return users ?? new List<User>();
		}

		public async Task<User?> GetUserById(int id)
		{
			var users = await GetUsers();

			return users.FirstOrDefault(u => u.Id == id);
		}

		public async Task<User?> GetUserByUsername(string username)
		{
			var users = await GetUsers();

			return users.FirstOrDefault(u => u.UserName == username);
		}

		public async Task AddUser(User user)
		{
			var users = await GetUsers();

			users.Add(user);

			var json = JsonSerializer.Serialize(
				users,
				new JsonSerializerOptions
				{
					WriteIndented = true
				}
			);

			await File.WriteAllTextAsync(path, json);
		}

		public async Task DeleteUser(int id)
		{
			var users = await GetUsers();

			var user = users.FirstOrDefault(u => u.Id == id);

			if (user == null)
				return;

			users.Remove(user);

			var json = JsonSerializer.Serialize(
				users,
				new JsonSerializerOptions
				{
					WriteIndented = true
				}
			);

			await File.WriteAllTextAsync(path, json);
		}

		public async Task UpdateUser(User user)
		{
			var users = await GetUsers();

			var index = users.FindIndex(u => u.Id == user.Id);

			if (index == -1)
				return;

			users[index] = user;

			var json = JsonSerializer.Serialize(
				users,
				new JsonSerializerOptions
				{
					WriteIndented = true
				}
			);

			await File.WriteAllTextAsync(path, json);
		}
	}
}