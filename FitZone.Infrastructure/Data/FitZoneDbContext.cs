using FitZone.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Infrastructure.Data
{
	public class FitZoneDbContext : DbContext
	{
		public FitZoneDbContext(DbContextOptions<FitZoneDbContext> 
			options) : base(options)
		{
		}


		public FitZoneDbContext() { }


		public DbSet<Member> Members { get; set; }
		public DbSet<Trainer> Trainers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			if(!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Server=LAPTOP-HE9JLDVE;Database=FitZoneAppDb; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.Entity<Member>(x =>
			//{
			

			//	x.Property(m => m.MembershipType)
			//	.HasConversion<string>();
			//	x.HasCheckConstraint( "CK_Member_TrainerId", "TrainerId > 0" );
			//});
				
		}
	}
}
