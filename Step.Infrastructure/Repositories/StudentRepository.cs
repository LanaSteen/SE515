using Microsoft.Data.SqlClient;
using Step.Domain.Interfaces;
using Step.Domain.Models.DTOs;
using Step.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Step.Infrastructure.Repositories
{
	public class StudentRepository : IStudentRepository
	{

		private readonly string _connectionString;

		public StudentRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		//vw_FacultyStudents1

		public ICollection<StudentDTO> GetAll()
		{
			List<StudentDTO> students = new List<StudentDTO>();

			const string query = "SELECT * FROM vw_FacultyStudents1";

			using var connection = new SqlConnection(_connectionString);

			using var command = new SqlCommand(query, connection);

			connection.Open();
			using var reader = command.ExecuteReader();
			while (reader.Read())
			{
				if (reader.HasRows)
				{
					students.Add(new StudentDTO
					{
						/*Id= int.Parse(reader["Id"].ToString()),*/
						Id = reader.GetInt32(0),
						//FirstName = reader["FirstName"].ToString(),
						FirstName = reader.GetString(1),
						LastName = reader.GetString(2),
						Name = reader.GetString(3),

						//Age = reader.GetInt32(3),
						//Email = reader.GetString(4),
						//StatusIsActive = reader.GetBoolean(5),
						//FacultyId = reader.GetInt32(6),

					});
				}
			}

			return students;
		}


		//public ICollection<Student> GetAll() 
		//{
		//    List<Student> students = new List<Student>();

		//	const string query = "SELECT * FROM Students";

		//	using var connection = new SqlConnection(_connectionString);

		//	using var command = new SqlCommand(query, connection);

		//	connection.Open();
		//	using var reader = command.ExecuteReader();
		//	while (reader.Read())
		//	{
		//	  if (reader.HasRows) {
		//		students.Add(new Student
		//		{
		//			/*Id= int.Parse(reader["Id"].ToString()),*/
		//			Id = reader.GetInt32(0),
		//			//FirstName = reader["FirstName"].ToString(),
		//			FirstName = reader.GetString(1),
		//			LastName = reader.GetString(2),
		//			Age = reader.GetInt32(3),
		//			Email = reader.GetString(4),
		//			StatusIsActive = reader.GetBoolean(5),
		//			FacultyId = reader.GetInt32(6),

		//		});
		//	}
		//	}

		//	return students;
		//}

		public Student? GetById(int id)
		{
			const string query = "SELECT * FROM Students WHERE Id = @id";


			using var connection = new SqlConnection(_connectionString);

			using var command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@id", id);

			connection.Open();

			using var reader = command.ExecuteReader();
			if (reader.Read())
			{
				return new Student
				{
					Id = reader.GetInt32(0),
					FirstName = reader.GetString(1),
					LastName = reader.GetString(2),
					Age = reader.GetInt32(3),
					Email = reader.GetString(4),
					StatusIsActive = reader.GetBoolean(5),
					FacultyId = reader.GetInt32(6),
				};
			}
			return default;



		}



		public void Add1(Student student)
		{
			const string query = "INSERT INTO Students VALUES(@firstName, @lastName, @age, @email, @statusIsActive, @facultyId)";
			using var connection = new SqlConnection(_connectionString);
			using var command = new SqlCommand(query, connection);

			command.CommandType = CommandType.Text; /// სავალდებულო არაა დეფაულთად ტექსტია

			command.Parameters.AddWithValue("@firstName", student.FirstName);
			command.Parameters.AddWithValue("@lastName", student.LastName);
			command.Parameters.AddWithValue("@age", student.Age);
			command.Parameters.AddWithValue("@email", student.Email);
			command.Parameters.AddWithValue("@statusIsActive", student.StatusIsActive);
			command.Parameters.AddWithValue("@facultyId", student.FacultyId);


			connection.Open();
			command.ExecuteNonQuery();
		}



		public void Add(Student student)
		{
			//const string query = "INSERT INTO Students VALUES(@firstName, @lastName, @age, @email, @statusIsActive, @facultyId)";
			using var connection = new SqlConnection(_connectionString);
			using var command = new SqlCommand("sp_AddStudent", connection);

			command.CommandType = CommandType.StoredProcedure;


			command.Parameters.AddWithValue("@firstName", student.FirstName);
			command.Parameters.AddWithValue("@lastName", student.LastName);
			command.Parameters.AddWithValue("@age", student.Age);
			command.Parameters.AddWithValue("@email", student.Email);
			command.Parameters.AddWithValue("@statusIsActive", student.StatusIsActive);
			command.Parameters.AddWithValue("@facultyId", student.FacultyId);


			connection.Open();
			command.ExecuteNonQuery();
		}
	}
}
