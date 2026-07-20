using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Models;

namespace University.Core.Interfaces
{
	public interface IStudentRepository
	{
		List<Student> GetStudents();
		Student StudentByEmail(string email);
		void SaveStudent(Student student);

		void UpdateStudent(Student student);
		void DeleteStudent(int id);
	}
}
