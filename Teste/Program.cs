using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Product ssd = new Product(1,"SSD 550",350,EProductType.Product);
            Console.WriteLine(ssd.Id);
            Console.WriteLine(ssd.Name);
            Console.WriteLine(ssd.Price);
            Console.WriteLine(ssd.Type);
            Console.WriteLine(ssd.PriceInDollar(5.00));

            Product website = new Product(2,"Web site Responsivo",2500,EProductType.Service);
             Console.WriteLine(website.Id);
            Console.WriteLine(website.Name);
            Console.WriteLine(website.Price);
            Console.WriteLine(website.Type);
            Console.WriteLine(website.PriceInDollar(5.00));
        }
    }

    struct Product

    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id, string name, double price, EProductType type){
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDollar(double dollar){
            return Price * dollar;
        }
    }

    enum EProductType{
        Product = 1,
        Service = 2,
    }
}

