using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02HogwartsSorting
{
    class Pr02HogwartsSorting
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, string>();
            var faculties = new Dictionary<string, int>();
            faculties.Add("Gryffindor", 0);
            faculties.Add("Slytherin", 0);
            faculties.Add("Ravenclaw", 0);
            faculties.Add("Hufflepuff", 0);
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine().Replace(" ", "");
                int number = 0;
                string letters = "";
                string faculty = "";
                for (int j = 0; j < name.Length; j++)
                {
                    number += name[j];
                    if (char.IsUpper(name[j]))
                    {
                        letters += name[j];
                    }
                }
                string facultyNumber = number + letters;
                int reminder = number % 4;
                if (reminder == 0)
                {
                    faculty = "Gryffindor";
                }
                else if (reminder == 1)
                {
                    faculty = "Slytherin";
                }
                else if (reminder == 2)
                {
                    faculty = "Ravenclaw";
                }
                else if (reminder == 3)
                {
                    faculty = "Hufflepuff";
                }
                faculties[faculty]++;
                students.Add(facultyNumber, faculty);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Value} {student.Key}");
            }
            foreach (var faculty in faculties)
            {
                Console.WriteLine($"{faculty.Key}: {faculty.Value}");
            }
        }
    }
}
