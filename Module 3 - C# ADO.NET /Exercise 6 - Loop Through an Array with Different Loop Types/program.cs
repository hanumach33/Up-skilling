using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60 };

            Console.WriteLine("Using for Loop");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 20)
                    continue;

                if (numbers[i] == 50)
                    break;

                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Using foreach Loop");

            foreach (int number in numbers)
            {
                if (number == 20)
                    continue;

                if (number == 50)
                    break;

                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("Using while Loop");

            int index = 0;

            while (index < numbers.Length)
            {
                if (numbers[index] == 20)
                {
                    index++;
                    continue;
                }

                if (numbers[index] == 50)
                    break;

                Console.WriteLine(numbers[index]);

                index++;
            }

            Console.WriteLine();

            Console.WriteLine("Using do-while Loop");

            index = 0;

            do
            {
                if (numbers[index] == 20)
                {
                    index++;
                    continue;
                }

                if (numbers[index] == 50)
                    break;

                Console.WriteLine(numbers[index]);

                index++;

            } while (index < numbers.Length);
        }
    }
}
