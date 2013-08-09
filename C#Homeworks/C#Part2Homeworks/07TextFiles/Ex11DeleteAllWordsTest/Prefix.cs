//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Ex11DeleteAllWordsTest
{
    class Prefix
    { 
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\somewords.txt");
            using (reader)
            {
                StreamWriter writer = new StreamWriter(@"..\..\withoutTest.txt");
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                        line = reader.ReadLine();
                    }
                }
                Console.WriteLine("Process finished!");
            }
        }
    }
}
