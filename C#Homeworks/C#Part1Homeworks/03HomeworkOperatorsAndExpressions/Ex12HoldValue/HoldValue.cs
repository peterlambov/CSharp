// 12. We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
// Example: n = 5 (00000101), p=3, v=1  13 (00001101)
using System;

    class HoldValue
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());//For example the number 5
            int bitPosition = int.Parse(Console.ReadLine());//For example position 3
            int value = 1;
            value = value << bitPosition;
            int valueOrn = n | value;
            int newNumber = valueOrn;
            Console.WriteLine(newNumber);//If the above examples are used the result is 13

        }
    }

