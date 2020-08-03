using System;

namespace Exercise10
{
   class Product
    {
        private string name;
        private double price;
        private int quantity;

        public void InputInfo()
        {
            Console.Write("Enter product name: ");
            name = Console.ReadLine();

            Console.Write("Enter product price: ");
            price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter product quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nProduct added to inventory.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Value: ${TotalValue().ToString("F")}");
        }

        public double TotalValue()
        {
            return price * quantity;
        }
    }
}
