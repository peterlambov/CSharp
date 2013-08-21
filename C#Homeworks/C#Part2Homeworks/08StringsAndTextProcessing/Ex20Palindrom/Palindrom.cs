//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;
using System.Linq;
using System.Text;
namespace Ex20Palindrom
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder final = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reversed = Reverse(word);
                if (word == reversed && word.Length > 1)
                {
                    final.AppendLine(words[i]);
                }
            }
            Console.Write(final.ToString());
            //string word = "";
            //for (int i = 0; i < words.Length; i++)
            //{
            //    bool isPal = true;
            //    word = words[i];
            //    for (int j = 0; j < word.Length / 2; j++)
            //    {
            //        if (word[j] != word[word.Length - 1 - j])
            //        {
            //            isPal = false;
            //        }
                   
            //    }
            //     if (isPal == true && word.Length > 1)
            //        {
            //            final.AppendLine(word);
            //        }
            //}
            //Console.Write(final.ToString());

        }
        static string Reverse(string word)
        {
            string result = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }
    }
}
