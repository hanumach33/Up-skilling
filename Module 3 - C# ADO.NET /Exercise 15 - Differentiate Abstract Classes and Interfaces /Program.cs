using System;

namespace Exercise15
{
    abstract class Vehicle
    {
        public abstract void Drive();
    }

    interface IDrivable
    {
        void Start();
    }

    class Car : Vehicle, IDrivable
    {
        public override void Drive()
        {
            Console.WriteLine("Car is being driven.");
        }

        public void Start()
        {
            Console.WriteLine("Car engine started.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();

            IDrivable drivable = new Car();

            Console.WriteLine("Using Abstract Class Reference");
            vehicle.Drive();

            Console.WriteLine();

            Console.WriteLine("Using Interface Reference");
            drivable.Start();

            Console.WriteLine();

            Car car = new Car();

            Console.WriteLine("Using Car Object");
            car.Start();
            car.Drive();
        }
    }
}
