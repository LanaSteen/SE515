namespace Lecture5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region hw


			//			გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების
			//			ტაბულის ერთი ბლოკი. (ათის ნამრავლის ჩათვლით)
			//შესაყვანი სატესტო მონაცემი: 13
			//მოსალოდნელი შედეგი:
			//13 * 1 = 13 13 * 2 = 26.........
			//13 * 10 = 130

			//Console.WriteLine("Enter number");


			//// string str = Console.ReadLine();  //"dsdfg"

			//bool isValid = int.TryParse(Console.ReadLine(), out int num);  //0

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.WriteLine($"{num } * {i} = {num*i}");
			//}






			//დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში 
			//	ფიფქებით შედგენილ პირამიდის ფორმას.
			//	მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა 
			//	შემდეგი სახის პირამიდა:
			//**********




			//Console.Write(" *");


			//int line = 4;


			//for (int i = 1; i <= line; i++) 
			//{


			//	for (int k = 1; k <=line - i ; k++)
			//	{
			//		Console.Write(" ");
			//	}
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("* ");
			//	}


			//	Console.WriteLine();

			//}




			//დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხულ
			//რიცხვამდე დააჯამებს ყველა ლუწ რიცხვს და პასუხი
			//გამოიტანეთ კონსოლში

			//Console.WriteLine("enter number");
			//bool isValid = int.TryParse(Console.ReadLine(), out int num);

			//int sum = 0;

			//for (int i = 2; i < num; i+=2)
			//{
			//		sum += i;
				
			//}

			//Console.WriteLine(sum);




			//დაწერეთ პროგრამა რომელიც აირჩევს რენდომულ რიცხვს.
			//მომხმარებელმა შემოიყვანოს კონსოლიდან რიცხვი მანამ არ
			//გამოიცნობს არჩეულ რენდომულ რიცხვს.


			Random ran = new Random();
			int random = ran.Next(0,100);  //  -2mlrd +2 

			Console.WriteLine("enter number");




			//int num  = -1 ;
			//bool isValid;



			//while(num != random)
			//{
			//	Console.WriteLine(random);
			//	isValid = int.TryParse(Console.ReadLine(), out  num);
			//}




			//bool isGuessed = true;
			//do
			//{
			//  bool	isValid = int.TryParse(Console.ReadLine(), out int  num);
			//	if(num == random)
			//	{
			//		isGuessed = false;
			//	}
			//	else if(num > random)
			//	{
			//		Console.WriteLine("lower");
			//	}
			//	else
			//	{
			//		Console.WriteLine("higher");
			//	}

			//} while (isGuessed);


			#endregion




			//რიცხვი შეამოქავს მომხმარებელს და ამ რიცხვიდან 100 
			//	მდე დავაჯამოთ ყველა სამის ჯერადი რიცხვი



			//int userNum= 11;

			//int start = userNum + 6 - (userNum % 6);
			//int sum = 0;

			//for (int i = start; i < 100; i += 6)
			//{
			//	sum+= i;
			//}

			//Console.WriteLine(sum);




			  int[]  arr = [];
			  int[]  arr2 = {  };

			int[] arr3 = [20, 60, 30];
			int[] arr4 = {20,60,30};

			int[] arr5 = new int[5];      // [0,0,0,0,0]

			for (int i = 0; i < arr5.Length; i++)
			{
				arr5[i] = ran.Next(20, 100);
			}




			//for (int i = 0; i < arr5.Length; i++)
			//{
			//	Console.WriteLine(arr5[i]);
			//}


			//foreach (var num in arr5)
			//{
			//	Console.WriteLine(num);
			//}



			//arr[0] = 100;



			//int x = 5;
			//int y = x;
			////  5   5 
			//y = 10;
			//// 5     10 



			//int[] arr7 = [20, 20, 50];
			//int[] arr8 = arr7;


			//arr8[0] = 1000;

			//[1000, 20, 50]
			//[1000, 20, 50]








			//value    vs   referance 




			//2D     მატრიცა

			//jagged  - მასივების მასივი


			int[][] numbers = 
				[
				   [10,20,30], 
				   [50,30,60,60,70,50]
				 ];




			//Console.WriteLine(numbers[1][0]);


			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = 0; j < numbers[i].Length; j++)
				{
					Console.WriteLine(numbers[i][j]);
				}
			}



			int[][] numbers3 = new int[2][];

		}
	}
}
