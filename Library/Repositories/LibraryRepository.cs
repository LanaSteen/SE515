using Library.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Repositories
{
	internal class LibraryRepository
	{
		private readonly LibraryDbContext _context;
		public LibraryRepository(LibraryDbContext context)
		{
			_context = context;
		}


		public void AddLibrary(Models.Entities.Library library)
		{
		
			_context.Libraries.Add(library);
			_context.SaveChanges();
		}


	}
}
