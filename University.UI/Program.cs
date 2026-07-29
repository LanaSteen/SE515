using University.Core.Enums;
using University.Core.Interfaces;
using University.Core.Models;
using University.Infrastructure.Repositories;
using University.Services;




namespace University.UI
{
	internal class Program
	{
		static async Task Main(string[] args)
		{


			Menu menu = new Menu(new StudentService(new StudentRepository(), new LogService(new LogRepository())), new LogService(new LogRepository()), new StudentRepository(), new LogRepository());
			await menu.ShowMenu();


			//IStudentRepository studentRepository = new StudentRepository();
			//ILogRepository logRepository = new LogRepository();

			//LogService logService = new LogService(logRepository);
			//StudentService studentService = new StudentService(studentRepository, logService);


			//logService.GetLogCount();
			//Console.WriteLine(logService.GetLogCount());

			//logService.ClearLogBackup();


			// test data
			//IStudentRepository studentRepositoryTest = new StudentRepositoryTest();
			//StudentService studentService = new StudentService(studentRepositoryTest);

			#region login

			//try
			//{
			//	Console.WriteLine("enter email");
			//	string email = Console.ReadLine();
			//	Console.WriteLine("enter pass");
			//	string pass = Console.ReadLine();
			//    await studentService.Login(email, pass);
			//}
			//catch (Exception ex)
			//{

			//	Console.WriteLine(ex.Message);
			//}
			#endregion

			#region Registration
			//Student student = new Student();
			////student.Id = 2;  // todo : This should be generated 
			//student.Name = "Lana";
			//student.Age = 20;
			//student.Email = "steenlana492@gmail.com";
			//student.Password = "pass123"; // salt
			//student.Gender = Gender.Female;
			//student.Subject = new List<Subject>
			//{
			//	new Subject { Id = 1, Title = "Math", Grade = 3 },
			//	new Subject { Id = 2, Title = "Programming", Grade = 5  }
			//};

			//studentService.StudentRegister(student);


			#endregion


			#region verify
			//try
			//{
			//	Console.WriteLine("enter email for verify");
			//	string email = Console.ReadLine();
			//	Console.WriteLine("enter code");
			//	string verificationCode = Console.ReadLine();
			//	studentService.VerifyStudent(email, verificationCode);
			//}
			//catch (Exception ex)
			//{

			//	Console.WriteLine(ex.Message);
			//}


			#endregion



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





			//studentService.DeleteStudent(2);




			//test
			//EmailService.SendEmail("steenlana492@gmail.com", "Test", "gamarjoba verifikaciis kodia 56565");

		}
	}
}
