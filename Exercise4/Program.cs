using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int attemptNum = 3;
            string guess;
                        
            for (int i=1; i<= attemptNum; i++)
            {
                
                Console.Write("Choose a door between 1-5 and win a prize! This is attempt #" + i + ": ");
                guess = Console.ReadLine();

                switch (guess)
                {
                    case "1":
                        Console.WriteLine("You win a puppy!");
                        break;
                    case "2":
                        Console.WriteLine("You win a new car!");
                        break;
                    case "3":
                        Console.WriteLine("You win a trip to Morocco!");
                        break;
                    case "4":
                        Console.WriteLine("You win a new house!");
                        break;
                    case "5":
                        Console.WriteLine("You win one million dollars!");
                        break;
                    default:
                        Console.WriteLine("That's not a choice, you lose!");
                        break;

                }
                Console.WriteLine();
            }
            

            Console.ReadKey();
            
        }
    }
}
