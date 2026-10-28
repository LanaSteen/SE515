using HospitallApp.Models;
using HospitallApp.Models.DTOs;
using HospitallApp.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitallApp.Services.Implementations
{
	internal class DoctorService
	{
		private readonly DoctorsRepository _doctorsRepository;

		public DoctorService(DoctorsRepository doctorsRepository)
		{
			_doctorsRepository = doctorsRepository;
		}


		public ICollection<Doctor> GetAllDoctors()  /// amjerad vpatiobt chven tavs rom dto-s ar viyeenebt
		{

			var doctors = _doctorsRepository.GetAllDoctors();

			if (doctors == null)
			{
				return null;
			}

			return doctors;
		}


		public void AddDoctor(CreateDoctorDTO doctor)
		{
			if (doctor == null)
			{
				throw new ArgumentNullException(nameof(doctor));
			}

			Doctor newDoctor = new Doctor
			{
				Name = doctor.Name,
				Specialization = doctor.Specialization,
				RoomNumber = doctor.RoomNumber
			};

			_doctorsRepository.Add(newDoctor);
		}


	}
}
