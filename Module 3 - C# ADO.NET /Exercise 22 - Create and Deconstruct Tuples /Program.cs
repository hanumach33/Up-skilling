using System;

namespace Exercise22
{
    internal class Program
    {
        static (int Id, string Name) GetEmployee()
        {
            return (101, "Alice Johnson");
        }

        static void Main(string[] args)
        {
            (int id, string name) = GetEmployee();

            Console.WriteLine("Tuple Values");

            Console.WriteLine($"Employee Id   : {id}");
            Console.WriteLine($"Employee Name : {name}");
        }
    }
}
