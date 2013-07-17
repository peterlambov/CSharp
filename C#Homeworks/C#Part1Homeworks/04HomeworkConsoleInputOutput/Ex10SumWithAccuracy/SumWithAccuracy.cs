// Write a program to calculate the sum (with accuracy
// of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The sum is :");
            double sum = 1;
            for (double i = 2; i<= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += (1 / i);
                }
                else
                {
                    sum -= (1 / i);
                }
            }
            Console.WriteLine("{0:F3}",sum);
            
        }
    }

