// 05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
using System;
    class ThirdBit
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int aAndmask = a & mask;
            int bit = aAndmask >> p;
            Console.WriteLine("The third bit of the number is: {0}",bit);
        }
    }

