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


		public List<Student> GetStudents()
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



		public Student StudentByEmail(string email)
		{
			var student = GetStudents().FirstOrDefault(s => s.Email == email);
			return student;
		}


		public void SaveStudent(Student student)
		{
			var students = GetStudents();
			students.Add(student);
			var json = JsonSerializer.Serialize(students);
			File.WriteAllText(_path, json);

		}

		public void UpdateStudent(Student student)
		{
			var students = GetStudents();
			var existingStudent = students.FirstOrDefault(s => s.Id == student.Id);
			if (existingStudent != null)
			{
				existingStudent.Name = student.Name;
				existingStudent.Age = student.Age;
				existingStudent.Email = student.Email;
				existingStudent.Subject = student.Subject;
				existingStudent.Gender = student.Gender;
			}
			var json = JsonSerializer.Serialize(students);
			File.WriteAllText(_path, json);

		}


		public void DeleteStudent(int id)
		{
			var students = GetStudents();
			var studentToDelete = students.FirstOrDefault(s => s.Id == id);
			if (studentToDelete != null)
			{
				students.Remove(studentToDelete);
				var json = JsonSerializer.Serialize(students);
				File.WriteAllText(_path, json);
			}
		}

	}
}


//this