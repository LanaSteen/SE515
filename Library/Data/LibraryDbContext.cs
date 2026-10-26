using Library.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
	internal class LibraryDbContext : DbContext
	{


		public DbSet<Book> Books { get; set; }
		public DbSet<BookDetails> BookDetails { get; set; }
		public DbSet<Library.Models.Entities.Library> Libraries { get; set; }
		public DbSet<Genre> Genres { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(@"Server=LAPTOP-HE9JLDVE;Database=LibraryAppDb; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;");
		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//}
	}
}
