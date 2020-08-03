using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool validResponse;

            do
            {
                Console.Write("Do you like pizza? (yes/no): ");
                answer = Console.ReadLine();

                if (answer == "yes")
                {
                    validResponse = true;
                    Console.Write("You like pizza!");
                }
                else if (answer == "no")
                {
                    validResponse = true;
                    Console.Write("You do not like pizza!");

                }
                else
                {
                    validResponse = false;
                    Console.Write("You did not enter a valid response. Please check your spelling/capitalization and try again.");
                    Console.WriteLine();

                }
            } while (validResponse == false);

             Console.ReadKey();
        }
    }
}
