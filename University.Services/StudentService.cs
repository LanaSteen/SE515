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

			var idCounter = students.Count;

			if (!student.Email.Contains("@"))
			{
				throw new ArgumentException("Invalid email address.");
			}
			var studentFind = students.LastOrDefault(s => s.Id == idCounter + 1);
			if(!studentFind.Equals(null))
			{
				idCounter = studentFind.Id;
			}
			student.Id = idCounter + 1;
			_studentRepository.SaveStudent(student);
		}



		public void UpdateStudent(Student student)
		{

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
