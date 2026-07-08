using Lecture17.Algorithms;
using Lecture17.Models;
using Lecture17.Services;
using Microsoft.VisualBasic;

namespace Lecture17
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region hw
			//			•	List<string> → სტუდენტების სახელებისთვის 
			//•	Dictionary<string, int> → სტუდენტის სახელი და მისი ქულა

			//			•	მომხმარებელი შეიყვანს სახელს და ქულას
			//•	დაამატეთ List-ში და Dictionary-ში


			//StudentServices.StudentMenu();

			#endregion
	
		
		

			//LINQ 


			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


			List<string> names = new List<string> { "James", "Anna", "John" };

			HashSet<int> numbersSet = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			int[] arr =  [50, 6, 30, 20];


			Queue<int> queue = new Queue<int>();


			List<User> users = new List<User>() {new User("James"), new User("John"), new User("Anna") };
			User userNew = new User("John");

			//Console.WriteLine(CollectionHelper.CustomFirstOrDefault1(users, userNew)); //null

			//Console.WriteLine(CollectionHelper.CustomFirstOrDefault1(names, "John"));
			//Console.WriteLine(CollectionHelper.CustomFirstOrDefault1(numbers, 6));

			//Console.WriteLine(CollectionHelper.CustomFirstOrDefault1(numbersSet, 6));

			//Console.WriteLine(CollectionHelper.CustomFirstOrDefault1(arr, 6));



			Console.WriteLine(CollectionHelper.CustomGetAll(users));




		}
	}
}
