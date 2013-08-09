//Modify the solution of the previous problem to replace only whole words (not substrings).
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace Ex08ReplaceStartModified
{
    class Modified
    {
        static void Main()
        {
            StreamReader readFile = new StreamReader(@"..\..\before.txt");
            using (readFile)
            {
                StreamWriter writeFile = new StreamWriter(@"..\..\after.txt");
                using (writeFile)
                {
                    string line = readFile.ReadLine();

                    while (line != null)
                    {
                        writeFile.WriteLine(Regex.Replace(line,@"\bstart\b", "finish"));
                        line = readFile.ReadLine();
                    }
                }
            }
        }
    }
}