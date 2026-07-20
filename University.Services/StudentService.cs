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
			if (!student.Email.Contains("@"))
			{
				throw new ArgumentException("Invalid email address.");
			}

			_studentRepository.SaveStudent(student);
		}

	}
}
