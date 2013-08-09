//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
using System;
using System.IO;
using System.Linq;
namespace Ex03InsertNumbers
{
    class Insert
    {
        static void Main()
        {
            StreamReader readFile = new StreamReader(@"..\..\sample.txt");
            using (readFile)
            {
                StreamWriter writeFile = new StreamWriter(@"..\..\sampleWithNumbers.txt");
                using (writeFile)
                {

                    int currentLine = 1;
                    string line = readFile.ReadLine();
                    while (line != null)
                    {
                        writeFile.WriteLine("Line {0}: {1}", currentLine, line);
                        line = readFile.ReadLine();
                        currentLine++;
                    }

                }
            }
            Console.WriteLine("Putting number in the beginning of each line and writing to the new file completed !");
        }
    }
}
