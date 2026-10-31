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

		public Doctor GetDoctorById(int id)
		{
			return _context.Doctors.Find(id);
		}

		public void Delete(Doctor doctor)
		{
			
			_context.Doctors.Remove(doctor);
			_context.SaveChanges();
		}

		public void Add(Doctor doctor)
		{
			_context.Doctors.Add(doctor);
			_context.SaveChanges(); /// აუცილებელია რომ განახლება წავიდეს ბაზაში
		}


		public void Update(int id, Doctor doctor)
		{
			var doctorOld = _context.Doctors.Find(id);
			doctorOld.Name = doctor.Name;
			doctorOld.Specialization = doctor.Specialization;
			doctorOld.RoomNumber = doctor.RoomNumber;

			_context.SaveChanges();
		}

	}
}
