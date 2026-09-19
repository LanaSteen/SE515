using School.Domain.Interfaces;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructure
{
	public class StudentRepository : IStudentRepository
	{

		string path = @"../../../Data/students.json";
		//string path = Directory.GetCurrentDirectory() + @"\Data\users.json";
		//	string path = Path.Combine(
		//Path.GetDirectoryName(typeof(UserRepository).Assembly.Location),
		//"Data",
		//"users.json"

		//		string path = Path.Combine(
		//	AppDomain.CurrentDomain.BaseDirectory,
		//	"Data",
		//	"users.json"
		//);


		//string path = @"C:\Users\l4nst\Desktop\new515\School.Infrastructure\Data\users.json";

		public async Task<List<Student>> GetStudents()
		{
			var json = await File.ReadAllTextAsync(path);
			var students = System.Text.Json.JsonSerializer.Deserialize<List<Student>>(json);
			return students;
		}

		public async Task<Student> GetUserById(int id)
		{
			var json = await File.ReadAllTextAsync(path);
			var student = System.Text.Json.JsonSerializer.Deserialize<Student>(json);
			return student;
		}

		Task<bool> IStudentRepository.CreateStudent(Student student)
		{
			throw new NotImplementedException();
		}

		Task<bool> IStudentRepository.DeleteStudent(int id)
		{
			throw new NotImplementedException();
		}

	

		Task<List<Student>> IStudentRepository.GetStudents()
		{
			throw new NotImplementedException();
		}

		Task<bool> IStudentRepository.UpdateStudent(Student student)
		{
			throw new NotImplementedException();
		}
		//public async Task<User> GetUserByUsername(string username)
		//{
		//	var json = await File.ReadAllTextAsync(path);
		//	var user = System.Text.Json.JsonSerializer.Deserialize<User>(json);
		//	return user;
		//}

		//public async Task AddUser(User user)
		//{
		//	var users = await GetUsers();
		//	users.Add(user);
		//	var json = System.Text.Json.JsonSerializer.Serialize(users);
		//	File.WriteAllText(path, json);
		//}

		//public async Task DeleteUser(int id)
		//{
		//	var users = await GetUsers();
		//	users.Remove(await GetUserById(id));
		//	var json = System.Text.Json.JsonSerializer.Serialize(users);
		//	File.WriteAllText(path, json);
		//}
		//public async Task UpdateUser(User user)
		//{
		//	var users = await GetUsers();
		//	var index = users.FindIndex(u => u.Id == user.Id);
		//	if (index != -1)
		//	{
		//		users[index] = user;
		//		var json = System.Text.Json.JsonSerializer.Serialize(users);
		//		File.WriteAllText(path, json);
		//	}
		//}
	}
}
