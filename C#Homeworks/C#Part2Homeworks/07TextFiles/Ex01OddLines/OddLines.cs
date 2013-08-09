//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;
using System.Linq;
namespace Ex01OddLines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\OddLines.cs");
            using (reader)
            {
                int currentLine = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (currentLine % 2 != 0) 
                    {
                        Console.WriteLine("Line {0}: {1}", currentLine, line);
                    }
                    line = reader.ReadLine();
                    currentLine++;
                }
                 
            }
        }
    }
}
