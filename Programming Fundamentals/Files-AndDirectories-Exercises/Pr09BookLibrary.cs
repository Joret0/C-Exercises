using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Pr09BookLibrary
{
    class Pr09BookLibrary
    {
        static void Main(string[] args)
        {
            string[] array = File.ReadAllLines("input.txt");

            int n = int.Parse(array[0]);

            Library booksByAuthor = new Library();

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                books.Add(ReadBook(array[i + 1]));
            }

            booksByAuthor.Books = books;

            Dictionary<string, double> pricePerAuthor = AddValuesToDictionary(booksByAuthor);

            PrintResults(pricePerAuthor);
        }

        static void PrintResults(Dictionary<string, double> pricePerAuthor)
        {
            List<string> output = new List<string>();

            foreach (var author in pricePerAuthor.OrderByDescending(a => a.Value).ThenBy(b => b.Key))
            {
                output.Add($"{author.Key} -> {author.Value:f2}");
            }

            File.WriteAllLines("output.txt", output);
        }

        public static Dictionary<string, double> AddValuesToDictionary(Library booksByAuthor)
        {
            Dictionary<string, double> pricePerAuthor = new Dictionary<string, double>();

            for (int i = 0; i < booksByAuthor.Books.Count; i++)
            {
                if (!pricePerAuthor.ContainsKey(booksByAuthor.Books[i].Author))
                {
                    pricePerAuthor.Add(booksByAuthor.Books[i].Author, 0);
                }

                pricePerAuthor[booksByAuthor.Books[i].Author] += booksByAuthor.Books[i].Price;
            }

            return pricePerAuthor;
        }

        private static Book ReadBook(string input)
        {
            Book book = new Book();
            string[] booksData = input.Split(' ').ToArray();

            book.Title = booksData[0];
            book.Author = booksData[1];
            book.Publisher = booksData[2];
            book.ReleaseDate = DateTime.ParseExact(booksData[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            book.IsbnNumber = booksData[4];
            book.Price = double.Parse(booksData[5]);

            return book;
        }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public string IsbnNumber { get; set; }
        public double Price { get; set; }
    }
}