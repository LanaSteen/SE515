using System.Text;

namespace Lecture4
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Console.OutputEncoding = UTF8Encoding.UTF8;
			//Console.ForegroundColor = ConsoleColor.Green;
			//Console.WriteLine("ქართულად");
			//Console.ResetColor();

			#region hw
			//Console.WriteLine("Hello, World!");


			//Console.ReadLine();



			//	Login სისტემა: პროგრამაში გვაქვს
			//username: admin
			//password: 1234
			//მომხმარებელს შემოჰყავს ორივე მნიშვნელობა
			// თუ სწორია კონსოლში გამოიტანე:
			//Welcome!
			// თუ არა:
			//Access denied
			//________________________________________

			//Console.WriteLine("enter user name");
			//string userName = Console.ReadLine();
			//Console.WriteLine("Enter password");
			//string password = Console.ReadLine();

			//if(userName == "admin"  &&  password == "1234")
			//{
			//	Console.WriteLine("Welcome");
			//}
			//else
			//{
			//	Console.WriteLine("Access denied");
			//}







			//			Calculator(switch-ით)
			//მომხმარებელი შეიყვანს:
			//•	რიცხვი 1
			//•	ოპერატორი(+-* /)
			//•	რიცხვი 2
			//კონსოლში გამოიტანე არითმეტიკული ოპერაციის შედეგი. (შემოყვანილი ოპერატორის შესაბამისად)

			//Console.WriteLine("Enter first number");
			//bool isValidFirst = int.TryParse(Console.ReadLine(), out int num1);

			//Console.WriteLine("Enter second number");
			//bool isValidSecond = int.TryParse(Console.ReadLine(), out int num2);

			//Console.WriteLine("Enter opperator + - * /");
			//string opperator = Console.ReadLine();  

			//if(isValidSecond && isValidFirst)
			//{
			//	switch (opperator) 
			//	{
			//		case "+":
			//			int result = num1 + num2;
			//			Console.WriteLine($"{num1} + {num2} = {result}");
			//			//Console.WriteLine(result + "shedegi");
			//			break;
			//		case "-":
			//		    result = num1 - num2;
			//			Console.WriteLine($"{num1} - {num2} = {result}");
			//			break;
			//		case "*":
			//			result = num1 * num2;
			//			Console.WriteLine($"{num1} * {num2} = {result}");
			//			break;
			//		case "/":
			//			if (num2!=0)
			//			{
			//				result = num1 / num2;
			//			}
			//			else
			//			{
			//				result = 0;
			//				Console.WriteLine("devide by zero is not possible");
			//			}

			//			Console.WriteLine($"{num1} / {num2} = {result}");
			//			break;
			//		default: Console.WriteLine("incorrect opeerator");
			//			break;
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Wrong inputs");
			//}






			//			მომხმარებელს შეაყვანინე ასაკი:
			//			დაადგინე და კონსოლში გამოიტანე:
			//•	ბავშვი(0–12)
			//•	თინეიჯერი(13–19)
			//•	ზრდასრული(20–64)
			//•	პენსიონერი(65 +)


			//Console.WriteLine("enter your age");
			//string ageStr = Console.ReadLine();    /* "25" */

			/* true */


			//bool validAge = int.TryParse(ageStr, out int age  /* 25 */  );

			//if(validAge && age >= 65)
			//{
			//	Console.WriteLine("Pesioneri");
			//}
			//else if (validAge && age >= 20)
			//{
			//	Console.WriteLine("ზრდასრული");
			//}
			//else if(validAge && age >= 13)
			//{
			//	Console.WriteLine("თინეიჯერი");
			//}
			//else if (validAge && age >= 0)
			//{
			//	Console.WriteLine("ბაშვი");
			//}
			//else
			//{
			//	Console.WriteLine("არასწორი ინფუთი");
			//}

			// promp()



			#endregion


			//for 

			//for (int i = 0; i < 10; i+=5)
			//{
			//	Console.WriteLine(i);
			//}


			//25   50   მდე ყვლე ლულწი რიცხვი

			//for (int i = 26; i < 50; i+=2)
			//{
			//	//Console.WriteLine(i%2==0  ?  i : "" );
			//	Console.WriteLine(i);
			//}


			//for (int i = 0; i < 10; i++)   ///  i  terator   
			//{
			//	Console.Write(i + " hello ");
			//	for (int j = 0; j < 5; j++)    // j i
			//	{
			//		Console.Write(" " +  j + " ");
			//	}

			//	Console.WriteLine();
			//}



			//0 10  მდე იპოვეთ მარტივი და რთული რიცხვები 

			//	2 - მარტივია
			//	3 - მარტივია
			//	4 - რთულია
			//	5 - მარტივია
			//  6 - რთულია

			//      4 
			//1 2 3 4 


			//for (int i = 2; i < 10; i++)
			//{
			//	int count = 0;
			//	for (int j = 2; j < i; j++)
			//	{ 
			//		if(i % j == 0)
			//		{
			//			count++;
			//		}
			//	}

			//	Console.WriteLine(count >0 ?  $"{i} trulia" : $"{i} martivia" );


			//}



			//for (int i =99; i >= 80; i-=3)
			//{
			//	Console.WriteLine(i);
			//}

			//int x = 0;
			//for (; x< 10 ; )
			//{
			//	Console.WriteLine("hi");
			//	x++;

			//}




			//for (int i = 0; i < 10; i++)
			//{
			//	if (i == 5)
			//	{
			//		break;  // გათიშვა ლუპის  
			//	}
			//}


			//for (int i = 0; i < 10; i++)
			//{
			//	if (i == 5)
			//	{
			//		continue;  // skip იტერწაციის გამოტოვება ლუპში
			//	}
			//	Console.WriteLine(i);

			//}





			//int x = 0;
			//while (x<10) 
			//{

			//	Console.WriteLine(x);
			//	x++;
			//}


			//for  (იტარაციის რაოდენობა ვიცით) vs while   (იტარაციის რაოდენობა არ ვიციტ დამოკიდებულია სხვა bool  პირობაზე )


			//admin 

			//string role = "admin";
			//Console.WriteLine("Enter your role");
			//string userRole = Console.ReadLine();


			//while(role != userRole)
			//{
			//	Console.WriteLine("try again");
			//	userRole = Console.ReadLine();
			//}
			//Console.WriteLine("welcome");



			//while 


			//do
			//{

			//	Console.WriteLine("hi");


			//} while (false);





			//string role = "admin";
			//string userRole;


			//do
			//{
			//	 Console.WriteLine("Enter your role");
			//	 userRole = Console.ReadLine();
			//} while (role != userRole);


			//do while 





			// foreach    -  კოლექციებზე მუშაობს  - მასივი 


			//for  in  

			//byte[] arr = [15, 60, 30];

			//foreach (var item in arr)
			//{
				
			//}








		}
	}
}
