//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>
//with corresponding tags [URL=…]…/URL]. 
//Sample HTML fragment:
//<p>Please visit <a href="http://academy.telerik.
//com">our site</a> to choose a training course. Also
//visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
using System;
using System.Linq;
using System.Text;
namespace Ex15HTMLDoc
{
    class HTML
    {
        static void Main(string[] args)
        {
            string htmlText = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
           
            StringBuilder final = new StringBuilder();
            final.Append(htmlText);
            final.Replace(@"<a href=""", "[URL=");
            final.Replace("</a>", "[/URL]");
            final.Replace(@""">", "]");
            Console.WriteLine(final.ToString());
        }
    }
}
