using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Interfaces;
using University.Core.Models;

namespace University.Services
{
	public class StudentService 
	{

		private readonly IStudentRepository _studentRepository;

		//DI
		public StudentService(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public void StudentRegister(Student student)
		{
			
			var students = _studentRepository.GetStudents();

	
			if (!student.Email.Contains("@"))
			{
				throw new ArgumentException("Invalid email address.");
			}
			int idCounter;
			if (students.Count == 0)
			{
				idCounter = 0;
			}
			else
			{
				idCounter = students.Max(x => x.Id);
			}

			student.Id = idCounter + 1;
			student.Password =  BCrypt.Net.BCrypt.HashPassword(student.Password); //Todo method

			Random random = new Random();
			student.VerificationCode = random.Next(1000, 9999).ToString();


			_studentRepository.SaveStudent(student);
			EmailService.SendEmail(student.Email,"Email verification", $"your verification code is {student.VerificationCode}");
		}

		public void VerifyStudent(string email, string verificationCode)
		{

			Student student = _studentRepository.StudentByEmail(email);

			if (student == null)
			{
				throw new ArgumentException("Invalid email");
			}

			if(student.VerificationCode != verificationCode)
			{
				throw new ArgumentException("Invalid verification code");
			}
			Console.WriteLine("Verification successful!");

			student.IsVerified = true;
			UpdateStudent(student);

		}


		public void Login(string email, string password)
		{
			Student student = _studentRepository.StudentByEmail(email);
			if (student == null)
			{
				throw new ArgumentException("Invalid email");
			}

			if (!BCrypt.Net.BCrypt.Verify(password, student.Password))
			{
				throw new ArgumentException("Invalid password");
			}
			if(!student.IsVerified)
			{
				throw new ArgumentException("Please verify your account.");
			}

			Console.WriteLine("Login successful!");
		}


		//pass123
		public void UpdateStudent(Student student)
		{
			//todo   შემოწმდეს პაროლი თუ იცვლება და თუ კი მაშინ აქაც გვინდა ჰეშირება


			if (!student.Email.Contains("@"))
			{
				throw new ArgumentException("Invalid email address.");
			}


			_studentRepository.UpdateStudent(student);

		}



		public void DeleteStudent(int id)
		{
			if(id <= 0)
			{
				throw new ArgumentException("Invalid student ID.");
			}
			_studentRepository.DeleteStudent(id);
		}

	}
}




//ptok lzfo xzrj taqa