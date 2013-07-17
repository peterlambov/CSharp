//Write a program that enters the coefficients a, b and c of a quadratic equation
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QuadraticEquation
{

    static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(System.Console.ReadLine()); //Coefficient in front of x^2
        Console.Write("b=");
        double b = double.Parse(System.Console.ReadLine()); //Coeffiecient in front of x
        Console.Write("c=");
        double c = double.Parse(System.Console.ReadLine()); //Free coeffiecient
        double D = (b * b - 4 * a * c);
        Console.WriteLine("The roots of the equation are:");
        if (a == 0)
        {
            Console.WriteLine("The equation is not quadratic.");
        }
        else if (D > 0)
        {
            double firstRoot = ((-b + Math.Sqrt(D)) / (2 * a));
            double secondRoot = ((-b - Math.Sqrt(D)) / (2 * a));
            Console.WriteLine(firstRoot);
            Console.WriteLine(secondRoot);
        }
        else if (D == 0)
        {
            double doubleRoot = ((-b) / (2 * a)); //This is the case when D=0 and firstRoot is equal to secondRoot
            Console.WriteLine(doubleRoot);
        }
        else if (D < 0)
        {
            Console.WriteLine("There aren't real roots for this equation");
        }
        


    }
}


