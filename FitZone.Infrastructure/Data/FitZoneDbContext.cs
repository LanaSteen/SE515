using FitZone.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Infrastructure.Data
{
	public class FitZoneDbContext : DbContext
	{

		public DbSet<Member> Members { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(@"Server=LAPTOP-HE9JLDVE;Database=HospitalAppDb; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
