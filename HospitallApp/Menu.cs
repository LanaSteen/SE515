using HospitallApp.Models.DTOs;
using HospitallApp.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

// todo static

namespace HospitallApp
{
	internal class Menu
	{
		private readonly DoctorService _doctorService;

		public Menu(DoctorService doctorService)
		{
			_doctorService = doctorService;

		}

		private void ShowAllDoctors()
		{
			var doctors = _doctorService.GetAllDoctors();
			foreach (var doctor in doctors)
			{
				Console.WriteLine(doctor);
			}
		}


		private void ShowDoctorById()
		{
			Console.WriteLine("Enter doctor's id:");
			int id = int.Parse(Console.ReadLine());
			var doctor = _doctorService.GetDoctorById(id);
			if (doctor != null)
			{
				Console.WriteLine(doctor);
			}
		}

		private void UpdateDoctor()
		{
			Console.WriteLine("Enter doctor's id:");
			int id = int.Parse(Console.ReadLine());
			var doctor = _doctorService.GetDoctorById(id);
			UpdateDoctorDTO updateDoctor = new();
			updateDoctor.Name = doctor.Name;
			updateDoctor.Specialization = doctor.Specialization;
			updateDoctor.RoomNumber = doctor.RoomNumber;

			if (doctor != null)
			{
				Console.WriteLine("Enter doctor's name:");
				updateDoctor.Name = Console.ReadLine();
				Console.WriteLine("Enter doctor's specialization:");
				updateDoctor.Specialization = Console.ReadLine();
				Console.WriteLine("Enter doctor's room number:");
				updateDoctor.RoomNumber = int.Parse(Console.ReadLine());
				_doctorService.UpdateDotor(id, updateDoctor);
			}
		}

		private void DeleteDoctor()
		{
			Console.WriteLine("Enter doctor's id:");
			int id = int.Parse(Console.ReadLine());
			_doctorService.DeleteDoctor(id);
		}
		private  void AddDoctor()
		{

			CreateDoctorDTO doctor = new();

			Console.WriteLine("Enter doctor's name:");
			doctor.Name = Console.ReadLine();

			Console.WriteLine("Enter doctor's specialization:");
			doctor.Specialization = Console.ReadLine();

			Console.WriteLine("Enter doctor's room number:");
			doctor.RoomNumber = int.Parse(Console.ReadLine());	

			_doctorService.AddDoctor(doctor);
		}

		public  void ShowMenu()
		{
			string choice = "";

			while (choice != "0")
			{
				Console.WriteLine("Enter 1 to add doctor");
				Console.WriteLine("Enter 2 to get all doctors");
				Console.WriteLine("Enter 3 to get  doctor by id");
				Console.WriteLine("Enter 4 to update doctor");
				Console.WriteLine("Enter 5 to delete doctor");
				Console.WriteLine("Enter 0 to exit");
				choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						AddDoctor();
						break;
					case "2":
						ShowAllDoctors();
						break;
					case "3":
						ShowDoctorById();
						break;
					case "4":
						UpdateDoctor();
						break;
					case "5":
						DeleteDoctor();
						break;
					default:
						Console.WriteLine("Invalid choice");
						break;
				}

			}

		}
	}
}
