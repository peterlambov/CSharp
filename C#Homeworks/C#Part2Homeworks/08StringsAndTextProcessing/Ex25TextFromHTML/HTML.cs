//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
//Example:<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Ex25TextFromHTML
{
    class HTML
    {
        static void Main()
        {
            string text= @"<head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            StringBuilder result = new StringBuilder();
            MatchCollection values = Regex.Matches(text, "(?<=^|>)[^><]+?(?=<|$)");
            foreach (Match partOfText in values)
            {
               result.Append(partOfText+" ");
            }
            Console.WriteLine(result.ToString());
            
        }
    }
}
