//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.7
//Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
using System;
using System.Linq;
using System.Text;
namespace Ex23ReplaceLetters
{
    class Replacement
    {
        static void Main(string[] args)
        {
            string letters = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder  modifiedText = new StringBuilder();
            modifiedText.Append(letters[0]);
            for (int i = 1; i <letters.Length; i++)
            {
                if (letters[i]!=letters[i-1])
                {
                    modifiedText.Append(letters[i]);
                }
            }
            Console.WriteLine(modifiedText.ToString());
        }
    }
}
