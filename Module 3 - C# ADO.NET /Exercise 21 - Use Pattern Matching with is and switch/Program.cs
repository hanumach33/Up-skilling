using System;

namespace Exercise21
{
    class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        static void CheckType(object obj)
        {
            Console.WriteLine("Using 'is' Pattern Matching");

            if (obj is int number)
            {
                Console.WriteLine($"Integer Value : {number}");
            }
            else if (obj is double amount)
            {
                Console.WriteLine($"Double Value : {amount}");
            }
            else if (obj is string text)
            {
                Console.WriteLine($"String Value : {text}");
            }
            else if (obj is Employee employee)
            {
                Console.WriteLine($"Employee Name : {employee.Name}");
            }
            else
            {
                Console.WriteLine("Unknown Type");
            }

            Console.WriteLine();

            Console.WriteLine("Using switch Pattern Matching");

            switch (obj)
            {
                case int number:
                    Console.WriteLine($"Integer Value : {number}");
                    break;

                case double amount:
                    Console.WriteLine($"Double Value : {amount}");
                    break;

                case string text:
                    Console.WriteLine($"String Value : {text}");
                    break;

                case Employee employee:
                    Console.WriteLine($"Employee Name : {employee.Name}");
                    break;

                default:
                    Console.WriteLine("Unknown Type");
                    break;
            }

            Console.WriteLine("-----------------------------");
        }

        static void Main(string[] args)
        {
            CheckType(100);

            CheckType(99.99);

            CheckType("Hello C#");

            CheckType(new Employee("Alice Johnson"));
        }
    }
}
