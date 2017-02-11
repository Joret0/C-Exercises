using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Pr08MentorGroup
{
    class Pr08MentorGroup
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = "";
            while ((line = Console.ReadLine()) != "end of dates")
            {
                string[] info = line.Split(new char[] { ' ', ',' }).ToArray();
                string name = info[0];
                List<DateTime> dates = info
                    .Skip(1)
                    .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToList();

                if (students.Any(x => x.Name == name))
                {
                    var existingStudent = students.Where(x => x.Name == name).First();
                    existingStudent.DatesActivities.AddRange(dates);
                }
                else
                {
                    var student = new Student(name, new List<string>(), dates);
                    students.Add(student);
                }
            }

            while ((line = Console.ReadLine()) != "end of comments")
            {
                var studentComment = line.Split('-');
                var studentName = studentComment[0];
                var comment = studentComment[1];

                if (students.Any(x => x.Name == studentName))
                {
                    var existingStudent = students.Where(x => x.Name == studentName).First();
                    existingStudent.Comments.Add(comment);
                }
            }
            students = students.OrderBy(x => x.Name).ToList();

            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in item.Comments)
                {
                    Console.WriteLine($" - {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in item.DatesActivities.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }

    public class Student
    {
        public Student(string name, List<string> comments, List<DateTime> datesActivities)
        {
            this.Name = name;
            this.Comments = comments;
            this.DatesActivities = datesActivities;
        }
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> DatesActivities { get; set; }
    }
}
