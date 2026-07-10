#nullable enable

using System;

namespace Exercise16
{
    class Person
    {
        public string? Name { get; set; }

        public string? Email { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                Name = "Alice Johnson",
                Email = "alice@example.com"
            };

            Person? person2 = null;

            Console.WriteLine("Person 1");

            Console.WriteLine($"Name  : {person1.Name?.ToUpper() ?? "Not Available"}");
            Console.WriteLine($"Email : {person1.Email ?? "Not Available"}");

            Console.WriteLine();

            Console.WriteLine("Person 2");

            Console.WriteLine($"Name  : {person2?.Name ?? "Not Available"}");
            Console.WriteLine($"Email : {person2?.Email ?? "Not Available"}");

            Console.WriteLine();

            Person person3 = new Person();

            Console.WriteLine("Person 3");

            Console.WriteLine($"Name  : {person3.Name ?? "Not Available"}");
            Console.WriteLine($"Email : {person3.Email ?? "Not Available"}");
        }
    }
}
