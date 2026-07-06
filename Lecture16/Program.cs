using Lecture16.Models;
using System.Collections;

namespace Lecture16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();

			#region hw
			//List<Book> myLibrary = new List<Book>();
			//Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");


			//myLibrary.Add(book1);
			//myLibrary.Add(new Book("Title2", "Author2"));
			//myLibrary.AddRange(new Book("Title3", "Author3"), new Book("Title4", "Author4"));


			//myLibrary.Insert(0, new Book("Title5", "Author5"));

			//Console.WriteLine(myLibrary.Count);

			//foreach (var book in myLibrary)
			//{
			//	Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
			//}
			//Console.WriteLine("-----");



			////if(myLibrary.Count > 3)
			////{
			////	myLibrary.RemoveAt(3);
			////}


			//try
			//{
			//	myLibrary.RemoveAt(3);
			//}
			//catch (Exception ex)
			//{

			//	Console.WriteLine(ex.Message);
			//}


			//foreach (var book in myLibrary)
			//{
			//	//Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
			//	Console.WriteLine($"wigni: " + book);

			//}




			#endregion


			//   List<int> list = new List<int>();

			//Stack<int> stack = new Stack<int>();  // LIFO  - Last In First Out

			//stack.Push(100);
			//stack.Push(200);
			//stack.Push(300);
			//stack.Pop();
			//stack.Pop();

			//Console.WriteLine(stack.Peek()); //  ვისი ჯერია


			//foreach (var item in stack)
			//{
			//	Console.WriteLine(item);  //100
			//}

			//push pop



			Queue<int> queue = new Queue<int>();  // FIFO   - first in first out
			
			//queue.Enqueue(100);
			//queue.Enqueue(200);
			//queue.Enqueue(300);

			//Console.WriteLine(queue.Peek()); // 100

			//queue.Dequeue();

			//Console.WriteLine(queue.Peek()); // 200
			//queue.Dequeue();





			//HashSet<int> hash = new HashSet<int>(); // უნიკალურ ელემენტებს დასეტავს
			//hash.Add(100);
			//hash.Add(200);
			//hash.Add(100);

			//foreach (var item in hash)
			//{
			//	Console.WriteLine(item);
			//}



			//Book[] arrbook = [new Book("title1", "author1"), new Book("title1", "author1"), new Book("Title3", "Author3")];

			//var uniqueBooks = arrbook.ToHashSet();


			//foreach (var item in uniqueBooks)
			//{
			//	Console.WriteLine(item);
			//}

			//HashSet<Book> hash = new HashSet<Book>(arrbook);


			//int[] arr = new int[] { 1, 2, 1, 1, 5 };

			//var uniqueNumbers = arr.ToHashSet();

			//foreach (var item in uniqueNumbers)
			//{
			//	Console.WriteLine(item);
			//}

			//hello - გამარჯობა
			//hello1 - სალამი

			//key  უნდა იყოს უნიკალური
			Dictionary<int,int> dict = new Dictionary<int, int>();
			dict.Add(1, 100);
			dict.Add(2, 200);
			dict.Add(3, 200);

			foreach (var item in dict)
			{
				Console.WriteLine(item.Key + " " + item.Value );
			}



			Dictionary<string, string> hotline = new Dictionary<string, string>();

			hotline.Add("Manager", "599656565");
			hotline.Add("Marketing", "565645445");
			hotline.Add("Sales", "565645445");

			Console.WriteLine(hotline["Manager"]);
			Console.WriteLine(hotline["Sales"]);



			Dictionary<int, decimal> waightSystem = new Dictionary<int, decimal>();

			waightSystem.Add(1050, 10.5m);
			waightSystem.Add(1000, 10.5m);

			Console.WriteLine(waightSystem[1000]);



			//georgia      Tbilisi,Kukaisi, BAtumi


			Book book1 = new Book("title1", "author1");
			Book book2 = new Book("title2", "author1");

			Charecters Characer1 = new Charecters() { Name = "Character1", IsAntagonist = false };
			Charecters Characer2 = new Charecters() { Name = "Character2", IsAntagonist = true };

			Dictionary<Book, Charecters[]> bookwithCharacters = new Dictionary<Book, Charecters[]>();


			bookwithCharacters.Add(book1, [Characer1, Characer1, Characer1]);
			bookwithCharacters.Add(book2, [Characer1, Characer1, Characer1]);




			//georgia      Tbilisi,Kukaisi, BAtumi

			Dictionary<string, string> countryWithcapitals = new Dictionary<string, string>();
			countryWithcapitals.Add("GE", "Tbilisi");



			Dictionary<string, string[]> countryWithCities = new Dictionary<string, string[]>();
			countryWithCities.Add("GE", ["Tbilisi", "Kutaisi", "Batumi"]);
			countryWithCities.Add("GB", ["London", "Chelie", "Glasgo"]);


		}




	}
}
