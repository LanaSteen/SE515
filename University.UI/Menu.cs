using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Interfaces;
using University.Infrastructure.Repositories;
using University.Services;

namespace University.UI
{
	public class Menu
	{
		private readonly StudentService _studentService;
		private readonly LogService _logService;
		private readonly IStudentRepository _studentRepository;
		private readonly ILogRepository _logRepository;

		public Menu(StudentService studentService, LogService logService, IStudentRepository studentRepository, ILogRepository logRepository)
		{
			_studentService = studentService;
			_logService = logService;
			_studentRepository = studentRepository;
			_logRepository = logRepository;
		}


		public async Task ShowMenu()
		{
			Console.WriteLine("Welcome to University Management System");

			Console.WriteLine("1. Login");
			Console.WriteLine("2. Register");

			string opption = Console.ReadLine();

			switch (opption)
			{
				case "1":
					await Login();
					break;
				case "2":
					//register
			
				default:
					break;
			}




		}
	
	
		private async Task Login()
		{
			try
			{
				Console.WriteLine("enter email");
				string email = Console.ReadLine();
				Console.WriteLine("enter pass");
				string pass = Console.ReadLine();
				await _studentService.Login(email, pass);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

		}
	
	
	}
}
