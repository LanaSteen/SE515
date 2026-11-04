using FitZone.Application.Services.Implementations;
using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using FitZone.Domain.Models.Enums;
using FitZone.Infrastructure.Data;
using FitZone.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FitZone.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//DI Container


			// ServiceCollection-ის შექმნა
			var services = new ServiceCollection();
			// Logging-ის რეგისტრაცია
			services.AddLogging();


	
			services.AddDbContext<FitZoneDbContext>(options =>
			options.UseSqlServer(
				"Server=.;Database=FitZoneDB;Trusted_Connection=True;TrustServerCertificate=True;"
			));


			services.AddScoped<IMemberRepository, MemberRepository>();
			services.AddScoped<IMemberService, MemberService>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();



			services.AddAutoMapper(cfg =>
			{
				cfg.AddMaps(typeof(Program).Assembly);
				cfg.AddMaps(typeof(MemberService).Assembly);
			});


			// ServiceProvider-ის შექმნა
			var serviceProvider = services.BuildServiceProvider();

			var memberService = serviceProvider.GetRequiredService<IMemberService>();

			var newMember = new CreateMemberDTO
			{
				FirstName = "David",
				LastName = "Smith",
				MembershipTypeId = 3,
				TrainerId = 1,
				MembershipType = MembershipType.Premium
			};


			memberService.AddMember(newMember);



			var members = memberService.GetAllMembers();
			foreach (var item in members)
			{
				Console.WriteLine(item);
			}


		}
	}
}
