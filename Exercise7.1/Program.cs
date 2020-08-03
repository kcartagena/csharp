using System;

namespace Exercise7
{
    class Program2
    {
        static void Main(string[] args)
        {

            int int1;
            int int2;
            int int3;
            int sum;

            Console.Write("Enter an integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third integer: ");
            int3 = Convert.ToInt32(Console.ReadLine());

            sum = IntSum(int1, int2, int3);
            Console.WriteLine("The some of the three integers is " + sum);
            Console.WriteLine();

            Console.Write("Enter an integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third integer: ");
            int3 = Convert.ToInt32(Console.ReadLine());

            IntSum(int1, int2, int3, ref sum);
            Console.WriteLine("The some of the three integers is " + sum);
            Console.WriteLine();


            Console.ReadKey();

        }
        static int IntSum(int int1, int int2, int int3)
        {
            return int1 + int2 + int3;

        }
        static void IntSum(int int1, int int2, int int3, ref int sum)
        {
            sum = int1 + int2 + int3;

        }

    }
}
