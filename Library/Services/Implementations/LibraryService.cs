using Library.Models.Entities;
using Library.Models.DTOs;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Services.Implementations
{
	internal class LibraryService
	{
		private readonly LibraryRepository _libraryRepository;

		public LibraryService(LibraryRepository libraryRepository)
		{
			_libraryRepository = libraryRepository;
		}


		public void AddLibrary(CreateLibraryDTO createLibrary)
		{
			if(createLibrary == null)
			{
				throw new ArgumentNullException(nameof(createLibrary));
			}


			Library.Models.Entities.Library library 
				= new Library.Models.Entities.Library
			{
				Name = createLibrary.Name,
				Address = createLibrary.Address
			};

			_libraryRepository.AddLibrary(library);
		}
	}
}
