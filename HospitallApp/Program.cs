using HospitallApp.Data;
using HospitallApp.Repositories;
using HospitallApp.Services.Implementations;

namespace HospitallApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HospitalDbContext conttext = new HospitalDbContext();
			DoctorsRepository doctorsRepository = new DoctorsRepository(conttext);
			DoctorService doctorService = new DoctorService(doctorsRepository);

			Menu menu = new Menu(doctorService);

			menu.ShowMenu();
		}
	}
}
