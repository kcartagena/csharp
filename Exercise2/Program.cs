using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string guacSale;
            bool isGuacOnSale;
            double money;

            Console.Write("Is the guacamole on sale? (yes/no): ");
            guacSale = Console.ReadLine();

            Console.Write("How much money is in your pocket? $ ");
            money = Convert.ToDouble(Console.ReadLine());

            if (guacSale == "yes")
            {
                isGuacOnSale = true;
            }
            else
            {
                isGuacOnSale = false;
            }

            if ((isGuacOnSale && money >= 10) || money >= 100)
            {
                Console.Write("Let's go shopping!");

            }
            else
            {
                Console.Write("Stay home...");
            }

            Console.ReadKey();
        }
    }
}
