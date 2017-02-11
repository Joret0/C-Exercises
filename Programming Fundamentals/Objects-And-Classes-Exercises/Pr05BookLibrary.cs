using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Pr05BookLibrary
{
    class Pr05BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Library booksByAuthor = new Library();

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                books.Add(ReadBook());
            }

            booksByAuthor.Books = books;

            Dictionary<string, double> pricePerAuthor = AddValuesToDictionary(booksByAuthor);

            PrintResults(pricePerAuthor);
        }

        static void PrintResults(Dictionary<string, double> pricePerAuthor)
        {
            foreach (var author in pricePerAuthor.OrderByDescending(a => a.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", author.Key, author.Value);
            }
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

        private static Book ReadBook()
        {
            Book book = new Book();
            string[] booksData = Console.ReadLine().Split(' ').ToArray();

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
