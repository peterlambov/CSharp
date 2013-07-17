// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;
using System.Linq;

class MinimalMaximal
{

    static void Main()
    {
        Console.Write("Enter the numbers quantity: ");
        int numberCount = int.Parse(Console.ReadLine());
        int[] numberArray = new int[numberCount];

        for (int i = 0; i < numberCount; i++)
        {
            numberArray[i] = int.Parse(Console.ReadLine());
        }
        int minimum = numberArray[0];
        int maximum = numberArray[0];
        for (int i = 0; i < numberArray.Length; i++)
        {
            if (maximum < numberArray[i])
            {
                maximum = numberArray[i];
            }
            if (minimum > numberArray[i])
            {
                minimum = numberArray[i];
            }
        }
        Console.WriteLine("The minimum is {0}", minimum);
        Console.WriteLine("The maximum is {0}", maximum);
       

    }
}