using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Entities
{
	internal class Library
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public ICollection<Book> Books { get; set; }


	}
}

//IEnumerable =>ICollection=> IList => List, ArrayList, HashSet, 