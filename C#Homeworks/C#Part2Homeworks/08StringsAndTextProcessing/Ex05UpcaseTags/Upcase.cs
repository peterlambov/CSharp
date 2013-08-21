//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase>
//to uppercase. The tags cannot be nested. 
//Example:
//We are living in a <upcase>yellow
//submarine</upcase>. We don't have
//<upcase>anything</upcase> else.
using System;
using System.Linq;
namespace Ex05UpcaseTags
{
    class Upcase
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < text.Length-8; i++)
            {
                if (text.Substring(i, 8) == "<upcase>")
                {
                    i += 8;
                    startIndex = i;
                }
                else if (text.Substring(i, 9) == "</upcase>")
                {
                    endIndex = i;
                    string upper = text.Substring(startIndex, endIndex - startIndex).ToUpper();
                    text = text.Replace(text.Substring(startIndex, endIndex - startIndex), upper);
                    text = text.Remove(startIndex - 8, 8);
                    text = text.Remove(endIndex-8, 9);
                }
            }
            Console.WriteLine(text);
        }
    }
}
