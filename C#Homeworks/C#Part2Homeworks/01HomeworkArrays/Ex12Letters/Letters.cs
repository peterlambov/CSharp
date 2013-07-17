//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

using System;

    class Letters
    {
        static void Main()
        {
            char[] array = new char[26];
            Console.WriteLine("Enter the length of your word:");
            int n = int.Parse(Console.ReadLine());//Enter how long you word is going to be.
           char [] word = new char[n];
           Console.WriteLine("Enter each letter of the word(spell it):");
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = char.Parse(Console.ReadLine());//Enter a letter on each row.
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar('a' + i+1);
            }
        
            Console.WriteLine("Here are the positions of each element in the english alphabet,corresponding to the word you entered:");
            foreach (char index in word)
            {
                Console.WriteLine((int)(index-'a'+1));//Here we get the position of each letter.
           }
        
            
        }
    }

