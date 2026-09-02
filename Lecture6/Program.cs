using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lecture6
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region hw

			//int[] numbers = { 10, 20, 30 };  // 3
			//numbers[3] = 40; // error
			//numbers[2] = 100;

			//int[] numbers2 = [50, 60, 30];

			//int[] numbers3 = new int[5]; // [0, 0 ,0 ,0,0]

			//int[] numbers4 = new int[3] { 3, 6, 5 };

			//for (int i = 0; i < numbers.Length; i++) 
			//{
			//	bool isvalid = int.TryParse(Console.ReadLine(), out numbers2[i]);
			//	//if (isvalid)
			//	//{
			//	//	numbers2[i] = num;
			//	//}

			//}

			//string 
			//bool 




			//			დავალება 1
			//შექმენით ერთ განზომილებიანი ორი მასივი.
			//შეავსეთ ორივე მასივი ელემენტებით.
			//გააერთიანე ერთ მასივში ორივე მასივის ელემენტები.
			//დაბეჭდეთ საბოლოოდ მიღებული მასივი.
			//მაგალითად, თუ პირველი მასივის ელემენტების: 1 2 3
			//ხოლო მეორე მასივის ელემენტებია : 4 5 6
			//შედეგად უნდა მიიღოთ: resultArray = [1, 2, 3, 4, 5, 6]



			//int[] numbers1 = [1, 2, 3];
			//int[] numbers2 = [4, 5, 6];


			//int[] resultArray = new int[numbers1.Length + numbers2.Length];


			//for (int i = 0; i < numbers1.Length; i++)
			//{
			//	resultArray[i] = numbers1[i];  // [1, 2, 3, 0, 0, 0]
			//}
			//for (int i = 0; i < numbers2.Length; i++)
			//{
			//	resultArray[numbers1.Length +i] = numbers2[i];
			//}







			//			დავალება 2
			//შექმენით ინტების მასივი და შეავსეთ ელემენტებით.
			//მაგ: 3, 5, -4, 8, 11, 1, -1, 6
			//კონსოლიდან გადმოეცით რაღაც რიცხვი რომელსაც შეინახავთ
			//targetSum ცვლადში.
			//მოძებნეთ მასივში ყველა ის ორი ელემენტი რომლის ჯამიც
			//იქნება targetSum ტოლი და ამწყვილებისგან შექმენით მასივი.
			//დააბრუნეთ ამ ელემენტების წყვილები კონსოლში.
			//2 | P a g e
			//მაგალითად: array = { 3, 5, -4, 8, 11, 1, -1, 6}
			//			targetSum = 7
			//შედეგად უნდა მივიღოთ: resultArray = [[1, 6], [8, -1], [-4, 11]]

			//int[] nums = [3, 5, -4, 8, 11, 1, -1, 6];
			//int count = 0;
			//bool isvalid = int.TryParse(Console.ReadLine(), out int targetSum);

			//for (int i = 0; i < nums.Length; i++)  //3
			//{
			//	for (int j = i+1; j < nums.Length; j++)
			//	{
			//		if(nums[j]+nums[i]== targetSum)
			//		{
			//			count++;
			//		}
			//	}
			//}

			//int[][] resultArray = new int[count][];

			//int index = 0;

			//for (int i = 0; i < nums.Length; i++)  //3
			//{
			//	for (int j = i + 1; j < nums.Length; j++)
			//	{
			//		if (nums[j] + nums[i] == targetSum)
			//		{


			//			resultArray[index] = [nums[i], nums[j]];
			//			index++;
			//		}
			//	}
			//}



			//   2D    მატრიცა  
			//Jagged  

			//int[][] points =
			//	[
			//		[20,60,30],
			//		[20],
			//		[]
			//	];


			//Console.WriteLine(points[0][0]);

			//foreach (var item in points)
			//{
			//	foreach (var el in item)
			//	{
			//		Console.WriteLine(el);
			//	}
			//}








			//int[,] marix = 
			//	{
			//	   { 7, 50 },
			//	   { 60, 40},
			//	   { 60, 40},
			//	   { 60, 40}
			//	};






			//მაღაზიაში მოვიდა კონტეინერი მასში არის 
			//	სხვა და სხვა ფასის სხვა და სხვა ყუთები 

			//ცალკე ყუთების ჯამური ღირებულება 
			//	მთლიანი კონტეინერის ღირებულება



			//int[][] container =
			//	[
			//	   [20,60,70],
			//	   [80,50,10],
			//	   [15,30,90]

			//	];

			//int[] sums = new int[container.Length];

			//int totalSum = 0;

			//for (int i = 0; i < container.Length; i++)
			//{

			//	int boxSum = 0;

			//	for (int j = 0; j < container[i].Length; j++)
			//	{

			//		totalSum += container[i][j];
			//		boxSum += container[i][j];

			//	}
			//	sums[i] = boxSum;
			//	Console.WriteLine($"{i+1} box sum is {boxSum}");

			//}


			//Console.WriteLine($"total sum is {totalSum}");



			//int min = sums[0];
			//for (int i = 0; i < sums.Length; i++)
			//{
			//	if (sums[i] < min)
			//	{
			//		min = sums[i];
			//	}
			//}

			//Console.WriteLine(min*0.8);




			string x = "dffd";
			Console.WriteLine(x[0]);

			x = "hello";




			string rame = "dsfd";
			rame = "dsdfdfdfgh";

			StringBuilder sb = new StringBuilder(rame);

			Console.WriteLine(sb);

			sb.Append("hello");
			sb.Append(" world");
			Console.WriteLine(sb);
			sb.AppendLine("hello2");


			sb.Replace("hello", "hi");
			Console.WriteLine(sb);
			sb.ToString();


			string test = "dsfdf";
			


			#endregion

		}
	}
}
