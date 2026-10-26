using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Entities
{
	internal class Genre
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
