// 06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
using System;

    class GivenPoint
    {
        static void Main()
        {
            Console.WriteLine("Type coordinates of a point:");
            double x =double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double rad=5;
            if ((x * x + y * y) <= rad * rad)
            {
                Console.WriteLine("The point is within the circle.");
            }
            else
            {
                Console.WriteLine("The point is NOT within the circle.");
            }

        }
    }

