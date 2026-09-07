using RepeatGeneric.Exceptions;
using RepeatGeneric.Helpers;

namespace RepeatGeneric
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = [ 1, 2, 3, 4, 5 ]; // ფიქსირებული ზომა


			var res = CollectionHelper.FindAll(arr, x=>x>5);
			var res3 = CollectionHelper.FindAll(arr, IsGreater);
			var res4 = CollectionHelper.FindAll(arr,  x => x > 5 );
			var res2 = arr.FindAll(x => x > 2);


			bool IsGreater(int x )
			{
				return x > 5;
			}

			res.PrintFromArr();
				
				//.PrintFromArr(); // 3,4,5


			//Console.WriteLine(arr.FindElementOrDefault(10));


			try
			{
				Console.WriteLine(arr.FindElement(10));
			}
			catch (InvalidEmailException ex)
			{
				Console.WriteLine(ex.Message); // nvalid email
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message); // Element not found
			}

			


			List<int> list = new List<int>() {1,5,6,3,2}; // დინამიური ზომა
		

			string[] texts = ["Hello", "World", "C#", "Programming"];
			bool[] result = new bool[arr.Length];

			Student[] students = [ new Student { Point = 99.3m, Attend = true }, new Student { Point = 85.5m, Attend = false } ];
			students[0].Email = "sdsd@dssds.com";
			Console.WriteLine(students[0].Email);


			HashSet<int> set = new HashSet<int>() {2,3,6,5,4,5,5,5,5};


			//int[] ints = [50,30,60,50,20,70,30,30];
			//var numbers = ints.ToHashSet();

			arr.PrintFromArr(); // extension method


			CollectionHelper.PrintFromArr(arr);
			CollectionHelper.PrintFromArr(texts);
			CollectionHelper.PrintFromArr(students);
			CollectionHelper.PrintFromArr(result);
		}
		//todo var

		//generic - ზოგადი



	}
}






//var  -- რედეკლარირება შეიძლება
//2015 es6
//let const