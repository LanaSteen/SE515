using Lecture14.Exeptions;

namespace Lecture14
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//•  CountElements<T>
			//•	დააბრუნოს მასივში არსებული ელემენტების რაოდენობა (Length-ის გამოყენების გარეშე). 
			//•  FindIndex<T> 
			//•	მოძებნოს გადაცემული ელემენტის ინდექსი.თუ ვერ იპოვა, დააბრუნოს -1. 
			//•  Swap<T>
			//•	შეცვალოს ორი გადაცემული ინდექსის ელემენტები ერთმანეთში.


			User user = new User();
			User user1 = new User(50);
			User user2 = new User("John");
			User user3 = new User("John", 60);

			user3.PrintUser(); // არასტატიკური მეთოდი
			User.SayHi("Hello"); // სტატიკური მეთოდი


			Console.WriteLine(); // სტატიკური



			Random rnd = new Random();
			Console.WriteLine(rnd.Next(0,11)); // არასტაიკური


			int[] number = [50, 60, 30];

			//Console.WriteLine(number[5]);
			int x = 5;
			int y = 0;

			

		



			try
			{
				//Console.WriteLine(x / y);
				//Console.WriteLine(number[5]);
				//int.Parse("ffff");
				user.Age = 130;
			}
			catch (FormatException ex)
			{

				Console.WriteLine("invalid input"  +   ex.Message);
			}
			catch(DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}

			catch (IndexOutOfRangeException ex )
			{
				Console.WriteLine("Array does not have index " + ex.Message);
			}
			catch (InvalidAgeExcepton ex)
			{
				Console.WriteLine(ex.Message);
			}

			catch (Exception ex)
			{

				Console.WriteLine("bolo" + " " + ex.Message);
			}

			finally
			{
				Console.WriteLine("it will work anyway"); // ყველა შემთხვევაში იმუშავებს

				
			}

			Console.WriteLine("hi");

		}
	}
}


//ArgumentException
//IO FileNotFoundException