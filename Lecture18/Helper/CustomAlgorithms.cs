using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


//Func   -  x, y   -> z
//Predicate - x   -> bool
//Action  - void


namespace Lecture18.Helper
{
	internal static class CustomAlgorithms
	{

		public static IEnumerable<T> CustomFilter<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			List<T> list = new List<T>();
			foreach (var item in collection)
			{
				if (predicate(item))
				{
					list.Add(item);
					//yield return item;
				}
			}

			return list;
		}



		public static T FindElement<T>(IEnumerable<T> collection, T value)
		{
			foreach (var item in collection)
			{
				if (item.Equals(value))
				{
					return item;
				}
			}
			//return default;
			throw new ArgumentException();
		}


		public static T CustomFirst<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{

			foreach (var item in collection)
			{
				if (predicate(item))   //[20,30,40] x=>x<50
				{
					return item;
				}
			}

			throw new NotImplementedException();
		}


		public static T CustomFirstFunc<T>(IEnumerable<T> collection, Func<T, bool> func)
		{

			foreach (var item in collection)
			{
				if (func(item))   //[20,30,40] x=>x<50
				{
					return item;
				}
			}

			throw new NotImplementedException();
		}



		//public static IEnumerable<T> CustomWhere<T>(IEnumerable<T> coolection, Func<T, bool> func)
		//{
		//	List<T> list = new List<T>();
		//	foreach (var item in coolection)
		//	{
		//		if (func(item))
		//		{
		//			list.Add(item);
		//		}
		//	}
		//	return list;
		//}


		//this keyword exstension method


		public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> coolection, Func<T, bool> func = null)
		{
			if (func == null)
			{
				foreach (var item in coolection)
				{

					yield return item;

				}


			}

			foreach (var item in coolection)
			{
				if (func(item))
				{
					yield return item;
				}
			}

		}


		public static void Print(this string message)
		{
			Console.WriteLine("Hello " + message);
		}


		public static int Sum(this int a, int b)
		{
			return a + b;
		}


		// First --  ან ელემენტი პირველივე რასაც იპოვის ან ერორი
		// FirstOrDefault
		// Last
		// LastOrDefault
		// Where





		public static IEnumerable<T> CustomOrderBy<T>(ref IEnumerable<T> collection, bool asc) where T : IComparable<T>
		{
			List<T> list = new List<T>(collection);
			int n = list.Count;

			if (asc)
			{
				for (int i = 0; i < n - 1; i++)
				{
					int minIndex = i;
					for (int j = i + 1; j < n; j++)
					{
						if (list[j].CompareTo(list[minIndex]) < 0)
						{
							minIndex = j;
						}
					}
					if (minIndex != i)
					{
						T temp = list[i];
						list[i] = list[minIndex];
						list[minIndex] = temp;
					}
				}
			}
			else
			{
				for (int i = 0; i < n - 1; i++)
				{
					int minIndex = i;
					for (int j = i + 1; j < n; j++)
					{
						if (list[j].CompareTo(list[minIndex]) > 0)
						{
							minIndex = j;
						}
					}
					if (minIndex != i)
					{
						T temp = list[i];
						list[i] = list[minIndex];
						list[minIndex] = temp;
					}
				}
			}
			collection = list;

			return collection;


		}



	}
}



//სტატიკური new არა
//აბსტრაქტული new არა  

//filter(x=>x>50)
//x => x % 2 ==0

//x => x.StartWith("A")