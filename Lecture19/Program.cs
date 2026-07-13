using Lecture19.Enums;
using Lecture19.Models;
using Lecture19.Services;
using System.Runtime.InteropServices;

namespace Lecture19
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Student student = new Student();
			student.Print();


		    var student2 = StudentService.GetStudents();



			//while()
			//{

			//}



		}






		
	}
}
