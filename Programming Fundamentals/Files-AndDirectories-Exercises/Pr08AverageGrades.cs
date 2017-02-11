using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr08AverageGrades
{
    class Pr08AverageGrades
    {
        static void Main(string[] args)
        {
            string[] array = File.ReadAllLines("input.txt").ToArray();

            int n = int.Parse(array[0]);

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                students[i] = ReadStudent(array[i + 1]);
            }

            List<string> output = new List<string>();

            foreach (var student in students.Where(gr => gr.AverageGrade >= 5).OrderBy(st => st.Name).ThenByDescending(st => st.AverageGrade))
            {
                output.Add($"{student.Name} -> {student.AverageGrade:f2}");
            }

            File.WriteAllLines("output.txt", output);
        }

        public static Student ReadStudent(string input)
        {
            string[] inputInfo = input.Split(' ').ToArray();
            Student student = new Student();
            student.Name = inputInfo[0];
            List<double> gradesDoubles = new List<double>();
            for (int i = 1; i < inputInfo.Length; i++)
            {
                double grade = double.Parse(inputInfo[i]);
                gradesDoubles.Add(grade);
            }

            student.Grades = gradesDoubles;
            return student;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();

        public double FindAverageGrade()
        {
            double averageGrade = this.Grades.Average();
            return averageGrade;
        }
    }
}
