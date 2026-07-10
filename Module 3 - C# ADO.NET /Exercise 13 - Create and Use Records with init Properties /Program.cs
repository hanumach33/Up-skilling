using System;

namespace Exercise13
{
    public record Employee
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string Department { get; init; }

        public double Salary { get; init; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Id = 101,
                Name = "Alice Johnson",
                Department = "Software",
                Salary = 75000
            };

            Employee employee2 = employee1 with
            {
                Name = "Bob Smith",
                Salary = 85000
            };

            Console.WriteLine("Original Employee");
            Console.WriteLine($"Id         : {employee1.Id}");
            Console.WriteLine($"Name       : {employee1.Name}");
            Console.WriteLine($"Department : {employee1.Department}");
            Console.WriteLine($"Salary     : {employee1.Salary}");

            Console.WriteLine();

            Console.WriteLine("Modified Employee");
            Console.WriteLine($"Id         : {employee2.Id}");
            Console.WriteLine($"Name       : {employee2.Name}");
            Console.WriteLine($"Department : {employee2.Department}");
            Console.WriteLine($"Salary     : {employee2.Salary}");
        }
    }
}
