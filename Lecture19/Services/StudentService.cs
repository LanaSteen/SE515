using Lecture19.Enums;
using Lecture19.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Lecture19.Services
{
	internal class StudentService
	{


		private readonly string path = "C:\\Users\\l4nst\\Desktop\\SE515\\Lecture19\\Data\\StudentsData.txt";


		public static void SaveFileInfo(string text)
		{
			File.AppendAllText("C:\\Users\\l4nst\\Desktop\\SE515\\Lecture19\\Data\\StudentsData.txt", text + Environment.NewLine);

		}

		public static List<Student> GetStudents()
		{
			string[] Lines = File.ReadAllLines("C:\\Users\\l4nst\\Desktop\\SE515\\Lecture19\\Data\\StudentsData.txt");
			List<Student> students = new List<Student>();
			if (Lines.Length == 0)
			{

				students = new List<Student>()
			{
				new Student { Name = "გიორგი", LastName = "ბერიძე", Age = 20, Email = "g.beridze@gmail.com", Phone = "595112233", GPA = 3.8, Faculty = Faculty.IT },
				new Student { Name = "ნინო", LastName = "კაპანაძე", Age = 21, Email = "nino.kapanadze@TSU.ge", Phone = "577445566", GPA = 3.9, Faculty = Faculty.Accounting  },
				new Student { Name = "ლუკა", LastName = "მგელაძე", Age = 19, Email = "luka.mgeladze@tech.com", Phone = "555778899", GPA = 2.7, Faculty = Faculty.IT  },
				new Student { Name = "ანა", LastName = "გელაშვილი", Age = 22, Email = "ana.gela@yahoo.com", Phone = "591223344", GPA = 3.5, Faculty = Faculty.IT },
				new Student { Name = "დავით", LastName = "მაისურაძე", Age = 20, Email = "d.maisuradze@freeuni.edu", Phone = "599334455", GPA = 3.2, Faculty = Faculty.Marketing },
				new Student { Name = "მარიამ", LastName = "კვარაცხელია", Age = 21, Email = "mari.kvara@gmail.com", Phone = "551667788", GPA = 4.0, Faculty = Faculty.IT  },
				new Student { Name = "ირაკლი", LastName = "თოდუა", Age = 23, Email = "i.todua@outlook.com", Phone = "574889900", GPA = 2.9, Faculty = Faculty.IT },
				new Student { Name = "ელენე", LastName = "აშბა", Age = 19, Email = "elene.ashba@art.com", Phone = "593556677", GPA = 3.6, Faculty = Faculty.Accounting},
				new Student { Name = "ალექსანდრე", LastName = "ხუციშვილი", Age = 22, Email = "sandro.khuci@gmail.com", Phone = "598119922", GPA = 3.1, Faculty = Faculty.IT  },
				new Student { Name = "თამარ", LastName = "shengelia", Age = 20, Email = "tamuna.sh@Iliauni.ge", Phone = "555443322", GPA = 3.7, Faculty = Faculty.IT  }
			}; 
			
			}
			else {

				foreach (var item in Lines)
				{
					Student student = JsonSerializer.Deserialize<Student>(item);

					//JsonSerializer.Serialize(item);

					students.Add(student);
				}

			}

			//JSON parse Stringify


			return students;
		}

		public static Student GetStudentByBestGPA()
		{
			List<Student> students = new List<Student>();
			students = GetStudents();

			Student best = students[0];
			//double gpa = students[0].GPA;
			foreach (var item in students)
			{
				if (best.GPA < item.GPA)
				{
					best = item;

				}
			}

			return best;

		}


		public static double GetStudentsAverageGPA()
		{

			List<Student> students = new List<Student>();
			students = GetStudents();

			double sum = 0;
			foreach (var item in students)
			{
				sum += item.GPA;
			}


			return sum / students.Count();
		}


		public static Student GetStudentByLastName(string lastName)
		{
			List<Student> students = new List<Student>();
			students = GetStudents();

			foreach (var item in students)
			{
				if (item.LastName == lastName)
				{
					return item;

				}
			}
			//return null;
			return default;
			//throw new Exception("");

		}


		public static List<Student> GetSortedStudents(bool asc)
		{
			List<Student> students = new List<Student>();
			students = GetStudents();



			var collection = new List<Student>();

			int n = students.Count;

			if (asc)
			{
				for (int i = 0; i < n - 1; i++)
				{
					int minIndex = i;
					for (int j = i + 1; j < n; j++)
					{
						if (students[j].CompareTo(students[minIndex]) < 0)
						{
							minIndex = j;
						}
					}
					if (minIndex != i)
					{
						Student temp = students[i];
						students[i] = students[minIndex];
						students[minIndex] = temp;
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
						if (students[j].CompareTo(students[minIndex]) > 0)
						{
							minIndex = j;
						}
					}
					if (minIndex != i)
					{
						Student temp = students[i];
						students[i] = students[minIndex];
						students[minIndex] = temp;
					}
				}
			}
			collection = students;

			return collection;


		}


		public static void AddStudent(Student student)
		{


			List<Student> students = new List<Student>();
			students = GetStudents();

			if (student is null)
			{
				Console.WriteLine("student could not added its null");
			}
			else
			{
				students.Add(student);
				Console.WriteLine("studdent added");
				foreach (var item in students)
				{
					//SaveFileInfo(JsonSerializer.Serialize(item, new JsonSerializerOptions { WriteIndented = true }));
					SaveFileInfo(JsonSerializer.Serialize(item));
				}

				//File.WriteAllText("C:\\Users\\l4nst\\Desktop\\SE515\\Lecture19\\Data\\StudentsData.txt", students.ToString());
				//File.AppendAllText("C:\\Users\\l4nst\\Desktop\\SE515\\Lecture19\\Data\\StudentsData.txt", student.ToString());


			}



		}




		public static void DeleteStudent(Student student)
		{
			List<Student> students = new List<Student>();
			students = GetStudents();

			//students.Remove(student);

			for (int i = 0; i < students.Count; i++)
			{
				if (students[i].Name == student.Name && students[i].LastName == student.LastName)
				{
					students.RemoveAt(i);

					//foreach (var item in students)
					//{
					//	SaveFileInfo(item.ToString());
					//}




					File.WriteAllText("C:\\Users\\l4nst\\Desktop\\SE515\\Lecture19\\Data\\StudentsData.txt", "");
					foreach (var item in students)
					{
						//SaveFileInfo(item.ToString());
						SaveFileInfo(JsonSerializer.Serialize(item));
					}

				}
			}



		}

	}
}



//srp 

//samsung 25 pro - 50

//samsung 

// First
//FirstOrDefault  - find
//LAstOrDefault - find
//Where - filter