using System;

namespace Exercise8
{
    internal class Program
    {
        static void Increment(ref int number)
        {
            number += 10;
        }

        static void GetStudent(out string name)
        {
            name = "Alice Johnson";
        }

        static void DisplayValue(in int value)
        {
            Console.WriteLine($"Value received using in parameter : {value}");
        }

        static void Main(string[] args)
        {
            int number = 20;

            Console.WriteLine("ref Parameter");
            Console.WriteLine($"Before Method Call : {number}");

            Increment(ref number);

            Console.WriteLine($"After Method Call  : {number}");

            Console.WriteLine();

            Console.WriteLine("out Parameter");

            string studentName;

            GetStudent(out studentName);

            Console.WriteLine($"Student Name : {studentName}");

            Console.WriteLine();

            Console.WriteLine("in Parameter");

            int marks = 95;

            Console.WriteLine($"Before Method Call : {marks}");

            DisplayValue(in marks);

            Console.WriteLine($"After Method Call  : {marks}");
        }
    }
}
