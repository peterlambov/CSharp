//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, 
//the rest of the characters should be filled with '*'. 
//Print the result string into the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex06AddStars
{
    class Stars
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder temp = new StringBuilder();
            temp.Append(text);
            while (temp.Length!=20)
            {
                temp.Append("*"); 
            }
            Console.WriteLine(temp.ToString());


        }
    }
}
