using School.Domain.Interfaces;
using School.Domain.Models;
using School.Infrastructure;
using School.Service.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

//const // readonly

namespace School.UI
{
	internal class AdminMenu
	{
		private readonly UserService _userService;
		private readonly IUserRepository _userRepository;
	
		public AdminMenu(UserService userService, IUserRepository userRepository)
		{
			_userService = userService;
			_userRepository = userRepository;
		
		}

		public  void ShowMenu()
		{
			Console.WriteLine("Admin Menu");
			Console.WriteLine("1. Add User");
			Console.WriteLine("2. Delete User");
			Console.WriteLine("3. Update User");
			Console.WriteLine("4. View Users");
			Console.WriteLine("5. Exit");
			var choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					var user = new User();
					Console.WriteLine("Enter user name:");
					user.UserName = Console.ReadLine();
					//IUserRepository userRepository = new UserRepository();
					//UserService userService = new UserService(userRepository); // TodO ობიექტის შექმნა არ სჭირდება  სტატიკი არ უნდა ყოფილიყო მმეთოდი ამას რომ არ გაეჭედა
					_userService.AddUser(user);
					break;
				case "2":
					//DeleteUser();
					break;
				case "3":
					//UpdateUser();
					break;
				case "4":
					//ViewUsers();
					break;
				case "5":
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Invalid choice");
					break;
			}
		}
	}
}
