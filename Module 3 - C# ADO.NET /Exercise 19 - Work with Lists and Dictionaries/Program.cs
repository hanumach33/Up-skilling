using System;
using System.Collections.Generic;

namespace Exercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();

            courses.Add("HTML5");
            courses.Add("CSS3");
            courses.Add("JavaScript");
            courses.Add("Bootstrap");
            courses.Add("C#");

            Console.WriteLine("Courses");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            courses.Remove("Bootstrap");

            Console.WriteLine();

            Console.WriteLine("Courses After Removing Bootstrap");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine();

            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(101, "Alice");
            students.Add(102, "Bob");
            students.Add(103, "Charlie");
            students.Add(104, "David");

            Console.WriteLine("Students");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID : {student.Key}  Name : {student.Value}");
            }

            students.Remove(103);

            Console.WriteLine();

            Console.WriteLine("Students After Removing ID 103");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID : {student.Key}  Name : {student.Value}");
            }
        }
    }
}
