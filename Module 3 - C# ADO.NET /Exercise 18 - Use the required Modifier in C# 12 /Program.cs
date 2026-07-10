using System;

namespace Exercise18
{
    class Student
    {
        public required int Id { get; set; }

        public required string Name { get; set; }

        public required string Course { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Id      : {Id}");
            Console.WriteLine($"Name    : {Name}");
            Console.WriteLine($"Course  : {Course}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Id = 101,
                Name = "Alice Johnson",
                Course = "Computer Science"
            };

            student.DisplayDetails();

            /*
            Student student2 = new Student
            {
                Id = 102,
                Name = "Bob Smith"
            };

            Compiler Error:
            Required member 'Student.Course' must be set in the object initializer.
            */
        }
    }
}
