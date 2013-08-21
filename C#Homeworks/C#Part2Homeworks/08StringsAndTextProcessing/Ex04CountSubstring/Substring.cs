//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. 
//So we are drinking all the day. 
//We will move out of it in 5 days.
//    The result is: 9.
using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Ex04CountSubstring
{
    class Substring
    {
        static void Main()
        {
            string target = "in".ToUpper();
            int index = -1;
            int counter = 0;
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.".ToUpper();
            while (true)
            {
                index = text.IndexOf(target, index + 1);
                if (index == -1)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(@"Number of ""in"" is {0}.",counter);
           // Console.WriteLine(Regex.Matches(text,target).Count); //Using regular expressions
        }
    }
}
