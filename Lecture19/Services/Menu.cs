using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture19.Services
{
	internal class Menu
	{


		public static void ShowMenu()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("1. ყველა სტუდენტის ჩვენება");
			Console.WriteLine("2. საუკეთესო სტუდენტის პოვნა");
			Console.WriteLine("3. GPA-ის საშუალოს გამოთვლა");
			Console.WriteLine("4. სტუდენტის ძებნა გვარით");
			Console.WriteLine("5. სტუდენტების დალაგება GPA - ის მიხედვით");

			Console.WriteLine("6. ახალი სტუდენტის დამატება");
			Console.WriteLine("7. სტუდენტის წაშლა");
			Console.WriteLine("8.პროგრამიდან გასვლა");
		}



		public static void SelectMenuOptions() 
		{
			string choose="0";
		    while(choose != "8")
			{
				choose = Console.ReadLine();
				switch (choose)
				{
					case "1":
						var list = StudentService.GetStudents();
						foreach (var item in list)
						{
							Console.WriteLine(item);
						}
						break;
					case "2":
						var student = StudentService.GetStudentByBestGPA();
						Console.WriteLine(student);
						break;

					case "3":
						var gpa = StudentService.GetStudentsAverageGPA();
						Console.WriteLine(gpa);
						break;

					default:
						Console.WriteLine("wrong option");
						break;
				}
				ShowMenu();

			}
		
		
		}
//1. ყველა სტუდენტის ჩვენება
//2. საუკეთესო სტუდენტის პოვნა
//3. GPA-ის საშუალოს გამოთვლა
//4. სტუდენტის ძებნა გვარით
//5. სტუდენტების დალაგება GPA - ის მიხედვით
//6. ახალი სტუდენტის დამატება
//7. სტუდენტის წაშლა
//8.პროგრამიდან გასვლა
	}
}
