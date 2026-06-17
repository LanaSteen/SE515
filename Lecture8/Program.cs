namespace Lecture8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region hw

			//			დავალება 1
			//დაწერეთ ფუნქცია რომელიც მიიღებს ორ ინტ პარამეტრს
			//და აიყვანს პირველ რიცხვ მეორე რიცხვის ხარისხში.
			//მაგალითად:
			//		input: 3 და 2
			//result: 3 - ის კვადრატი 9
			//სხვა მაგალითი:
			//input: 2 და 4
			//result: 2 - ის მეოთხე ხარისხში ანუ 2 * 2 * 2 * 2 იქნება 16


			//Console.WriteLine(power(2, 3));

			//       double power(int num1, int num2)
			//	{
			//		double result = num1;  // todo

			//		for (int i = 5; i < num2+4; i++)
			//		{
			//			result *= num1;
			//		}

			//		return result;
			//	}




			//double power(int num1, int num2)
			//	{

			//		double result = Math.Pow(num1, num2);

			//		return result;

			//	}






			//			დავალება 2
			//დაწერეთ ფუნქცია რომელიც მიიღებს ინტ რიცხვს დაგვიბრუნებს bool
			//მნიშვნელობას იმის მიხედვით რიცხვი მარტივია თუ არა: ანუ იყოფა მარტო საკუთარ თავზე და 1 ზე.
			//მაგ: input: 31 return: true console output: 31 მარტივი რიცხვია
			//2 | P a g e
			//მაგ2: input: 6 return: false console output: 6 არ არის მარტივი რიცხვი

			//6     ->  5 4 3 2  // compose 

			//Console.WriteLine(IsPrime(7));
			//Console.WriteLine(IsPrime(6));

			//bool IsPrime(int num)
			//{

			//	for (int i = 2; i < num; i++)
			//	{
			//		if(num % i == 0)
			//		{
			//			return false;
			//		}
			//	}

			//	return true;

			//}







			//			დავალება 5
			//დაწერეთ რეკურსიული მეთოდი რომელიც გამოთვლის ნებისმიერი რიცხვის ხარისხს,
			//
			//კონსოლიდან შემოიტანეთ რიცხვი და ხარისხი, გადაეცით თქვენ რეკურსიულ
			//მეთოდს და დააბრუნეთ მისი ხარისხი.
			//მაგ:
			//inpt num: 4
			//power: 3
			//console output: 4 –ი ხარისხად 3 არის: 64





			//2  4   
			//2 * (2 3)  =16
			//2 * (2 2)  = 8
			//2 * (2 1)  // 2 = 4

			//Powerer(3, 1);  // 3
			//Console.WriteLine(Powerer(2, 3));

			//int Powerer(int num, int pow)   // (2 1) //  2
			//{
			//	if(pow == 1)
			//	{
			//		return num;
			//	}

			//	return num * Powerer(num, pow - 1);
			//}





			//print();    //  უსასრულო რეკუსრია და არ ვიყენებთ
			//int x = 0;
			//print(x);

			//string print(int num)
			//{
			//	Console.WriteLine(num);
			//	num++;
			//	return print(num);
			//}









			//			დავალება 3
			//დაწერეთ რეკურსიული მეთოდი რომელიც მიიღებს რაიმე სტრინგს
			//კონსოლიდან და დაგვიბრენუბს true ან false იმის მიხედვით არის თუ არა სტრინგი პალიდრომი.
			//განმარტება: პალიდრომი წარმოადგენს ისეთ ტექსტ, რომელიც რომელი
			//მხრიდანაც არ უნდა წავიკითხოთ, ის ერთნაირად იკითხება.
			//მაგ: inp: stepets console output: stepets არის პალინდრომი.
			//მაგ2: inp: noon console output: noon არის პალინდრომი.


			//string palindrome = "stepets";
			////"tepet"
			////	"epe"
			////	"p"

			//Console.WriteLine(isPalindrome(palindrome));

			//bool isPalindrome(string text)
			//{
			//	if(text.Length <= 1)
			//	{
			//		return true;
			//	}
			//	if (text[0] != text[text.Length - 1])
			//	{
			//		return false;
			//	}

			//	string miidlePart = text.Substring(1, text.Length - 2);

			//	return isPalindrome(miidlePart);

			//}



			//bool isPalindrome(string text)
			//{
			//	string reversed = "";
			//	for (int i = text.Length - 1; i >= 0; i--)
			//	{
			//		reversed += text[i];
			//	}

			//	return text == reversed;
			//}



			//bool isPalindrome(string text)
			//{

			//	char[] chars = text.ToCharArray();
			//	Array.Reverse(chars);
			//	string reversed = new string(chars) ;


			//	//for (int i = text.Length - 1; i >= 0; i--)
			//	//{
			//	//	reversed += text[i];
			//	//}

			//	return text == reversed;
			//}








			//TODO

			//8!   ფაქტორიალი


			//8  * 7 * 6 * 5 * 4 * 3 * 2 *1
			//	5 *4 * 3 * 2 * 1


			//int FindFactorial(int num)
			//{

			//}




			//Console.WriteLine(Powerer(2, 3));

			//Random rand = new Random();
			//rand.Next();



			//Program program = new Program();

			//Console.WriteLine(program.Powerer2(2,3));

			#endregion


			User user = new User();  // {}
			user.UserName = "john";
			user.Age = 50;
			user.Email = "dssd@#";


			


			User user2 = new();
			user2.UserName = "james";
			user2.Age = 30;

			var user3 = new User();
			user3.UserName = "Emma";
			user3.Age = -20;


			int[] saxeli = [];
			//User[] users = new User[3];
			User[] users = [user, user2, user3];

			foreach (var item in users)
			{
				item.Print();
			}


			//Console.WriteLine(user);  //   [Object object]
			Console.WriteLine(user.UserName + " " + user.Age);

		}

		static int Powerer(int num, int pow)   // (2 1) //  2
		{
			if (pow == 1)
			{
				return num;
			}

			return num * Powerer(num, pow - 1);
		}


		// int Powerer2(int num, int pow)   // (2 1) //  2
		//{
		//	if (pow == 1)
		//	{
		//		return num;
		//	}

		//	return num * Powerer(num, pow - 1);
		//}



		//c#  oop  - ობიქტზე ორიენტირებული პროგრამირება  
		//es6 2015 class 

		//class  ტიპი  =  blueprint + object 
			//int string bool
			//int x;
		 //   int y;
	   
	}


	class User    //  მახასიათთებლები (ფილდები და პროფერთი)    და მეთოდები
	{

	 private string password;



	 private string _idNumber;
	 public string IdNumber { get; set; }  // full property


		private string _email;
		public string Email { get => _email;
			set 
			{
				if (!value.Contains("@"))
				{
					Console.WriteLine("Email is not valid");
					return;
				}
				_email = value;
			}
		
		}




	  public string UserName;
	  public int Age; 

      public string Phone {  get; set; }


      public void Print()
		{
			Console.WriteLine($"{UserName} {Age} {Email}");
		}
		
	}
}
