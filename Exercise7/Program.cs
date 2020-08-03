using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerNumber = 2;
            int int1;
            int int2;
            int int3;
            

            for (int i = 1; i <= integerNumber; i++)
            {
                Console.Write("Enter an integer: ");
                int1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a second integer: ");
                int2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a third integer: ");
                int3 = Convert.ToInt32(Console.ReadLine());

                IntSum(int1, int2, int3);
            }

            Console.ReadKey();
                
        }
        static void IntSum(int int1, int int2, int int3)
        {        
           int sum = int1 + int2 + int3;
            Console.WriteLine("The some of the three integers is " + sum);
            Console.WriteLine();

        }

    }
}
