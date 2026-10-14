using Aplication.Services.Implementationns;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;

namespace UI
{
	internal class Program
	{
		static void Main(string[] args)
		{

		

			IConfiguration config = new ConfigurationBuilder()
		      .AddJsonFile("appsettings.json").Build();


			string connectionString = config.GetConnectionString("DefaultConnection");




			IUserRepository userRepository = new UserRepository(connectionString);


			UserService userService = new UserService(userRepository);


			var users = userService.GetAllUses();
			foreach (var item in users)
			{
				Console.WriteLine(item);
			}
		}
	}
}
