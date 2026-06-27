using Lecture12.Interfaces;



namespace Lecture12.Models
{
	internal class Array1 : IOutput2, ICalc2
	{
		public Array1(int[] collection)
		{
			Collection = collection;
		}

		public Array1()
		{

		}

		public int[] Collection { get; set; }

		public int CountDistinct() //  [50,30, 10, 10]
		{
			bool isDublicated = false;
			int count = 0;
			for(int i = 0; i < Collection.Length; i++) 
			{
				isDublicated = false;
				//Collection[i]
				for (int j = 0; j < Collection.Length; j++)
				{
					if (i == j) { continue; }
					if(Collection[i] == Collection[j])
					{
						isDublicated = true;
						break;
					}
				}
				if (!isDublicated)
				{
					count++;
				}
			}

			return count;
		
		}

		public  int EqualToValue(int valueToCompare) //// [50,30,60,8,40,40,50,50]
		{
			int count = 0;


			foreach (var item in Collection)
			{
				if(item == valueToCompare)
				{
					count++;
				}
			}


			return count;
		}

		public void ShowEven()
		{
			foreach (var item in Collection)
			{
				if (item == 0)
				{
					Console.WriteLine($"{item} is not odd or even");
				}
				
				else if (item % 2 == 0)
				{
					Console.WriteLine($"{item} is even");
				}
			}
		}

		public void ShowOdd()
		{
			foreach (var item in Collection)
			{
				if (item % 2 ==1)
				{
					Console.WriteLine($"{item} is odd");
				}
				else if(item == 0)
				{
					Console.WriteLine($"{item} is not odd or even");
				}
			}

		}
	}
}
