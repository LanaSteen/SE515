using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture17.Services
{
	internal static class StudentServices
	{

		public static void PrintMenu()
		{
			Console.WriteLine("1. Add student");
			Console.WriteLine("2. Update student point");
			Console.WriteLine("3. Get student point");
			Console.WriteLine("4. Get all students");
			Console.WriteLine("0. Exit");
		}

		public static void StudentMenu()
		{


			List<string> names = new List<string>();

			Dictionary<string, int> studentPoints = new Dictionary<string, int>();


			string studentName;
			bool isValidPint;
			int studentPoint = 0;
			bool isValidName;


			string choose = "-1";
			PrintMenu();
			while (choose != "0")
			{
			
				choose = Console.ReadLine();


				switch (choose)
				{
					case "1":

						Console.WriteLine("enter student name");
						studentName = Console.ReadLine();

						Console.WriteLine("enter student point");
						isValidPint = int.TryParse(Console.ReadLine(), out studentPoint);


						foreach (var item in studentPoints.Keys)
						{
							if (item == studentName)
							{
								throw new ArgumentException("Name is alredy in list");
							}
						}

						names.Add(studentName);
						studentPoints.Add(studentName, studentPoint);

						break;
					case "2":

						Console.WriteLine("enter student name");

						studentName = Console.ReadLine();
						Console.WriteLine("enter student point");
						isValidPint = int.TryParse(Console.ReadLine(), out studentPoint); // 80

						//studentPoints.TryGetValue(studentName, out studentPoint); // version 2

						isValidName = studentPoints.TryGetValue(studentName, out int studentPoint123); // 50
						if (!isValidName)
						{
							Console.WriteLine("there is not such a student");

						}
						else
						{
							studentPoints[studentName] = studentPoint;
						}

						//foreach (var item in studentPoints.Keys)
						//{
						//	if (item != studentName)
						//	{
						//		Console.WriteLine("there is not such a student");
						//	}
						//}


						break;
					case "3":

						Console.WriteLine("enter student name");
						studentName = Console.ReadLine();
						isValidName = studentPoints.TryGetValue(studentName, out studentPoint);

						Console.WriteLine(studentName + " " + studentPoint);
						break;
					case "4":

						foreach (var item in studentPoints)
						{
							Console.WriteLine(item.Key + " " + item.Value);
						}


						break;
					default:
						break;
				}




			}
		}

	}
}
