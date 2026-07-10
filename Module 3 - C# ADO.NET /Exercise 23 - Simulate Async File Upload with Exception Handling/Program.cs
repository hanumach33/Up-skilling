using System;
using System.Threading.Tasks;

namespace Exercise23
{
    internal class Program
    {
        static async Task<string> UploadFileAsync()
        {
            await Task.Delay(3000);

            return "File uploaded successfully.";
        }

        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Uploading file...");
                Console.WriteLine();

                string result = await UploadFileAsync();

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
