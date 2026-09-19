using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Interfaces
{
	public interface IStudentService
	{
		Task<List<Student>> GetStudentslsit();
	}
}
