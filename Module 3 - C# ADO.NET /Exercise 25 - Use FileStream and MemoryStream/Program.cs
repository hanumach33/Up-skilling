using System;
using System.IO;
using System.Text;

namespace Exercise25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("sample.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string content = reader.ReadToEnd();

                    Console.WriteLine("Contents of sample.txt");
                    Console.WriteLine();

                    Console.WriteLine(content);
                }
            }

            Console.WriteLine();

            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] data = Encoding.UTF8.GetBytes("Welcome to C# ADO.NET");

                memoryStream.Write(data, 0, data.Length);

                Console.WriteLine("MemoryStream Information");
                Console.WriteLine($"Bytes Written : {memoryStream.Length}");
            }
        }
    }
}
