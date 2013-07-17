// 08. Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;
    class Trapezoid
    {
        static void Main()
        {
            double a = 10;//Using type double prevents from losing part of the area when dividing to 2
            double b = 11.4;
            double h = 3;
            double area = ((a + b) * h) / 2;
            Console.WriteLine(area);
        }
    }

