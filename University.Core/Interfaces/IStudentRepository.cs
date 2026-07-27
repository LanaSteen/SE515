using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Models;

namespace University.Core.Interfaces
{
	public interface IStudentRepository
	{
		Task<List<Student>> GetStudents();
		Task<Student> StudentByEmail(string email);
		Task SaveStudent(Student student);
		Task UpdateStudent(Student student);
		Task DeleteStudent(int id);
	}
}
