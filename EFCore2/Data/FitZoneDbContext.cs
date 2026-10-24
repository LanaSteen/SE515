using EFCore2.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EFCore2.Data
{
	internal class FitZoneDbContext : DbContext
	{

		DbSet<User> Users { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer(@"Server=LAPTOP-HE9JLDVE;Database=HotelAppDb; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;");
		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//}
	}
}
