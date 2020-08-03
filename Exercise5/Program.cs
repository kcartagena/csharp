using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            Greet(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter another name: ");
            Greet(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter a third name: ");
            Greet(Console.ReadLine(), true);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void Greet(string name, bool askQuestion = false)
        {
            Console.Write("Hello, " + name + "!");
            if (askQuestion)
            {
                Console.WriteLine(" How are you?");
            } else
            {
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        
    }
}
