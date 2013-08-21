//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".
using System;
using System.Linq;
using System.Text;
namespace Ex02ReverseString
{
    class Reversing
    {
        static void Main()
        {
            Console.WriteLine("Enter your word:");
            string word = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            for (int i = word.Length-1; i >=0; i--)
            {
                reversed.Append(word[i]);
            }
            Console.WriteLine(reversed.ToString());
        }
    }
}
