using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
	public class Book
	{
		// List of properties.
		public string FullAuthorName { get; set; }
		public string BookName { get; set; }
		public int BookCode { get; set; }
		public int YearOfWriting { get; set; }
		public int AmountOfPages { get; set; }
		public string Genre { get; set; }

		// Default constructor.
		public Book() { }
		// Custom constructor.
		public Book(string authorName, string bookName, int code, int yearOfWriting, int amountOfpages, string genre)
		{
			FullAuthorName = authorName;
			BookName = bookName;
			BookCode = code;
			YearOfWriting = yearOfWriting;
			AmountOfPages = amountOfpages;
			Genre = genre;
		}

		// ToString override.
		public override string ToString()
		{
			return string.Format($"Author: {FullAuthorName};\nTitle: {BookName};\nCode: {BookCode};\nWriting year: {YearOfWriting};\n"
				+ $"Amount of pages: {AmountOfPages};\nGenre: {Genre}");
		}

	}
}
