//Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:
//We are living in a yellow submarine. 
//We don't have anything else. Inside the submarine is very tight. 
//So we are drinking all the day.
////We will move out of it in 5 days.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.
using System;
using System.Linq;
using System.Text;
namespace Ex08ExtractSentences
{
    class Sentence
    {
        static void Main()
        {
            StringBuilder sr = new StringBuilder();
            
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
            string[] sentences = text.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(' ');
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == "in")
                    {
                        sr.AppendLine(sentences[i].Trim() + ".");
                    }
                }
            }
            Console.WriteLine(sr.ToString());
        }
    }
}
