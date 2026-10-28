using HospitallApp.Data;
using HospitallApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitallApp.Repositories
{
	internal class DoctorsRepository
	{
		private readonly HospitalDbContext _context;

		public DoctorsRepository(HospitalDbContext context)
		{
			_context = context;
		}


		public ICollection<Doctor> GetAllDoctors()
		{
			return _context.Doctors.ToList();
		}


		public void Add(Doctor doctor)
		{
			_context.Doctors.Add(doctor);
			_context.SaveChanges(); /// აუცილებელია რომ განახლება წავიდეს ბაზაში
		}

	}
}
