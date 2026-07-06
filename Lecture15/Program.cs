using Lecture15.customException;
using Lecture15.Models;

namespace Lecture15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region hw

			//try
			//{
			//	BankTransfer bankTransfer = new BankTransfer("5050 5050 5050 2123", "Bank of America");
			//	bankTransfer.IBAN = "";
			//	Console.WriteLine(bankTransfer.IBAN);
			//	bankTransfer.ProcessPayment(100);

			//}
			//catch (InvalidIbanException ex)
			//{
			//	Console.WriteLine($"An error occurred: {ex.Message}");
			//}

			//catch (Exception ex)
			//{
			//	Console.WriteLine($"An error occurred: {ex.Message}");
			//}


			#endregion




			//Array 

			//non generic collections
			//int[]

			//<T>

			int[] arr = [220, 300, 601];

			//int[] arr2 = new int[3] { 20, 30, 60 };

			List<int> list = new List<int>() {100,50,60,30,40}; // 200 20 30 60 220 300 601


			Console.WriteLine(list.Count);  // ელემენტების რაოდენობა
			Console.WriteLine(list.Capacity);  // რამდდენი ელემენტი ეტევა ამ დროისთვის

			list.TrimExcess();
			Console.WriteLine(list.Count);  // ელემენტების რაოდენობა
			Console.WriteLine(list.Capacity);


			//Array თუ ზომა ვიით წინასწარ
			//list თუ ზომა არ ვიცით წინასწარ


			int[]  ints = list.ToArray();  
			List<int> list5 = arr.ToList();

			var ramelist = arr.ToList();



			//0  0
			//1  4
			//5  8
			//9  16	
			//12   32
			//16   64
			//1500





			List<int> newlist = new List<int>() { 5,7,8};

			//BankTransfer bankTransfer1 = new BankTransfer("5656 56545 6545 6545","Bank of America");




			Money money1 = new Money();
			money1.Amount = 300;
			money1.Currency = "USD";

			Money money2 = new Money();
			money2.Amount = 200;
			money2.Currency = "USD";

			//moneylist.Add(money1);
			//moneylist.Add(money2);

			List<Money> moneylist = new List<Money>() {money1, money2 };

			//moneylist.AddRange(money1, money2);

			foreach (var item in moneylist)
			{
				Console.WriteLine(item);
			}

			moneylist.Sort();

			Console.WriteLine("Sorted");

			foreach (var item in moneylist)
			{
				Console.WriteLine(item);
			}


			//List<string> list2 = new List<string>();
			//List<BankTransfer> list3 = new List<BankTransfer>();


			//list[0] = 100;
			//list.Add(200);
			//list.AddRange(20, 30, 60);
			//list.AddRange(arr);
			//list.AddRange(newlist);
			//list.Insert(1,1000);     // რომელ ინდექსზე , რა მნიშვნელობა


			//list.Remove(20);  // წაშლის პირველი რაც შეხვდება
			//list.RemoveAt(5); // წაშლის კონკრეტულ ინდექსზე
			////list.Clear();  // წაშლის ყველა ელემენტს


			//list.Sort(); // ზრდადობით ალაგებს
			//list.Reverse(); // პირიქით ალაგებს


			//Console.WriteLine("max " +list.Max());
			//Console.WriteLine("min " + list.Min());
			//Console.WriteLine("average " + list.Average());


			
			


			//Console.WriteLine(list.Count());

			//for (int i = 0; i < list.Count; i++)
			//{
			//	Console.WriteLine(list[i]);
			//}

			//foreach (var item in list)
			//{
			//	Console.WriteLine(item);
			//}

		}
	}
}
