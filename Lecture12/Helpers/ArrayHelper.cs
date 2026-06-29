using Lecture12.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12.Helpers
{

	//generic   - ზოგადი


	internal class ArrayHelper
	{


		public static void PrintArray<T>(T[] collection)
		{
			foreach (var item in collection)
			{
				Console.WriteLine(item);
			}
		}


		//public static void PrintArray(int[] collection)
		//{
		//	foreach (var item in collection)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//public static void PrintArray(string[] collection)
		//{
		//	foreach (var item in collection)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}

		//public static void PrintArray(Student[] collection)
		//{
		//	foreach (var item in collection)
		//	{
		//		Console.WriteLine(item);    
		//	}
		//}
	}
}


//overload