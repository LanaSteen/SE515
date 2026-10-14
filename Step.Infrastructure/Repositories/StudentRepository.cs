using Microsoft.Data.SqlClient;
using Step.Domain.Interfaces;
using Step.Domain.Models.Entities;
using System;
using System.Collections.Generic;
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



		public ICollection<Student> GetAll() 
		{
		    List<Student> students = new List<Student>();

			const string query = "SELECT * FROM Students";

			using var connection = new SqlConnection(_connectionString);

			using var command = new SqlCommand(query, connection);

			connection.Open();
			using var reader = command.ExecuteReader();
			while (reader.Read())
			{
			  if (reader.HasRows) {
				students.Add(new Student
				{
					/*Id= int.Parse(reader["Id"].ToString()),*/
					Id = reader.GetInt32(0),
					//FirstName = reader["FirstName"].ToString(),
					FirstName = reader.GetString(1),
					LastName = reader.GetString(2),
					Age = reader.GetInt32(3),
					Email = reader.GetString(4),
					StatusIsActive = reader.GetBoolean(5),
					FacultyId = reader.GetInt32(6),

				});
			}
			}

			return students;
		}

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

	}
}
