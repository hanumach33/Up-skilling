using System;

namespace Exercise3
{
    public class Person(string firstName, string lastName, int age)
    {
        public string FirstName { get; } = firstName;

        public string LastName { get; } = lastName;

        public int Age { get; } = age;

        public void DisplayInformation()
        {
            Console.WriteLine($"First Name : {FirstName}");
            Console.WriteLine($"Last Name  : {LastName}");
            Console.WriteLine($"Age        : {Age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(
                "Alice",
                "Johnson",
                25
            );

            person.DisplayInformation();
        }
    }
}
