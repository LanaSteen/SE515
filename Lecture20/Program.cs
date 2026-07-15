namespace Lecture20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//LINQ 

			List <int> numbers = new List<int> {7,19,31,75,45, 50,661,33, 60, 71, 30, 40, 70 , 15};

			//query 

			var odds = from n in numbers 
					   where n % 2 == 1  
					   select n;
			var odds2 = from n in numbers
						where n > 50
						orderby n
						select n;


			//method

			var odds1 = numbers
				.Where(x => x % 2 == 1)  // 50
				.Skip(2)   // 48
				.Take(5)  // 5
				.OrderBy(x => x);
			foreach (var item in odds1)
			{
				Console.WriteLine(item);
			}



			var result = numbers
				.FirstOrDefault(x => x > 100);
			Console.WriteLine(result);
			var result1 = numbers
				.LastOrDefault(x => x > 50);
			Console.WriteLine(result1);


			try
			{
				var result2 = numbers.First(x => x > 100);
				Console.WriteLine(result);
			}
			catch (Exception ex )
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}





//50 60 30 40 70

//Where 
//OrderBy
//GroupBy
//Count


