
//Write a program that reads two arrays from the console and compares them element by element.

using System;

class ComparingElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //Enter the number of elements of the arrays        
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        bool equal = true;

        for (int i = 0; i <firstArray.Length ; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        //Array.Sort(firstArray); // We would sort the arrays if we don't care about the order of the elements but only for their content
        //Array.Sort(secondArray);

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
                break;
            }
        }
        Console.WriteLine("These two arrays have the same elements in the same order: {0}",equal);
        
    }
}

