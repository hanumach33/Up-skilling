using System;

namespace Exercise10
{
    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public Car()
        {
            Make = "Toyota";
            Model = "Corolla";
            Year = 2022;
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make  : {Make}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Year  : {Year}");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Car car2 = new Car(
                "Honda",
                "City",
                2024
            );

            Console.WriteLine("Car Created Using Default Constructor");
            car1.DisplayDetails();

            Console.WriteLine("Car Created Using Parameterized Constructor");
            car2.DisplayDetails();
        }
    }
}
