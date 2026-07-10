using System;

namespace Exercise12
{
    class Product
    {
        private double _price;

        public string Name { get; set; }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price cannot be negative. Setting price to 0.");
                    _price = 0;
                }
            }
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product Name : {Name}");
            Console.WriteLine($"Product Price: {Price}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Name = "Laptop",
                Price = 65000
            };

            Product product2 = new Product
            {
                Name = "Mobile",
                Price = -25000
            };

            Console.WriteLine("Product 1");
            product1.DisplayProduct();

            Console.WriteLine();

            Console.WriteLine("Product 2");
            product2.DisplayProduct();
        }
    }
}
