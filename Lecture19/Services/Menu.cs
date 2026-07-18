using Lecture19.Models;
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
					case "4":
						string lastName = Console.ReadLine();
						var studentByLAstName = StudentService.GetStudentByLastName(lastName);
						Console.WriteLine(studentByLAstName);
						break;
					case "5":
						
						var sorted = StudentService.GetSortedStudents(true);
						foreach (var item in sorted)
						{
							Console.WriteLine(item);
						}
						break;
					case "6":
						Console.WriteLine("enter name,lastName,age,email,phone,gpa");
						string name1 = Console.ReadLine();
						string lastName1 = Console.ReadLine();
						int age = int.Parse(Console.ReadLine());
						string email =	Console.ReadLine();
						string phone = Console.ReadLine();
						double gpa1 = double.Parse(Console.ReadLine());


						Student student1 = new Student() {Name = name1, LastName = lastName1, Age = age, Email = email, Phone = phone, GPA = gpa1 };
						StudentService.AddStudent(student1);
						break;

					case "7":
						Console.Write("enter LastName");
						string lastName2 = Console.ReadLine();
						Console.WriteLine();
						Console.Write("enter email");
						string email2 = Console.ReadLine();
						Console.WriteLine();
						List <Student> students = StudentService.GetStudents();
						var getStudent = new Student();

						if (lastName2 != null)
						{
							getStudent = students.FirstOrDefault(x => x.LastName == lastName2);
						}
						else
						{
							getStudent = students.FirstOrDefault(x => x.Email == email2);
						}


						StudentService.DeleteStudent(getStudent);




						//StudentService.DeleteStudent(lastName2);


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
