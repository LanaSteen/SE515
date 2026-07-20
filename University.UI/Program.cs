using University.Core.Enums;
using University.Core.Interfaces;
using University.Core.Models;
using University.Infrastructure.Repositories;
using University.Services;

namespace University.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{

			IStudentRepository studentRepository = new StudentRepository();

			StudentService studentService = new StudentService(studentRepository);

			//Console.WriteLine("Hello, World!");


			//Student student = new Student();
			//student.Id = 2;  // todo : This should be generated 
			//student.Name = "sxva";
			//student.Age = 20;
			//student.Email = "dssd@ddff.com";
			//student.Gender = Gender.Female;
			//student.Subject = new List<Subject>
			//{
			//	new Subject { Id = 1, Title = "Math", Grade = 3 },
			//	new Subject { Id = 2, Title = "Programming", Grade = 5  }
			//};

			//studentService.StudentRegister(student);





			//Student student2 = new Student();
			//student2.Id = 2;  // todo : This should be generated 
			//student2.Name = "John";
			//student2.Age = 20;
			//student2.Email = "dssd@ddff.com";
			//student2.Gender = Gender.Female;
			//student2.Subject = new List<Subject>
			//{
			//	new Subject { Id = 1, Title = "Math", Grade = 3 },
			//	new Subject { Id = 2, Title = "Programming", Grade = 5  }
			//};

			//studentService.UpdateStudent(student2);


			studentService.DeleteStudent(2);

		}
	}
}
