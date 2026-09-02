namespace Lecture3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");

			//Console.ReadLine();   //  promt  "50"


			// "50" + "100"    //  "50100"

			//int.Parse("50");  //50

			int x = int.Parse("50");
			//byte.Parse("100");  //100

			//int.Parse("rame");  // formart error


			//TryParse()  /// bool



			//bool valid = int.TryParse("50", out int age );
			//bool valid = int.TryParse(Console.ReadLine(), out int age);


			//string ageStr = Console.ReadLine();


			//bool valid = int.TryParse(ageStr, out int age);

			//int age;
			//bool valid = int.TryParse(ageStr, out age);






			//bool valid = byte.TryParse(Console.ReadLine(), out byte age); // 0

			////18  // 


			//if (age >= 18 && valid)
			//{
			//	Console.WriteLine("You can vote");
			//}
			//else if (valid)
			//{
			//	Console.WriteLine("You can not vote");
			//}
			//else
			//{
			//	Console.WriteLine("Invalid input");
			//}




			//int y = Convert.ToInt32("50");


			//დაწერეთ C# პროგრამა,
			//რომელიც დაადგენს სამ რიცხვს შორის უდიდესს.


			//int num1, num2, num3;

			//bool validFirst = int.TryParse(Console.ReadLine(), out num1 );
			//bool validSecond = int.TryParse(Console.ReadLine(), out num2);
			//bool validThird = int.TryParse(Console.ReadLine(), out num3);


			//int result = num3;
			//if(!validFirst || !validSecond || !validThird)
			//{

			//	Console.WriteLine("Invalid input" + result.ToString());

			//}
			//else if(num1> num2 && num1 > num3)
			//{
			//	result = num1;
			//}
			//else if (num2 > num1 && num2 > num3)
			//{
			//	result = num2;
			//}
			//Console.WriteLine(result);






			///დაწერეთ C# პროგრამა ორი მოცემული მთელი რიცხვის 
			///ჯამის გამოსათვლელად. თუ ეს ორი რიცხვი ერთნაირია, 
			///მაშინ დააბრუნეთ გასამმაგებული მათი ჯამი.
			///

			//int num1 = 50;
			//int num2 = 25;


			//if(num1 == num2)
			//{
			//	Console.WriteLine((num1+num2)*3);
			//}

			//else
			//{
			//	Console.WriteLine(num1 + num2);
			//}





			// ჩამოთვლადი 

			int z = 11;

			switch (z)
			{
				case 5:
					Console.WriteLine("x is 5");
					break;
				case 8:
				case 9:
					Console.WriteLine("x is 8 or 9");
					break;
				case 11:
					Console.WriteLine("x is 10 or 11 ");
					return;
				case 10:
					Console.WriteLine("x is 10");
					goto case 11;                         // return;  /// მთლიანად ხურავს მეთოდს 


				default:
					Console.WriteLine("unknown");
					break;
			}





			//break , return, goto



			//Console.WriteLine("HEllo after switch ");


			//მომხმარებელს შეაყვანინე დღე(1–7)
			//გამოიტანე weekday switch-ით



			Console.WriteLine("Enter number 1 - 7 ");

			bool valid = byte.TryParse(Console.ReadLine(), out byte day);





			//if (!valid)
			//{
			//	Console.WriteLine("Wrong Input");
			//}

			//else
			//{

			//	if(day == 1)
			//	{
			//		Console.WriteLine("Monday");
			//	}
			//	else if (day == 2)
			//	{
			//		Console.WriteLine("Tusday");
			//	}
			//	else
			//	{
			//		Console.WriteLine("unknown");
			//	}







			//	switch (day)
			//	{

			//		case 1: 
			//			Console.WriteLine("Monday"); 
			//			break;
			//		case 2:
			//			Console.WriteLine("Tusday");
			//			break;
			//		default:
			//			Console.WriteLine("unknown");
			//			break;
			//	}
			//}






			//მომხმარებელს შეაყვანინე ქულა(0–100)
			//დაბეჭდე:
			//•	90 + → A
			//•	70–89 → B
			//•	50–69 → C
			//•	< 50 → F


			Console.WriteLine("enter point");

			bool validPoint = byte.TryParse(Console.ReadLine(), out byte point);


			//if(!validPoint && point>100)
			//{
			//	Console.WriteLine("Wrong");
			//}
			//else if (point >=90)
			//{
			//	Console.WriteLine("A");
			//}
			//else if (point >=70)
			//{
			//	Console.WriteLine("B");
			//}
			//else if (point >= 50)
			//{
			//	Console.WriteLine("C");
			//}
			//else
			//{
			//	Console.WriteLine("F");
			//}






			//switch(true)
			//{
			//	case true when point >=90:
			//		Console.WriteLine("A");
			//		break;
			//	case true when point >= 80:
			//		Console.WriteLine("A");
			//		break;
			//}



		}
	}
}
