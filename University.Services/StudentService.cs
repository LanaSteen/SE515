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
		private readonly LogService _logService; 

		//DI
		public StudentService(IStudentRepository studentRepository, LogService logService)
		{
			_studentRepository = studentRepository;
			_logService = logService;
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

			string ip = IpGetter.GetIpAddress();
			_logService.Log($"Student registered. - {ip}");


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
			string ip = IpGetter.GetIpAddress();
			_logService.Log($"Student verified. - {ip}");
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
			string ip = IpGetter.GetIpAddress();
			_logService.Log($"Student loged in. - {ip}");
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
			string ip = IpGetter.GetIpAddress();
			_logService.Log($"Student updated. - {ip}");

		}



		public void DeleteStudent(int id)
		{
			if(id <= 0)
			{
				throw new ArgumentException("Invalid student ID.");
			}
			_studentRepository.DeleteStudent(id);
			string ip = IpGetter.GetIpAddress();
			_logService.Log($"Student deleted. - {ip}");
		}

	}
}




//ptok lzfo xzrj taqa

//smtp
//ftp
//http