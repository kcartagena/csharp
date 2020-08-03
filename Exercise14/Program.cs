using System;

namespace Exercise14
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Point MyPoint = new Point();
            Point MyPoint2 = new Point();
            double distance;

            Console.Write("Enter the x coordinate for point 1: ");
            MyPoint.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 1: ");
            MyPoint.Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the x coordinate for point 1: ");
            MyPoint2.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 1: ");
            MyPoint2.Y = Convert.ToInt32(Console.ReadLine());

            distance = CalculateDistance(MyPoint, MyPoint2);

            Console.WriteLine();
            Console.WriteLine($"The distance between these two points is {distance}.");


            Console.ReadKey();
        }

        static double CalculateDistance(Point myPoint, Point myPoint2)
        {
            return Math.Sqrt(Math.Pow(myPoint2.X = myPoint.X, 2) + Math.Pow(myPoint2.Y = myPoint.Y, 2));
        }
    }
}
