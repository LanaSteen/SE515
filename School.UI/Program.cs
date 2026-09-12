using School.Domain.Interfaces;
using School.Domain.Models;
using School.Infrastructure;
using School.Service.Implementations;

namespace School.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{

			User user = new();


			IUserRepository _userRepository = new UserRepository();
			UserService _userService = new UserService(_userRepository);

		
			AdminMenu adminMenu = new(_userService, _userRepository);

			adminMenu.ShowMenu();
			

		}
	}
}
