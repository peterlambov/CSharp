// 09. Write an expression that checks for given point (x, y) if it is
// within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;
    class PointWithinOut
    {
        static void Main()
        {
            Console.WriteLine("Enter the coordinates of a point");
            int x = int.Parse(Console.ReadLine());//Coordinates of a point you want
            int y = int.Parse(Console.ReadLine());
            int rad=3;
            if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= rad * rad))//circle K( (1,1),3)
            {
                Console.WriteLine("The point is within the circle");
            }
            else
            {
                Console.WriteLine("The point is NOT within the circle");
            }
            if ((x >= 1 && x <= 7) && (y <= -1 && y >= -3))//The rectangle has witdh=6 and height=2, the left top has coordinates(1;-1)
            {
                Console.WriteLine("The point is in the rectangle");
            }
            else
            {
                Console.WriteLine("The point is out of the rectangle");
            }
        }
    }

