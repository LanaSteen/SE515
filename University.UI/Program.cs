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
			Console.WriteLine("Hello, World!");


			Student student = new Student();
			student.Id = 1;  // todo : This should be generated 
			student.Name = "Lindsay";
			student.Age = 20;
			student.Email = "dssd@ddff.com";
			student.Gender = Gender.Female;
			student.Subject = new List<Subject>
			{
				new Subject { Id = 1, Title = "Math", Grade = 3 },
				new Subject { Id = 2, Title = "Programming", Grade = 5  }
			};


			IStudentRepository studentRepository = new StudentRepository();

			StudentService studentService = new StudentService(studentRepository);


			studentService.StudentRegister(student);

		}
	}
}
