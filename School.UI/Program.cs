using Microsoft.Extensions.Configuration;
using School.Domain.Interfaces;
using School.Domain.Models;
using School.Infrastructure;
using School.Service.Implementations;
using School.Service.Interfaces;
using Spectre.Console;

namespace School.UI
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			User user = new();

			var coinfiguration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			LoggerService logservice = new();

			IUserRepository _userRepository = new UserRepository();
			IEmailService emailService = new EmailService(coinfiguration);
			UserService _userService = new UserService(_userRepository, emailService, logservice);



			// Add a new user
			await _userService.AddUser(new User
			{
				UserName = "admin",
				Email = "steenlana492@gmail.com",

			});


			AdminMenu adminMenu = new(_userService, _userRepository);


			//await Task.Delay(1000);
			//await adminMenu.ShowMenu();



			//dotnet add package Spectre.Console


		//	Console.WriteLine("Enter password");
		//	var password = new TextPrompt<string>("Enter your [green]password[/]:")
	 //      .Secret();

		//	var result = AnsiConsole.Prompt(password);

		//	AnsiConsole.MarkupLine($"Password length: [blue]{result.Length}[/] characters");



		//	var features = AnsiConsole.Prompt(
	 //    new MultiSelectionPrompt<string>()
		//.Title("Select [green]features[/] to enable:")
		//.AddChoices("Logging", "Caching", "Authentication", "Analytics"));

		//	AnsiConsole.MarkupLine($"Enabled: [blue]{string.Join(", ", features)}[/]");






		//	var fruit = AnsiConsole.Prompt(
	 //     new SelectionPrompt<string>()
		//.Title("What's your favorite fruit?")
		//.AddChoices("Apple", "Banana", "Orange", "Mango", "Strawberry"));

		//	AnsiConsole.MarkupLine($"You selected: [green]{fruit}[/]");
		}
	}
}
