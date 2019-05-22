using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Library library = new Library(5);
			library.books[0] = new Book("Atrhur Conan Doyl", "Sherlock Holms", 723, 1894, 307, "Detective");
			library.books[1] = new Book("S. Wozniak", "Steve Jobs and Me", 9653, 2006, 1046, "Autobiography");
			library.books[2] = new Book("A. Ekzupery", "The Little Prince", 4234, 1943, 216, "Novel");
			library.books[3] = new Book("F. Delavye", "Anatomy of exercises", 563, 1987, 85, "book");
			library.books[4] = new Book("Jane Austen", "Pride and Prejudice", 1234, 1930, 416, "Novel");

			library.CompareTwoBooks();
			library.SearchByCode();

			Console.ReadLine();
		}
	}
}
