using Repeat.Models;

namespace Repeat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Student student = new("John", "Doe", 20, 99.3m, true);
			//student.FirstName = "John";
			//student.LastName = "Doe";
			//student.Age = 20;
			//student.Point = 99.3m;
			//student.Attend = true;


			Console.WriteLine(student); 



			Teacher teacher = new("Jane", "Smith", 30);
			//teacher.FirstName = "Jane";
			//teacher.LastName = "Smith";
			//teacher.Age = 30;
			teacher.WorkExperience = 5;


			//Person person = new(); // აბსტრაქტულის ნიუ არ შეიძლება




		}

		
	}
}
