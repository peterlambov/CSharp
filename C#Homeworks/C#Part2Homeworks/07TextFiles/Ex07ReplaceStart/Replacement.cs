//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.IO;
using System.Linq;
namespace Ex07ReplaceStart
{
    class Replacement
    {
        static void Main()
        {
            StreamReader readFile = new StreamReader(@"..\..\beforeReplace.txt");
            using (readFile)
            {
                StreamWriter writeFile = new StreamWriter(@"..\..\afterReplace.txt");
                using (writeFile)
                {
                    string line = readFile.ReadLine();
                    
                    while (line!=null)
                    {
                        writeFile.WriteLine(line.Replace("start","finish"));
                        line = readFile.ReadLine();
                    }
                }
            }
        }
    }
}

