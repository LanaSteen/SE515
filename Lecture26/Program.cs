using Lecture26.Attributes;
using Spectre.Console;
using System.Text.Json;


//reflection 
//attribute

namespace Lecture26
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region styling


			//Warning("Warning");
			//Error("Error");
			//Success("Success");
			// attributes
			// reflection


			// var fruit = AnsiConsole.Prompt(
			//    new SelectionPrompt<string>()
			//.Title("What's your favorite fruit?")
			//.AddChoices("Apple", "Banana", "Orange", "Mango", "Strawberry"));

			//	AnsiConsole.MarkupLine($"You selected: [green]{fruit}[/]");


			//var password = new TextPrompt<string>("Enter your [green]password[/]:")
	  //    .Secret();

			//var result = AnsiConsole.Prompt(password);

			//AnsiConsole.MarkupLine($"Password length: [blue]{result.Length}[/] characters");
			//Console.WriteLine("hi"  + result);


			#endregion




			//Product product = new Product();

			//product.Name = "Laptop";
			//product.Price = 1000;

			//Console.WriteLine(JsonSerializer.Serialize(product));



			//PrintAuthors(typeof(Product));



			User user = new User("John", 120, "passwordP1");
			Console.WriteLine(user.Age);

		}



		private static void PrintAuthors(Type type)
		{
			var authors = Attribute.GetCustomAttributes(type);
			foreach (var author in authors)
			{
				if(author is  AuthorAttribute)
				{
					var attr = (AuthorAttribute)author;
					Console.WriteLine($"Author: {attr.Name}, Version: {attr.Version}");
				}

			}
		}


		#region styling

		//static void Warning(string message)
		//{
		//	Console.BackgroundColor = ConsoleColor.Yellow;
		//	Console.WriteLine(message);
		//	Console.ResetColor();
		//}
		//static void Error(string message)
		//{
		//	Console.BackgroundColor = ConsoleColor.Red;
		//	Console.WriteLine(message);
		//	Console.ResetColor();
		//}
		//static void Success(string message)
		//{
		//	Console.BackgroundColor = ConsoleColor.Green;
		//	Console.WriteLine(message);
		//	Console.ResetColor();
		//}

		#endregion

	}
}
