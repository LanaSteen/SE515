using Lecture12.Interfaces;
using Lecture13.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Lecture13.Program;

namespace Lecture13.Helpers
{
	internal class ArrayHelper
	{
		public static void PrintArray<T>(T[] collection)
		{
			foreach (var item in collection)
			{
				Console.WriteLine(item);
			}
		}

		//შექმენით ArrayHelper  კლასი და დაამატეთ შემდეგი generic მეთოდები
		//•  PrintReverse<T> 
		//•	დაბეჭდოს მასივის ელემენტები უკუღმა, ბოლო ელემენტიდან პირველამდე.
		//[50,60,50,100]
		public static void PrintReverse<T>(T[] collection)
		{
			for (int i = collection.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(collection[i]);
			}
		}

		//public static void PrintReverse1<T>(T[] collection)
		//{
		//	Array.Reverse(collection);
		//	foreach (var item in collection)
		//	{
		//		Console.WriteLine(item);
		//	}

		//}



		//•  GetFirstElement<T>
		//•	დააბრუნოს მასივის პირველი ელემენტი. 

		public static T GetFirstElement<T>(T[] collection)
		{
			if (collection.Length > 0)
			{
				return collection[0];
			}
			return default;
		}

		public static T GetFirstElement1<T>(T[] collection)
		{
			foreach (var item in collection)
			{
				return item;
			}

			return default;  // 0   null   false
		}





		//•  GetLastElement<T>
		//•	დააბრუნოს მასივის ბოლო ელემენტი. 



		public static T GetLastElement<T>(T[] collection)
		{
			if (collection.Length > 0)
			{
				return collection[collection.Length - 1];
			}
			return default;
		}

		public static T GetLastElement1<T>(T[] collection)
		{
			Array.Reverse(collection);

			foreach (var item in collection)
			{
				return item;
			}

			return default;  // 0   null   false
		}






		//•  ContainsElement<T>
		//•	შეამოწმოს, შეიცავს თუ არა მასივი გადაცემულ მნიშვნელობას და დააბრუნოს true ან false. 
		
		

		public static bool CustomContains<T>(T[] collection, T searchFor)
		{
			//todo int
			//searchFor is struct


			if (typeof(T) == typeof(int))
			{
				return collection.Contains(searchFor);
			}

			foreach (var item in collection)
			{
				return item.Equals(searchFor);    // == არა  
			}
			return false;
		}



		//public static bool CustomContainsInts<T>(T[] collection, T searchFor) // where T : Number, ICalc2, IOutput2  // constraints - შეზღუდვები
		//{
		//	//todo int
		//	//searchFor is struct

		//	if(typeof(T) == typeof(int))
		//	{
		//		return collection.Contains(searchFor);
		//	}

		//	foreach (var item in collection)
		//	{
		//		return item.Equals(searchFor);    // == არა  
		//	}
		//	return false;
		//}















		//•  CountElements<T>
		//•	დააბრუნოს მასივში არსებული ელემენტების რაოდენობა (Length-ის გამოყენების გარეშე). 
		//•  FindIndex<T> 
		//•	მოძებნოს გადაცემული ელემენტის ინდექსი.თუ ვერ იპოვა, დააბრუნოს -1. 
		//•  Swap<T>
		//•	შეცვალოს ორი გადაცემული ინდექსის ელემენტები ერთმანეთში.



	}




}
