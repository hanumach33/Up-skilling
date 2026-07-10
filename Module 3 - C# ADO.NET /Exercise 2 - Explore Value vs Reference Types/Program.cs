using System;

namespace Exercise2
{
    class Student
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void ModifyValue(int number)
        {
            number = 100;
        }

        static void ModifyReference(Student student)
        {
            student.Name = "Bob";
        }

        static void Main(string[] args)
        {
            int number = 50;
            double percentage = 85.5;

            Student student = new Student
            {
                Name = "Alice"
            };

            Console.WriteLine("Before Method Calls");
            Console.WriteLine($"Integer Value : {number}");
            Console.WriteLine($"Double Value  : {percentage}");
            Console.WriteLine($"Student Name  : {student.Name}");

            ModifyValue(number);
            ModifyReference(student);

            Console.WriteLine();

            Console.WriteLine("After Method Calls");
            Console.WriteLine($"Integer Value : {number}");
            Console.WriteLine($"Double Value  : {percentage}");
            Console.WriteLine($"Student Name  : {student.Name}");
        }
    }
}
