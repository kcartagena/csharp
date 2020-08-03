using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        enum Direction
        {
            north,
            south,
            east,
            west
        }

        static void Main(string[] args)
        {
            List<Direction> directions = new List<Direction>();
            char input;

          do
            {
                Console.Write("Enter the next direction (n/s/e/w or 0 to finish): ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (input)
                {
                    case 'n':
                        directions.Add(Direction.north);
                        break;
                    case 'e':
                        directions.Add(Direction.east);
                        break;
                    case 's':
                        directions.Add(Direction.south);
                        break;
                    case 'w':
                        directions.Add(Direction.west);
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            } while (input != '0');

            Console.WriteLine($"\nYou entered {directions.Count} directions. The directions are as follows: ");

            foreach (Direction direction in directions )
            {
                Console.Write($"{ConvertToSymbol(direction)}");
            }
            Console.ReadKey();
        
        }
        static string ConvertToSymbol(Direction direction)
        {
            switch (direction)
            {
                case Direction.north:
                        return "^";
                case Direction.east:
                        return ">";
                case Direction.south:
                        return "v";
                case Direction.west:
                        return "<";
                default:
                    return "";
            }
        }
    }
}
