using System;
using System.Collections.Generic;

namespace Exercise10
{
    static class Inventory
    {

        static private List<Product> products;

        static Inventory()
        {
            products = new List<Product>();
        }
        static public void AddProduct(Product p)
        {
            products.Add(p);
        }
        static public void DisplayInventory()
        {
            double totalInventory = 0;
            Console.WriteLine("Current inventory: ");
            Console.WriteLine("****************************\n");

            foreach (Product p in products)
            {
                p.DisplayInfo();
                Console.WriteLine();
                totalInventory += p.TotalValue();
            }
            Console.WriteLine($"Total inventory value: ${totalInventory.ToString("F")}");
        }
    }
}
