using Library.Data;
using Library.Models.DTOs;
using Library.Repositories;
using Library.Services.Implementations;
using System.Net;
using System.Xml.Linq;

namespace Library
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");


			
			LibraryDbContext context = new LibraryDbContext();

			LibraryRepository libraryRepository = new LibraryRepository(context);

			LibraryService libraryService = new LibraryService(libraryRepository);



			libraryService.AddLibrary(
				new CreateLibraryDTO() 
			     { Name = "Name", Address = "Address" });

			//AddLibrary



		}
	}
}
