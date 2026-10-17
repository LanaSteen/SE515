using Step.Domain.Models.DTOs;
using Step.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Step.Domain.Interfaces
{
	public interface IStudentRepository
	{
		//ICollection<Student> GetAll();
		ICollection<StudentDTO> GetAll();
		Student? GetById(int id);

		void Add(Student student);
	}
}
