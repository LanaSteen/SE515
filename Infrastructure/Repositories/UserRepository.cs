using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
	public class UserRepository  : IUserRepository
	{


		private readonly string _connectionString;

		public UserRepository(string connectionString)
		{
			_connectionString = connectionString;
		}



		public ICollection<User> GetAll()
		{

			List<User> users = new List<User>();


			string query = "SELECT * FROM users";

			using var conection = new SqlConnection(_connectionString);


			using var command = new SqlCommand(query, conection);


			conection.Open();


			using var reader = command.ExecuteReader();

			while (reader.Read()) 
			{
				users.Add(new User
				{
					Id = (int)reader["Id"],
					Name = reader["Name"].ToString()
				});
			}

			return users;

		}
	}
}
