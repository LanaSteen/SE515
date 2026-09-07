using System;
using System.Collections.Generic;
using System.Text;

//Func         <int,int>
//Predicate    bool
//Action       void

//arr.filter(x => x>5)


namespace RepeatGeneric.Helpers
{
	internal static class CollectionHelper
	{
		//[]

		public static void PrintFromArr<T>(this IEnumerable<T> arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}

		public static T FindElementOrDefault<T>(this IEnumerable<T> arr, T element)
		{
			foreach (var item in arr)
			{
				if(item.Equals(element))
				{
					return item;
				}
				
			}
			return default;
		}

		public static T FindElement<T>(this IEnumerable<T> arr, T element)
		{
			foreach (var item in arr)
			{
				if (item.Equals(element))
				{
					return item;
				}
			}

			throw new InvalidOperationException("Element not found");
		}


		                                                            //el > 5
		public static List<T> FindAll<T>(this IEnumerable<T> arr, Predicate<T> predicate)
		{
			List<T> result = new List<T>();
			foreach (var item in arr)
			{
				if (predicate(item))
				{
					result.Add(item);
				}
			}
			return result;
		}


		//public static void PrintFromArr<T>(List<T> list)
		//{
		//	foreach (var item in list)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//public static void PrintFromArr<T>(HashSet<T> list)
		//{
		//	foreach (var item in list)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}

	}
}
