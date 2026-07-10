using System;

namespace Exercise4
{
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 100;
            var salary = 65000.50;
            var message = "Welcome to C#";
            var isActive = true;

            Employee employee = new()
            {
                Name = "Alice Johnson",
                Age = 28
            };

            Console.WriteLine($"Value : {number}");
            Console.WriteLine($"Type  : {number.GetType()}");
            Console.WriteLine();

            Console.WriteLine($"Value : {salary}");
            Console.WriteLine($"Type  : {salary.GetType()}");
            Console.WriteLine();

            Console.WriteLine($"Value : {message}");
            Console.WriteLine($"Type  : {message.GetType()}");
            Console.WriteLine();

            Console.WriteLine($"Value : {isActive}");
            Console.WriteLine($"Type  : {isActive.GetType()}");
            Console.WriteLine();

            Console.WriteLine(employee);
            Console.WriteLine($"Type  : {employee.GetType()}");
        }
    }
}
