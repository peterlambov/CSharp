//Write a program that deletes from given text file all odd lines. The result should be in the same file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Ex09DeleteOddLines //The start.txt file before execution consists of 10 line on the first line there is "One", 
                             //on the second line there is "Two" and so on. After execution only the even numbers will be left in the file.
{
    class Delete
    {
        static List<string> list = new List<string>();
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\start.txt");
            using (reader)
            {             
                  string line=reader.ReadLine();
                  int lineCount = 1;
                  while (line != null)
                  {
                      if (lineCount % 2 == 0)
                        {
                           list.Add(line);
                        }
                      lineCount++;
                      line = reader.ReadLine();
                  }              
            }
            Writing();
            Console.WriteLine("Process completed!");
        }
        static void Writing()
        {
            StreamWriter writer = new StreamWriter(@"..\..\start.txt");
            using (writer)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }
    }
}
