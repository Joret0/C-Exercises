using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Pr10StudentGroups
{
    class Pr10StudentGroups
    {
        static void Main(string[] args)
        {
            var towns = ReadTownsAndStudents();
            List<Group> groups = DistributeStudentsIntoGroup(towns);
            PrintGroups(groups, towns);
        }

        public static void PrintGroups(List<Group> groups, List<Town> towns)
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Distinct().Count()} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                List<string> emails = group.Students.Select(x => x.Email).ToList();
                Console.Write($"{group.Town.Name} => ");
                Console.WriteLine(string.Join(", ", emails));
            }
        }

        public static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();

            string inputLine = "";

            while ((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    Town town = new Town();
                    string[] townInfo = inputLine
                        .Split(new char[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string townName = string.Empty;

                    if (townInfo.Length > 3)
                    {
                        townName = townInfo[0] + " " + townInfo[1];
                    }
                    else
                    {
                        townName = townInfo[0];
                    }

                    int seatsCount = int.Parse(townInfo[townInfo.Length - 2]);

                    town.Name = townName;
                    town.SeatsCount = seatsCount;
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    Student student = new Student();
                    string[] studentInfo = inputLine.Split('|').ToArray();
                    string studentName = studentInfo[0];
                    string studentEmail = studentInfo[1].Trim();
                    DateTime regDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    student.Name = studentName;
                    student.Email = studentEmail;
                    student.RegistrationDate = regDate;
                    towns.Last().Students.Add(student);
                }
            }
            return towns;
        }

        public static List<Group> DistributeStudentsIntoGroup(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            towns = towns.OrderBy(x => x.Name).ToList();

            foreach (var town in towns)
            {
                List<Student> studentsInTown = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (studentsInTown.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = studentsInTown.Take(group.Town.SeatsCount).ToList();
                    studentsInTown = studentsInTown.Skip(group.Town.SeatsCount).ToList();
                    groups.Add(group);
                }
            }

            return groups;
        }
    }

    public class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    public class Town
    {
        public string Name { get; set; }

        public int SeatsCount { get; set; }

        public List<Student> Students { get; set; }
    }
}
