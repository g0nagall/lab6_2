using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
	class Library : Book
	{
		public Book[] books;

		public Library(int amountOfBooks = 2)
		{
			books = new Book[amountOfBooks];
		}

		// Method for getting information about two books from the library.
		public void CompareTwoBooks()
		{
			Console.WriteLine("******COMPARING BOOKS******");

			uint firstBookNumber = new uint();
			do
			{
				Console.WriteLine("Enter number of first book: ");
				while (uint.TryParse(Console.ReadLine(), out firstBookNumber) == false)
				{
					Console.WriteLine("Wrong value! Try again: ");
				}
			} while (firstBookNumber >= books.Count());

			uint secondBookNumber = new uint();
			do
			{
				Console.WriteLine("Enter number of second book: ");
				while (uint.TryParse(Console.ReadLine(), out secondBookNumber) == false)
				{
					Console.WriteLine("Wrong value! Try again: ");
				}
			} while (secondBookNumber >= books.Count() || secondBookNumber == firstBookNumber);

			Console.WriteLine("Enter number for comparing books:\n1 - Name of author\n2 - Title of the book\n3 - Code\n4 - Year of writing" +
				"\n5 - Amount of pages\n6 - Genre");

			int choice = new int();
			while (int.TryParse(Console.ReadLine(), out choice) == false)
			{
				Console.WriteLine("Wrong value! Try again: ");
			}

			switch (choice)
			{
				case 1:
					Console.WriteLine($"Author of the first book: {books[firstBookNumber].FullAuthorName}\nAuthor of the second book: {books[secondBookNumber].FullAuthorName}");
					break;
				case 2:
					Console.WriteLine($"First book name: {books[firstBookNumber].BookName}\nSecond book name: {books[secondBookNumber].BookName}");
					break;
				case 3:
					Console.WriteLine($"Code of the first book: {books[firstBookNumber].BookCode}\nCode of the second book: {books[secondBookNumber].BookCode}");
					break;
				case 4:
					Console.WriteLine($"First book was written in the {books[firstBookNumber].YearOfWriting} year;\nSecond book was written in the {books[secondBookNumber].YearOfWriting} year");
					break;
				case 5:
					Console.WriteLine($"First book has {books[firstBookNumber].AmountOfPages} pages;\n Second book has {books[secondBookNumber].AmountOfPages} pages");
					break;
				case 6:
					Console.WriteLine($"Genre of the first book is {books[firstBookNumber].Genre};\n Genre of the second book is {books}");
					break;
				default:
					Console.WriteLine("IT WAS YOUR FAULT!");
					break;

			}

		}

		// как сделать поиск через dictionary?
		public void SearchByCode()
		{
			bool someImportantValue = true;
			Console.WriteLine("Enter searched code: ");
			int searchedCode = new int();
			while (int.TryParse(Console.ReadLine(), out searchedCode) == false)
			{
				Console.Write("Wrong value. Try again: ");
			}

			foreach (var book in books)
			{
				if (book.BookCode == searchedCode)
				{
					Console.WriteLine(book.ToString());
					someImportantValue = false;
				}
			}
			if (someImportantValue)
			{
				Console.WriteLine("There is no such books!");
			}
		}
	}
}