using Repeat.Models;
using System.Globalization;

namespace Repeat
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string path = "C:\\Users\\l4nst\\Desktop\\new515\\Repeat\\Models\\Data\\data.txt";

			//File.ReadAllLines();

			string[] lines = File.ReadAllLines(path);
			List<string> lines2 = new List<string>();

			foreach (var item in lines)   // 82.0,True,Olivia,Jones,21
			{
				string[] dataParts = item.Split(',');   // ["82.0","True","Olivia","Jones","21"]

				Student student = new();

				student.Point = decimal.Parse(dataParts[0]);
				student.Attend = bool.Parse(dataParts[1]);
				student.FirstName = dataParts[2];
				student.LastName = dataParts[3];
				student.Age = byte.Parse(dataParts[4]);

				Console.WriteLine(student);

			}


			Student nweStudent = new();
			nweStudent.Point = 95.5m;
			nweStudent.Attend = true;
			nweStudent.FirstName = "John";
			nweStudent.LastName = "Doe";
			nweStudent.Age = 20;

			//File.write

			//File.WriteAllLines(path, [$"{nweStudent.Point},{nweStudent.Attend},{nweStudent.FirstName},{nweStudent.LastName},{nweStudent.Age}"]);
			File.AppendAllLines(path, [$"{Environment.NewLine}{nweStudent.Point},{nweStudent.Attend},{nweStudent.FirstName},{nweStudent.LastName},{nweStudent.Age}"]);
	

			//Student student = new("John", "Doe", 20, 99.3m, true);
			//student.FirstName = "John";
			//student.LastName = "Doe";
			//student.Age = 20;
			//student.Point = 99.3m;
			//student.Attend = true;


			//Console.WriteLine(student); 



			//Teacher teacher = new();
			//teacher.FirstName = "Jane";
			//teacher.LastName = "Smith";
			//teacher.Age = 30;
			//teacher.WorkExperience = 4;

			//Teacher teacher2 = new();
			//teacher2.FirstName = "Jane2";
			//teacher2.LastName = "Smith2";
			//teacher2.Age = 35;
			//teacher2.WorkExperience = 5;

			//Console.WriteLine(teacher.CompareTo(teacher2)); // -1


			//Person person = new(); // აბსტრაქტულის ნიუ არ შეიძლება


			//Person person = new();


			//Student st = new("John", "Doe", 20, 99.3m, true);
			//st.PrintAge();


			//Student stud1 = new(); // 
			//Student stud2 = new("Alice");
			//Student stud3 = new("Bob", "Smith", 25);  // ref1
			//Student stud4 = new("Bob", "Smith", 25);  // re2

			//Console.WriteLine(stud3);

			//Console.WriteLine(stud3.Equals(stud4)); // false

			//Console.WriteLine(int.MaxValue);

		}


	}
}
