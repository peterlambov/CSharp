// Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;
    class Circle
    {
        static void Main()
        {
            Console.Write("Enter a radius:");
            uint r = uint.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("The area of the circle is: {0}",area);
            Console.WriteLine("The perimeter of the circle is : {0}",perimeter);
        }
    }

