using System;
using System.Globalization;
using Heranca_Polimorfismo.Entities;
using System.Collections.Generic;

namespace Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, Used or Imported (C/U/I)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c' || ch == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            
            foreach(Product pro in list)
            {
                Console.WriteLine(pro.PriceTag());
            }
        }
    }
}
