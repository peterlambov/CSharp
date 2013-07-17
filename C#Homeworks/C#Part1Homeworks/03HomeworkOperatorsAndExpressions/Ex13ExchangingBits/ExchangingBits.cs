// 12. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;
    class ExchangingBits
    {
        static void Main()
        {
            uint a = 34589216;
            uint mask = 7; //The binary representation of 7 is 111
            uint getFirstBits = (mask << 3) & a; //We get bits 3,4,5
            uint getSecondBits = (mask << 24) & a; //We get bits 24,25,26
            getFirstBits = getFirstBits << 21; //We push bits 3,4,5  twenty one positions to the left so they go to posisitions 24,25,26
            getSecondBits = getSecondBits >> 21; //We push bits 24,25,26 twenty one positions to the right so they go to positions 3,4,5
            a = a & (~(mask << 3));//This makes bits 3,4,5 become 0 for easier concatenation
            Console.WriteLine(Convert.ToString(a,2));
            a = a & (~(mask << 21));//This makes bits 24,25,26 become 0 for easier concatenation
            Console.WriteLine(Convert.ToString(a,2));
            a = a | getFirstBits;//concatenate the number and the bits 3,4,5
            Console.WriteLine(Convert.ToString(a, 2));
            a = a | getSecondBits;//concatenate the number and the bits 24,25,26
            Console.WriteLine(Convert.ToString(a,2));
            Console.WriteLine(a);



            
            
            
        }
    }

