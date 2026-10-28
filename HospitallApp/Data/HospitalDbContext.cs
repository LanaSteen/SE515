using HospitallApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitallApp.Data
{
	internal class HospitalDbContext : DbContext
	{



		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Registry> Registries { get; set; }
		public DbSet<Diagnose> Diagnoses { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=LAPTOP-HE9JLDVE;Database=HospitalAppDb; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Patient>()
				.HasMany(p => p.Doctors)
				.WithMany(d => d.Patients)
				.UsingEntity(j => j.ToTable("PatientDoctors"));
			modelBuilder.Entity<Doctor>(x=>
				{
					x.HasData(
					new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", RoomNumber = 101 },
					new Doctor { Id = 2, Name = "Dr. Emily Johnson", Specialization = "Neurology", RoomNumber = 202 }
				);
			});


			modelBuilder.Entity<Registry>(x =>
			{
				x.HasOne(r => r.Patient)
				.WithOne(p => p.Registry)
				.HasForeignKey<Registry>(r => r.PatientId);

				x.HasCheckConstraint<Registry>("CK_PatientId", "PatientId IS NOT NULL");


				//ეს ერორდებოდა რადგან პაციენტი არ არის შექმნილი და მისი აიდი ვერ იარსებებს
				//x.HasData(
				//	new Registry { Id = 1, OpenDate = new DateTime(2024, 1, 1), PatientId = 1 },
				//	new Registry { Id = 2, OpenDate = new DateTime(2024, 2, 1), PatientId = 2 }
				//	);


			});
		}
	}
}
