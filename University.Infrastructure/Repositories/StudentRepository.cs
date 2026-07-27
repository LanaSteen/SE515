using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using University.Core.Interfaces;
using University.Core.Models;

namespace University.Infrastructure.Repositories
{
	public class StudentRepository : IStudentRepository
	{

		private readonly string _path = "C:\\Users\\l4nst\\Desktop\\SE515\\University.Infrastructure\\Data\\Students.txt";


		public async Task<List<Student>> GetStudents()
		{
			var students = new List<Student>();
			var lines = File.ReadAllLines(_path);
			//if (lines.Length == 0)
			//{
			//	throw new Exception("File is empty");
			//}
			foreach (var line in lines)
			{
				var student = JsonSerializer.Deserialize<Student>(line);
				if (student != null)
				{
					students.Add(student);
				}

			}
			return students;
		}



		public async Task<Student> StudentByEmail(string email)
		{
			var student = await GetStudents();  // todo : change this to async     // return (await GetStudents()).FirstOrDefault(s => s.Email == email);
			var st = student.FirstOrDefault(s => s.Email == email);
			return st;
		}


		public async Task SaveStudent(Student student)
		{
			var students =await GetStudents();
			students.Add(student);

			File.WriteAllText(_path, string.Empty);
			foreach (var item in students)
			{
				var json = JsonSerializer.Serialize(item);
				File.AppendAllText(_path, json + Environment.NewLine);
			}


		}

		public async Task UpdateStudent(Student student)
		{
			var students =await GetStudents();
			var existingStudent = students.FirstOrDefault(s => s.Id == student.Id);
			if (existingStudent != null)
			{
				existingStudent.Name = student.Name;
				existingStudent.Age = student.Age;
				existingStudent.Email = student.Email;
				existingStudent.Subject = student.Subject;
				existingStudent.Gender = student.Gender;
				existingStudent.IsVerified = student.IsVerified;
				existingStudent.Password = student.Password;

			}
			int index = students.IndexOf(existingStudent);
			students[index] = existingStudent;

			File.WriteAllText(_path, string.Empty);
			foreach (var item in students)
			{
				var json = JsonSerializer.Serialize(item);
				File.AppendAllText(_path, json + Environment.NewLine);
			}

		}


		public async Task DeleteStudent(int id)
		{
			var students =await GetStudents();
			var studentToDelete = students.FirstOrDefault(s => s.Id == id);
			if (studentToDelete != null)
			{
				students.Remove(studentToDelete);
				File.WriteAllText(_path, string.Empty);
				foreach (var item in students)
				{
					var json = JsonSerializer.Serialize(item);
					
					File.AppendAllText(_path, json + Environment.NewLine);
				}
			}
		}

	}
}


//this