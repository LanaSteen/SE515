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


		public ICollection<DoctorDTO> GetAllDoctors()  /// amjerad vpatiobt chven tavs rom dto-s ar viyeenebt
		{

			var doctors = _doctorsRepository.GetAllDoctors();

			if (doctors == null)
			{
				return null;
			}

			var doctorDTOs = new List<DoctorDTO>();
			foreach (var item in doctors)
			{
				doctorDTOs.Add(new DoctorDTO
				{
					Id = item.Id,
					Name = item.Name,
					Specialization = item.Specialization,
					RoomNumber = item.RoomNumber
				});
			}

			return doctorDTOs;
		}

		public DoctorDTO GetDoctorById(int id)
		{

			if(id <= 0)
			{
				throw new ArgumentException("Id must be greater than 0");
			}

			var doctor = _doctorsRepository.GetDoctorById(id);

			if(doctor == null)
			{
				Console.WriteLine("Doctor not found");
				return null;
			}
			DoctorDTO doctorDTO = new DoctorDTO();
			doctorDTO.Id = doctor.Id;
			doctorDTO.Name = doctor.Name;
			doctorDTO.Specialization = doctor.Specialization;
			doctorDTO.RoomNumber = doctor.RoomNumber;
			return doctorDTO;
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



		public void DeleteDoctor(int id)
		{
			if (id <= 0)
			{
				throw new ArgumentException("Id must be greater than 0");
			}
			var docotor = _doctorsRepository.GetDoctorById(id);
			if (docotor == null)
			{
				Console.WriteLine("Doctor not found");
			}
			else
			{
				_doctorsRepository.Delete(docotor);
			}
			
		}	



		public void UpdateDotor(int id, UpdateDoctorDTO doctor)
		{
			if (id <= 0)
			{
				throw new ArgumentException("Id must be greater than 0");
			}


			Doctor newDoctor = new Doctor
			{
				Name = doctor.Name,
				Specialization = doctor.Specialization,
				RoomNumber = doctor.RoomNumber
			};
			_doctorsRepository.Update(id, newDoctor);


		}


	}
}
