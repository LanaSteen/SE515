using Lecture19.Enums;
using Lecture19.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture19.Services
{
	internal class StudentService
	{


	 public	static List<Student> GetStudents()
		{
			List<Student> students = new List<Student>()
			{
				new Student { Name = "გიორგი", LastName = "ბერიძე", Age = 20, Email = "g.beridze@gmail.com", Phone = "595112233", GPA = 3.8, Faculty = Faculty.IT },
				new Student { Name = "ნინო", LastName = "კაპანაძე", Age = 21, Email = "nino.kapanadze@TSU.ge", Phone = "577445566", GPA = 3.9, Faculty = Faculty.Accounting  },
				new Student { Name = "ლუკა", LastName = "მგელაძე", Age = 19, Email = "luka.mgeladze@tech.online", Phone = "555778899", GPA = 2.7, Faculty = Faculty.IT  },
				new Student { Name = "ანა", LastName = "გელაშვილი", Age = 22, Email = "ana.gela@yahoo.com", Phone = "591223344", GPA = 3.5, Faculty = Faculty.IT },
				new Student { Name = "დავით", LastName = "მაისურაძე", Age = 20, Email = "d.maisuradze@freeuni.edu", Phone = "599334455", GPA = 3.2, Faculty = Faculty.Marketing },
				new Student { Name = "მარიამ", LastName = "კვარაცხელია", Age = 21, Email = "mari.kvara@gmail.com", Phone = "551667788", GPA = 4.0, Faculty = Faculty.IT  },
				new Student { Name = "ირაკლი", LastName = "თოდუა", Age = 23, Email = "i.todua@outlook.com", Phone = "574889900", GPA = 2.9, Faculty = Faculty.IT },
				new Student { Name = "ელენე", LastName = "აშბა", Age = 19, Email = "elene.ashba@art.london", Phone = "593556677", GPA = 3.6, Faculty = Faculty.Accounting},
				new Student { Name = "ალექსანდრე", LastName = "ხუციშვილი", Age = 22, Email = "sandro.khuci@gmail.com", Phone = "598119922", GPA = 3.1, Faculty = Faculty.IT  },
				new Student { Name = "თამარ", LastName = "შენგელია", Age = 20, Email = "tamuna.sh@Iliauni.ge", Phone = "555443322", GPA = 3.7, Faculty = Faculty.IT  }
			};

			return students;
		}
	}
}
