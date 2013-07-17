// 10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
using System;
    class BitPosition
    {
        static void Main()
        {
            Console.WriteLine("Type a number:");
            int v = int.Parse(Console.ReadLine());
            int bitPosition = 3;
            int mask = 1;
            mask = mask << bitPosition;
            int maskAndv = v & mask;
            int bit = maskAndv >> bitPosition;
            Console.Write("The third bit of the number is 1: ");
            if (bit == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

