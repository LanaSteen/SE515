using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Entities
{
	internal class BookDetails
	{
		public int Id { get; set; }
		public string ISBN { get; set; }
		public int PageCount { get; set; }
		public int PublishedYear { get; set; }
		public int BookId { get; set; } // fk
		public Book Book { get; set; } // navigation property



	}
}
