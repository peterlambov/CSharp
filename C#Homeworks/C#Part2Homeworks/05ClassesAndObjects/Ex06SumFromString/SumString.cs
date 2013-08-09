//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example:	string = "43 68 9 23 318"  result = 461
using System;
using System.Linq;
namespace Ex06SumFromString
{
    class SumString
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine(); //Enter the numbers with one space between each of them.
            sequence.Trim(); // In case there are any unwanted spaces
            string[] array = sequence.Split(' '); 
            int sumOfNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumOfNumbers += int.Parse(array[i].Trim()); //One of the properties of the Trim() method is to convert the string representation of a number to its 32-bit signed integer equivalent.
            }
            Console.WriteLine(sumOfNumbers);
            
        }
    }
}
