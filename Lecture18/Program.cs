using Lecture18.Helper;

namespace Lecture18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int>	ints = new List<int>() { 20,40,60, 70};

			var resultEven = CustomAlgorithms.CustomFirst(ints, IsEven); // 20

			Console.WriteLine(resultEven);

			var result50 = CustomAlgorithms.CustomFirst(ints, BiggerTen50); //60

			Console.WriteLine(result50);


			//var resultOdd = CustomAlgorithms.CustomFirst(ints, IsOdd); // error

			string[] names =["Anna", "Bob", "Charlie"];
			string[] emails = ["Anna@dsd", "Bob", "Charlie@gfg"];

			var resultB = CustomAlgorithms.CustomFirst(names, StartWithB);
			Console.WriteLine(resultB);

			var resultA = CustomAlgorithms.CustomFirst(names, StartWithA);
			Console.WriteLine(resultA);



			//var resultX = CustomAlgorithms.CustomFirst(ints, delegate  (int x) { return x % 2 == 0; });
			//var resultX = CustomAlgorithms.CustomFirst(ints,   x => x % 2 == 0);
			//var resultX = CustomAlgorithms.CustomFirst(ints, (int x)  => x % 2 == 0);
			//=>  arrow function  lambda expression 


			IEnumerable<int> resultWhere = CustomAlgorithms.CustomWhere(ints, x => x >50);

			foreach (var item in resultWhere)
			{
				Console.WriteLine(item);
			}


			//IEnumerable<string> resultWhereEamil = CustomAlgorithms.CustomWhere(emails, x => x.Contains("@"));

			//foreach (var item in resultWhereEamil)
			//{
			//	Console.WriteLine(item);
			//}

			IEnumerable<string> resultWhereEamil2 = emails.CustomWhere(x => x.Contains("@"));

			foreach (var item in resultWhereEamil2)
			{
				Console.WriteLine(item);
			}


			string test = "";

			test.Print();



			int x = 50;
			int y = 40;

			int sum = x.Sum(y);
			sum.Sum(50);


			//numbers.Fileter(x => x>50)


		}





		static bool IsEven(int x)
		{

			if(x == 0)
			{
				x = 0;
			}
			return x % 2 == 0;
		}

		static bool IsOdd(int x)
		{
			return x % 2 == 1;
		}
		static bool BiggerTen50(int x)
		{
			return x >50;
		}


		static bool StartWithB(string name)
		{
			return name.StartsWith("B");
		}

		static bool StartWithA(string name)
		{
			return name.StartsWith("A");
		}


	}
}
