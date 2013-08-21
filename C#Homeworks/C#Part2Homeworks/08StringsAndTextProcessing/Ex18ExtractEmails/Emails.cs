//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
namespace Ex18ExtractEmails
{
    class Emails
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder();
            string text = "Static void Main() nakov@telerik.com. using System,nakov@gmail.com return, pesho@abv/bg , doncho@gmail.com";
            MatchCollection matches = Regex.Matches(text, @"(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})");
            for (int i = 0; i <matches.Count; i++)
            {
                Console.WriteLine(matches[i]); 
            }
            //foreach (var item in Regex.Matches(text, @"(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})"))
            //{
            //    Console.WriteLine(item);
            //}
          
        }
    }
}
