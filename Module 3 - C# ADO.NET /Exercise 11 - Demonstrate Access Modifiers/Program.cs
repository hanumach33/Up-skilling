using System;

namespace Exercise11
{
    class Person
    {
        public string Name = "Alice";

        private int Age = 25;

        protected string City = "New York";

        public void DisplayAge()
        {
            Console.WriteLine($"Age : {Age}");
        }
    }

    class Employee : Person
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Accessing Members from Derived Class");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"City : {City}");
        }
    }

    class Student
    {
        public void Display(Person person)
        {
            Console.WriteLine("Accessing Members from Non-Derived Class");
            Console.WriteLine($"Name : {person.Name}");

            person.DisplayAge();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.DisplayDetails();

            Console.WriteLine();

            Student student = new Student();

            student.Display(new Person());
        }
    }
}
