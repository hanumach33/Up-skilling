using System;
using System.IO;
using System.Text.Json;

namespace Exercise24
{
    class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Name = "Alice Johnson",
                Age = 25,
                Email = "alice@example.com"
            };

            string json = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("user.json", json);

            Console.WriteLine("JSON saved to user.json");
            Console.WriteLine();

            string jsonData = File.ReadAllText("user.json");

            User deserializedUser = JsonSerializer.Deserialize<User>(jsonData);

            Console.WriteLine("Deserialized User");
            Console.WriteLine($"Name  : {deserializedUser.Name}");
            Console.WriteLine($"Age   : {deserializedUser.Age}");
            Console.WriteLine($"Email : {deserializedUser.Email}");
        }
    }
}
