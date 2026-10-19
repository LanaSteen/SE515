using HotelApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp.Data
{
	internal class HotelDbContex : DbContext
	{
		public DbSet<Hotel> Hotels { get; set; }
		public DbSet<Room> Rooms { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer("Server=LAPTOP-HE9JLDVE;Database=HotelAppDb; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;");
		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//}
	}
}
