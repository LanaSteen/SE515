using School.Domain.Interfaces;
using School.Domain.Models;
using School.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Implementations
{
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _studentRepository;
		private readonly IEmailService _emailService;
		public StudentService(IStudentRepository studentRepository, IEmailService	emailService)
		{
			_studentRepository = studentRepository;
			_emailService = emailService;
		}
	
		public async Task<List<Student>> GetStudentslsit()
		{
			var students = await _studentRepository.GetStudents();
			if (students == null)
			{
				throw new Exception("No students found");
			}
			return students;
		}


	}
}
