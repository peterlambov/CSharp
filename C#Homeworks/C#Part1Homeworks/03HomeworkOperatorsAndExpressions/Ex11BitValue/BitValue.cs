// 11. Write an expression that extracts from a given integer i the value of a given bit number b.
using System;
    class BitValue
    {
        static void Main()
        {
            Console.WriteLine("Enter you number and then the bit whose value you want to know");
            int a = int.Parse(Console.ReadLine());
            int bitNumber = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << bitNumber;
            int aAndmask = a & mask;
            int bitValue = aAndmask >> bitNumber;
            Console.WriteLine("The value of the {0} bit of the number is : {1}",bitNumber,bitValue);//counting the bits from 0
        }
    }

