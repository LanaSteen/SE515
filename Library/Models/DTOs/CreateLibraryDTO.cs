using Library.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.DTOs
{
	internal class CreateLibraryDTO
	{
		public string Name { get; set; }
		public string Address { get; set; }
	}
}
