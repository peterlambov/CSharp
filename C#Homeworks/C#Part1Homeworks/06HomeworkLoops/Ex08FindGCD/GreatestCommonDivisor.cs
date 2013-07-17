//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;
    class GreatestCommonDivisor
    {
        static void Main()
        {
            int remainder;
            Console.Write("Enter the first number n: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number m: ");
            int m = int.Parse(Console.ReadLine());
            
                while (m != 0)
                {
                    remainder = n % m;
                    n = m;
                    m = remainder;
                }
                Console.WriteLine("The GCD of the two numbers is: {0}",n);
            
        }
    }

