// Write a program that reads two positive integer numbers
// and prints how many numbers p exist between them such
// that the reminder of the division by 5 is 0 (inclusive).
// Example: p(17,25) = 2.
using System;

class TwoIntegers
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = a; i <= b; i++)//This is the case when a<b
            {
                if (i % 5 == 0)
                {
                    p += 1;
                }
            }
            Console.Write("This is the result if a is smaller than b: ");
            Console.WriteLine(p);
            for (int i = b ; i <= a; i++)//This is the case when a>b
            {
                if (i % 5 == 0)
                {
                    p += 1;
                }
            }
            Console.Write("This is the result if a is bigger than b: ");
            Console.WriteLine(p);

        }
    }

