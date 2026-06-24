using Lecture11.Enums;
using Lecture11.Models;

namespace Lecture11
{
	internal class Program
	{
		static void Main(string[] args)
		{



			//			1.შექმენით enum Country, ჩაამატეთ მასში 4 ქვეყნის დასახელება.



			//2.შექმენით enum Gender, ჩაამატეთ მასში მნიშვნელობები.
			//3.შექმენით enum Contacts ჩაამატეთ შიგნით მასში.მაგ ტელეფონი, მეილი, ფაქსი
			//4.შექმენით Employ კლასი რომელსაც ექნება ზემოთ შექმნილი enum-ების propertebi და პლიუს თავისიფროფერთები: name, surname, dateofbirth(datetime)
			//5.Employ კლასს ჩაუმატეთ პარამეტრიანი კონსტრუქტორი რომელიც ყველა ფროფერთის შეავსებს.
			//6.Employ კლასს ჩაუმატეთ მეთოდი რომელიც გამოთვლის და დაგვიბრუნებს ასაკს.
			//7.შექმენით Employ კლასის 8 ინსტანსი, რომლებსაც ყოველ ორს ერთიდაიგივე ქვეყანა ექნება.
			//8.შეინახეთ ეს ობიექტები Employ[] employs = new Employ[8] ელემენტიან მასივში.
			//9.შექმენით მეთოდი გარეთ ან რამე კლასში რომელიც მიიღებს ორ პარამეტრს, Employ[] მასივს და ქვეყანას, გადაივლის ყოველ ელემენტზე და დაგვიბეჭდავს ისეთ Employ-იებს რომლებსაც ეგ ქვეყანა აქვთ Countryფროფერთიში შენახული.



			//Employee emp = new("john", "doe", DateTime.Parse("2025/05/05"), Country.Armenia, Gender.Male, Contact.Phone);

			//Employee emp1 = new("john", "doe", DateTime.Parse("2025/05/05"), Country.Armenia, Gender.Male, Contact.Phone);

			//Employee[] employees = new Employee[8];

			//for (int i = 0; i < employees.Length; i++)
			//{
			//	employees[i] = new Employee($"john{i}", $"doe{i}", DateTime.Parse("2025/05/05"), Country.Armenia, Gender.Male, Contact.Phone);
			//}

			//Console.WriteLine(Searchcountry(employees, "Armenia"));





			//Sprite sp = new();

			Enemy enemy = new Enemy();
			enemy.X = 50;
			enemy.Y = 150;
			enemy.Name = "Test";
			enemy.Damage = 300;
			enemy.HP = 3;

			Enemy enemy1 = new Enemy();  // აქ სახელი enemy1 არ არის შევსების დროს და მაგიტო არ მუშაობდა compare 
			enemy1.X = 50;
			enemy1.Y = 150;
			enemy1.Name = "Test1";
			enemy1.Damage = 350;
			enemy1.HP = 3;


			Console.WriteLine(enemy.CompareTo(enemy1));  /// todo 

			
		  


			Player player = new();
			player.X = 50;
			player.Y = 150;
			player.Name = "Testplayer";
			player.Score = 0;
			player.HP = 3;



			player.Inventory = [new Gun("AK47", 30), new Gun("M4", 25),];


			Food food = new();
			food.X = 50;
			food.Y = 150;
			food.Name = "Testfood";
			food.Heal = 5;





			Console.WriteLine(player.HP);
			food.Eat(player);

			Console.WriteLine(player.HP); 

		
		
		}



		public static Employee Searchcountry(Employee[] employees, string country)
		{
			foreach (var item in employees)
			{
				if(item.Country.ToString() ==country)
				{
					//Console.WriteLine(item);
					return item;
				}

			}
			return null;
		}

	}
}




//  player 
//	enemy 
//	food