//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Linq;
namespace Ex24SortWords
{
    class Sort
    {
        static void Main()
        {
            string text = "We have some names, Peter, George and Zina.";
            string[] words = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
