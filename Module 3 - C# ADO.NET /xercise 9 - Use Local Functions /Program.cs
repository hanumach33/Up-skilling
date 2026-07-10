using System;

namespace Exercise9
{
    internal class Program
    {
        static int CalculateFactorial(int number)
        {
            int Factorial(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }

                return n * Factorial(n - 1);
            }

            return Factorial(number);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int result = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} = {result}");
        }
    }
}
