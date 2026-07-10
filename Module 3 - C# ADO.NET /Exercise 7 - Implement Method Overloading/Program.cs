using System;

namespace Exercise7
{
    internal class Program
    {
        static int CalculateTotal(int num1, int num2)
        {
            return num1 + num2;
        }

        static double CalculateTotal(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        static void Main(string[] args)
        {
            int total1 = CalculateTotal(25, 35);

            double total2 = CalculateTotal(10.5, 20.25, 30.75);

            Console.WriteLine("Method Overloading Example");
            Console.WriteLine();

            Console.WriteLine($"Total of Two Integers : {total1}");

            Console.WriteLine($"Total of Three Doubles : {total2}");
        }
    }
}
