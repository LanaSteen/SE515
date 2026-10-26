using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Models.Entities
{
	internal class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public decimal Price { get; set; }
		public int LibraryId { get; set; } // fk
		public Library Library { get; set; } // navigation property
		public BookDetails BookDetails { get; set; } // navigation property
		public ICollection<Genre> Genres { get; set; }

	}
}



//1 wigni 1 informacia