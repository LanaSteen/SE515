namespace Lecture7
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw


			//			1.შექმენით jagged array სადაც: თითოეულ სტუდენტს აქვს სხვადასხვა
			//			რაოდენობის ქულა. იპოვეთ თითოეულის საშუალო ქულა.


			//int[][] studentsPoint =
			//	[
			//	    [80,90,50],
			//		[75,65,35,40],
			//		[75,65,35],
			//	];


			//for(int i =0; i < studentsPoint.Length; i++)
			//{
			//	double sum = 0;

			//	for(int j = 0; j < studentsPoint[i].Length; j++)
			//	{
			//		sum += studentsPoint[i][j];
			//	}

			//	double avg = sum / studentsPoint[i].Length;

			//	Console.WriteLine($"student {i+1} avarage is {avg}"); ;
			//}



			//2.შექმენით რენდომული 4 ნიშნა პასკოდების არაი(10 წევრი).
			//მომხმარებელს შემოაყვანინეთ კოდი და თუ რომელიმეს დაემთხვა
			//არაიში დაუბეჭდეთ “Correct” თუ არა და “Wrong”.


			//6564 6545  

			//int[] passcodes = new int[10];
			//Random random = new();

			//for (int i = 0; i < passcodes.Length; i++) 
			//{
			//	passcodes[i] = random.Next(1000,9999);  
			//}


			//bool isValid = int.TryParse(Console.ReadLine(), out int userInput);

			//bool isCorrect = false;

			//if (isValid)
			//{
			//	foreach (var item in passcodes)
			//	{
			//		if(item == userInput)
			//		{
			//			isCorrect = true;
			//			break;
			//		}

			//	}
			//}


			//Console.WriteLine(isCorrect ? "Correct" : "Wrong");


			//3.შექმენით int-ების(მათ შორის ნეგატიური რიცხვებიც) მასივი.
			//იპოვეთ მინიმალური და მაქსიმალური რიცხვები(არ გამოიყენოთ არაის მეთოდები).



			//int[] arr = [-10, -50, 30, 75, 10, -2];



			//int min = arr[0];
			//int max = arr[0];

			//for (int i = 1; i < arr.Length; i++) 
			//{
			//	if( arr[i] < min)
			//	{
			//		min = arr[i];
			//	}

			//	if (arr[i] > max) 
			//	{
			//		max = arr[i];
			//	}
			//}


			//Console.WriteLine($"min is {min} and max is {max}");








			//int[] arr = [-10, -50, 30, 75, 10, -2];

			//Array.Sort(arr);
			//Array.Reverse(arr);

			//foreach (var item in arr)
			//{
			//	Console.WriteLine(item);
			//}






			//4.შექმენით სტრინგების მასივი და კონსოლში დაბეჭდეთ ყველა ელემენტის ყველა
			//სიმბოლო(არ გამოიყენოთ არაის მეთოდები).

			//string[] texts = ["ttext", "text2"];

			//foreach (var text in texts)
			//{
			//	//"ttext"
			//	foreach (var symbol in text)
			//	{
			//		Console.WriteLine(symbol);
			//	}
			//}


			//char[] charebi = "ttext".ToCharArray();
			//foreach (var charSymbol in charebi)
			//{
			//	Console.WriteLine(charSymbol);
			//}




			//5.შექმენით იმეილების მასივი და დაადგინეთ ყველა ელემენტი თუ შეიცავს @ სიმბოლოს.
			//(არ გამოიყენოთ არაის და სტრინგის ჩაშენებული მეთოდები).



			//string[] emails = ["dfsf@fdfd", "ghgjj@fdfd"];

			//bool isAllvalid = true;



			//foreach (var item in emails)
			//{
			//	//"dfsf@fdfd"

			//	bool isEmailValid = false;

			//	foreach (var symbol in item)
			//	{
			//		if(symbol == '@')
			//		{
			//			isEmailValid = true;
			//		}
			//	}

			//	isAllvalid = isAllvalid;
			//}



			//Console.WriteLine(isAllvalid ? "All emails are valid" : "not valid");




			//string[] emails = ["df@sf@fdfd", "ghgjj@fdfd"];


			//int count = 0;

			//foreach (var item in emails)
			//{
			//	//"dfsf@fdfd"

			//	//foreach (var symbol in item)
			//	//{
			//	//	if (symbol == '@')
			//	//	{
			//	//		count++;
			//	//		break;
			//	//	}
			//	//}

			//	if (item.Contains("@"))
			//	{
			//		count++;
			//	}

			//}

			//Console.WriteLine(count == emails.Length ? "All valid" : "invalid");








			//palindrome
			//
			//ai ia     step on no pets


			//string palindrome = "ai ia";

			//char[] symbols =  palindrome.ToCharArray();

			//Array.Reverse(symbols);

			//char[] reversed = symbols;


			//string rame = new string(reversed);


			//Console.WriteLine(rame);

			//Console.WriteLine(palindrome == rame ? "palindrome" : "not pallindrome");





			#endregion



			//int x = 5;
			//int y = 5;
			//Console.WriteLine(x+y);





			//reusable  - მრავალჯერ გამოყენებადი კოდი 

			//D R Y  -  dont repeat yourself  


			//მეთოდი  vs ფუნქცია

			//o o p   


			//local  function



			//function  saxeli() { }


			//void - გამომავალი მნიშვნელობა არა აქვს
			//  return //int string bool decimal object null


			//Print();

			//void Print() 
			//{
			//	Console.WriteLine("HEllo");
			//}



			//Print("saxeli", 50);  // arguments

			//void Print(string name, int age)  // parameters
			//{
			//	Console.WriteLine($"{name} {age}");
			//}

			//int num1 = 8;
			//int num2 = 10;


			//   int jami = Sum(5,8);
			//Console.WriteLine(Sum(5, 8));

			//Sum(num1, num2);

			//int Sum(int x, int y)
			//{
			//	Console.WriteLine("jami");
			//	return x+y;

			//}

			//Console.WriteLine(Comp("hello", "HEllo    ")) ;

			//bool Comp(string text1, string text2)
			//{
			//	return text1.ToUpper().Trim() == text2.ToUpper().Trim();
			//}



			//Program.TestMEthod();
			TestMEthod();
			//TestMEthod2(50);


			//Program program = new();
			//program.TestMEthod2(100); /// ეს ცუდია

			Console.WriteLine();  // სტატიკური მეთოდია


			Random rand = new Random();
			//Random.Next()

			rand.Next();  ///  არასტატიკური მეთოდია




			///  ერთმა მეთდმა უნდა გააკეთოს მხოლოდ ერთი საქმე
			///  

			// S R P    - single responcibility principle
		}





	   static void TestMEthod()
		{
			Console.WriteLine("hello");
		
		}

		 int TestMEthod2(int x )
		{
			return x*5;

		}

	}
}
