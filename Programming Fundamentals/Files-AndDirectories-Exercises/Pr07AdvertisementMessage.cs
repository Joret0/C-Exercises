using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr07AdvertisementMessage
{
    class Pr07AdvertisementMessage
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(File.ReadAllText("input.txt"));

            string[] phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] towns = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random number = new Random();

            string[] output = new string[n];

            for (int i = 0; i < n; i++)
            {
                int phraseIndex = number.Next(0, phrases.Length);
                int eventIndex = number.Next(0, events.Length);
                int authorIndex = number.Next(0, authors.Length);
                int townsIndex = number.Next(0, towns.Length);

                output[i] = $"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {towns[townsIndex]}";
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
