using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.Write("Enter an integer (or 1 to exit): ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number != 1)
                {
                    if (IsPrimeNum(number))
                        Console.WriteLine(number + " is a prime number!");

                    else
                        Console.WriteLine(number + " is not a prime number!");
                }

            } while (number != 1);
        }
        static bool IsPrimeNum(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
