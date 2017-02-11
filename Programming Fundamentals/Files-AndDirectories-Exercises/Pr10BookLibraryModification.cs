using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Pr10BookLibraryModification
{
    class Pr10BookLibraryModification
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

            Dictionary<string, DateTime> booksAfterDate = AddBooksAfterDate(booksByAuthor);
            PrintResults(booksAfterDate);
        }

        public static void PrintResults(Dictionary<string, DateTime> booksAfterDate)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            File.WriteAllText("output.txt", string.Empty);

            foreach (var item in booksAfterDate.Where(d => d.Value > date).OrderBy(a => a.Value).ThenBy(b => b.Key))
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}{Environment.NewLine}");
            }
        }

        public static Dictionary<string, DateTime> AddBooksAfterDate(Library booksByAuthor)
        {
            Dictionary<string, DateTime> booksAfterDate = new Dictionary<string, DateTime>();

            foreach (var item in booksByAuthor.Books)
            {
                if (!booksAfterDate.ContainsKey(item.Title))
                {
                    booksAfterDate.Add(item.Title, new DateTime());
                }

                booksAfterDate[item.Title] = item.ReleaseDate;
            }

            return booksAfterDate;
        }

        public static void PrintResult(Dictionary<string, double> pricePerAuthor)
        {
            foreach (var item in pricePerAuthor.OrderByDescending(a => a.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);
            }
        }

        public static Dictionary<string, double> AddValuesToDictionary(Library booksByAuthor)
        {
            Dictionary<string, double> pricePerAuthor = new Dictionary<string, double>();

            foreach (var item in booksByAuthor.Books)
            {
                if (!pricePerAuthor.ContainsKey(item.Author))
                {
                    pricePerAuthor.Add(item.Author, 0);
                }

                pricePerAuthor[item.Author] += item.Price;
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