//Write a program that converts a string to a sequence of C# Unicode character literals. 
//Use format strings. 
//Sample input: Hi!
//Output:\u0048u\0069\u0021
using System;
using System.Linq;
namespace Ex10StringToUnicode
{
    class Unicode
    {
        static void Main()
        {
            string input = "Hi!";
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output+=String.Format("\\u{0:x4}",(int)input[i]);
            }
            Console.WriteLine(output);
        }
    }
}
