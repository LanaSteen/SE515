using System.Text;

namespace Lecture2
{
	internal class Program
	{
		static void Main(string[] args)
		{



			//Console.WriteLine("dsddfgfg");  // console.log()

			//   string str =	Console.ReadLine();   // string  // prompt("") 


			//string name;
			//name = "Saxeli";




			//int   -2147483648  2147483647
			//	byte  0 255



			//byte age = 50;


			//int x =int.Parse(Console.ReadLine()); // "dsdd" error 


			//int z = int.Parse("5");  // 5 




			//Console.WriteLine("Enter a age");

			//string ageStr = Console.ReadLine();

			////int age;

			//bool isValidAge = int.TryParse(ageStr, out int  age); // "g"




			//Convert 


			//int num5 = Convert.ToInt32(ageStr);




			//byte x = 50;
			//int z = x;     // implicit conversion  არაცხადი 




			//int y = 50;
			//byte z2 = (byte)y; // explicit conversion


			//int z = 257;
			//byte x = (byte)z;

			//Console.WriteLine(x);





			#region opperators


			// =   მინიჭების ოპერატორი
			//+ - * / % 

			//+= -= *= /= 


			//++ -- 
			//==   !=  < >   <= >= 
			//&&   ||  ! 


			//5>5

			//	&& 
			//	x=10

			//?:  ternary operator

			//Console.WriteLine(5 > 4 ? "true" : "false");


			//??     
			//string name = null;

			//string? name =null;

			//Console.WriteLine(name ?? "Unknown"); ;

			//int x = 5;
			//x *= 5;
			//Console.WriteLine(x); //25



			//int x = 5;
			//Console.WriteLine(x++);  // 5

			////6


			//Console.WriteLine(++x);  // 7



			//+  

			//Console.WriteLine("Hello " + "World");


			//სტრინგის ინტერპოლაცია `${ }`

			//string word1 = "Hello";
			//string word2 = "World";

			//Console.WriteLine($"{word1} {word2}.");

			//Console.WriteLine(word1 + " " + word2 + ".");


			#endregion





			#region  statements

			//int x = 5;
			//int y = 3;
			//int z = 2;

			//if (x>y) 
			//{
			//	if (x>z)
			//	{
			//		Console.WriteLine("Metia");
			//	}
			//}
			//else if (x>z)
			//{
			//	Console.WriteLine("Metia orze");
			//}
			//else
			//{
			//	Console.WriteLine("unknown");
			//}


			#endregion




			//მომხმარებელმა შემოიყვანოს sallary
			//თუ მეტია 1000 ზე 
			//	დავუმატოთ ბონუსი 20% და
			//	დავუბეჭდოთ რა ეკუთვნინს
			//	თუ მეტია 1500 დავუმატოთ ბონუსი 15%
			//	და დავუბეჭდოთ რა ეკუთვნინს


			//int.Parse
			//Convert.ToInt32()


			//Console.WriteLine("Enter your Sallary");
			//bool valid = decimal.TryParse(Console.ReadLine(), out decimal sallary);

			////if (valid)  // &&  
			////{
			//	if(sallary >= 1000 && sallary <=1500 && valid)
			//	{
			//		//sallary = sallary + sallary * 20 / 100;

			//		sallary *= 1.2m;
			//	}
			//	else if (sallary >= 1500 && valid)
			//	{
			//		sallary *= 1.15m;
			//	}
			//	else
			//	{
			//		Console.WriteLine("you dont have bonus or invalid input");
			//	}
			////}
			////else
			////{
			////	Console.WriteLine("invalid input");
			////}
			///





			//მომხმარებელმა შემოიყვანოს ასაკი და შემოიყვანოს მოქალაქეობა "GEO"  
			//	თუ ქართველია და 0 18 მდეა უფასო ბილეთი
			//	ქართველია და სრულწლოვანია მივცეთ ნახევარ ფასად 
			//	და თუ ქართველი არ არის სრული თანხა გადაიხადოს



			//Console.OutputEncoding = UTF8Encoding.UTF8;
			//Console.WriteLine("გამარრჯობა");


			Console.WriteLine("Enter Age");
			byte age;
			bool validAge = byte.TryParse(Console.ReadLine(), out age);


			Console.WriteLine("Enter Country");
			string country = Console.ReadLine();

			if (country == "GEO" && age < 18 && validAge)
			{
				Console.WriteLine("free");
			}else if (country == "GEO" && age >= 18 && validAge)
			{
				Console.WriteLine("hulf price");
			}
			else if (validAge)
			{
				Console.WriteLine("full price");
			}
			else
			{
				Console.WriteLine("Invalid input");
			}



		}
	}
}
