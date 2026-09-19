using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IStudentRepository
	{
		Task<List<Student>> GetStudents();
		Task<Student> GetUserById(int id);
		Task<bool> CreateStudent(Student student);
		Task<bool> UpdateStudent(Student student);
		Task<bool> DeleteStudent(int id);
	}
}
