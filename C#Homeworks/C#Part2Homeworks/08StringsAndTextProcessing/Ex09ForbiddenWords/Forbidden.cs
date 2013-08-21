//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. 
//Example:
//Microsoft announced its next generation PHP compiler today.
//It is based on .NET Framework 4.0 
//and is implemented as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
using System;
using System.Linq;
namespace Ex09ForbiddenWords
{
    class Forbidden
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today.It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
            string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < words.Length; j++)
                {
                    for (int k = 0; k < forbiddenWords.Length; k++)
                    {
                        if (String.Compare(words[j], forbiddenWords[k], true) == 0)
                        {
                            text = text.Replace(forbiddenWords[k]
                                 , new string('*', forbiddenWords[k].Length));
                        }
                    }
                }
            }
            Console.WriteLine("This is the censored text:");
            Console.WriteLine(text);
            //string textInput = "Microsoft announced its next generation PHP compiler today.It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            //string[] forbiddenWords = "PHP, CLR, Microsoft".Split(',');
            //for (int i = 0; i < forbiddenWords.Length; i++)
            //{
            //    forbiddenWords[i] = forbiddenWords[i].Trim();
            //    textInput = textInput.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            //}
            //Console.WriteLine(textInput);
        }
    }
}
