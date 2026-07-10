using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Score (0-100): ");
            int score = Convert.ToInt32(Console.ReadLine());

            string grade;

            if (score >= 90 && score <= 100)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else if (score >= 0)
            {
                grade = "F";
            }
            else
            {
                grade = "Invalid Score";
            }

            Console.WriteLine();
            Console.WriteLine("Grade using if-else : " + grade);

            string switchGrade = score switch
            {
                >= 90 and <= 100 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                >= 0 => "F",
                _ => "Invalid Score"
            };

            Console.WriteLine("Grade using switch  : " + switchGrade);
        }
    }
}
