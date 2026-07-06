using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture16.Models
{
	internal class Book
	{
		public Book(string title, string author)
		{
			Title = title;
			Author = author;
		}

		public string Title { get; set; }
		public string Author { get; set; }

		public override bool Equals(object? obj)
		{
			if (obj is Book book)
			{
				return Title == book.Title && Author == book.Author;
			}
			return base.Equals(obj);
		}

		public override int GetHashCode() /// 12365468
		{
			return HashCode.Combine(Title, Author);
		}

		public override string? ToString()
		{
			return $"{Title} by {Author}";
		}
	}
}
