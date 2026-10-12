using Microsoft.Extensions.Configuration;
using Step.Application.Implementatons;
using Step.Domain.Interfaces;
using Step.Domain.Models.DTOs;
using Step.Domain.Models.Entities;
using Step.Infrastructure.Repositories;

namespace Step.UI
{
	internal class Program
	{
		//Database=myDataBase;
		//private static readonly string connectionString = "Data Source=LAPTOP-HE9JLDVE;  Database=StepDB; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
		//private static readonly string connectionString = "Server=LAPTOP-HE9JLDVE;Database=StepDB; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;";
	
		
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");


			IConfiguration config = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json").Build();


			string connectionString = config.GetConnectionString("DefaultConnection");

			IStudentRepository repository = new StudentRepository(connectionString);
			var studetnService = new StudentService(repository);

			studetnService.DisplayAllStudents();



			Console.WriteLine("Enter id of student");
			int id = int.Parse(Console.ReadLine());
			Console.WriteLine(studetnService.GetStudentById(id));


		}
	}

}
