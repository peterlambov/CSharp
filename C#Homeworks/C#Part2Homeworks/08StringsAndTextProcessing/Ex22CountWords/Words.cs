//Write a program that reads a string from the console and lists all different words in
//the string along with information how many times each word is found.
using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex22CountWords
{
    class Words
    {
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string text = "Exam exam exam , it is coming soon wether you like it or or or not not not not.".ToLower();//Looks like an echo :D
            string[] words = text.Split(new char[] { '.', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;
                if(dict.ContainsKey(words[i]))
                {
                    count = dict[words[i]]+1;
                }
                dict[words[i]] = count;
               
            }
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine("{0}: {1}",item.Key,item.Value);
            }
        }
    }
}
