//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
using System;
using System.Linq;
using System.Text;
namespace Ex13ReverseWords
{
    class Reverse
    {
        static void Main()
        {
            StringBuilder reversed = new StringBuilder();
            string sentence = "C# is not C++, not PHP and not Delphi!";
            string[] words = sentence.Split(new char[] { ' ', '!', ',', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string[] symbols=  sentence.Split(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')', '(',
                                                '*', '/', '=', '~', '`' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                reversed.Append(words[i] );
                reversed.Append(symbols[i]);
            }
            Console.WriteLine(reversed.ToString());
        }
    }
}
