using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture17.Algorithms
{
	internal static class CollectionHelper
	{


		public static T CustomFirstOrDefault1<T>(IEnumerable<T> collection, T searchFor)
		{
			foreach (var item in collection)
			{
				if (item.Equals(searchFor))
				{
					return item;
				}
			}

			Console.WriteLine("could not find");
			return default;

			//for
		}




		//public static T CustomFirstOrDefault<T> (List<T> collection, T searchFor)
		//{
		//	foreach (var item in collection)
		//	{
		//		if(item.Equals(searchFor))
		//		{
		//			return item;
		//		}
		//	}


		//	return default;

		//	//for
		//}



		//public static T CustomFirst<T>(List<T> collection, T searchFor)
		//{
		//	foreach (var item in collection)
		//	{
		//		if (item.Equals(searchFor))
		//		{
		//			return item;
		//		}
		//	}
		//	throw new NotImplementedException();
		//	//for
		//}


		//public static T CustomLastOrDefault<T>(List<T> collection, T searchFor)
		//{

		//	Array.Reverse(collection.ToArray());
		//	foreach (var item in collection)
		//	{
		//		if (item.Equals(searchFor))
		//		{
		//			return item;
		//		}
		//	}


		//	return default;

		//	//for
		//}

		//public static T CustomLast<T>(List<T> collection, T searchFor)
		//{

		//	Array.Reverse(collection.ToArray());
		//	foreach (var item in collection)
		//	{
		//		if (item.Equals(searchFor))
		//		{
		//			return item;
		//		}
		//	}


		//	throw new NotImplementedException();

		//	//for
		//}


		public static bool CustomContains<T>(IEnumerable<T> collection, T searchFor)
		{
			foreach (var item in collection)
			{
				if (item.Equals(searchFor))
				{
					return true;
				}
			}

			return false;
		}

		public static int CustomCount<T>(IEnumerable<T> collection)
		{
			int count = 0;
			foreach (var item in collection)
			{
				count++;
			}
			return count;
		}

		public static void CustomPrint<T>(IEnumerable<T> collection)
		{
		
			foreach (var item in collection)
			{
				Console.WriteLine(item);
			}
	
		}

		public static IEnumerable<T> CustomGetAll<T>(IEnumerable<T> collection)
		{

			foreach (var item in collection)
			{
				 yield return item; // todo example on file 
			}

		}


		



		//IList


		////{50,60,70}      60  

		//{"dsd","dsds}   "dsd"

	}
}
