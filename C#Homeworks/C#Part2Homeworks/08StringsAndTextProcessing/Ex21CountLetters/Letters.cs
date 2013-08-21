//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found. 
using System;
using System.Linq;
namespace Ex21CountLetters
{
    class Letters
    {
        static void Main(string[] args)
        {
            string letters = "aseycKKKoooll".ToLower();
            int[] alphabet = new int['z'-'a'+1];
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] >= 'a' && letters[i] <= 'z')
                {
                    alphabet[letters[i] - 'a']++;
                }
            }
            for (int i = 0; i <alphabet.Length; i++)
            {
                if (alphabet[i] != 0)
                {
                    Console.WriteLine("{0}: {1}",(char)(i+'a'),alphabet[i]);
                }
            }
         
        }
    }
}
