//Write a program that compares two text files line by line and prints 
//the number of lines that are the same and the number of lines that are different. 
//Assume the files have equal number of lines.
using System;
using System.IO;
using System.Linq;
namespace Ex04LineByLineComparison
{
    class LineByLine
    {
        static void Main()
        {
            StreamReader firstFile = new StreamReader(@"..\..\theFirstFile.txt");
            using (firstFile)
            {
                StreamReader secondFile = new StreamReader(@"..\..\theSecondFile.txt");
                using (secondFile)
                {
                    int sameRows = 0;
                    int differentRows = 0;
                    string lineFirstFile = firstFile.ReadLine();
                    string lineSecondFile = secondFile.ReadLine();
                    while (lineFirstFile != null)
                    {
                        if (lineFirstFile == lineSecondFile)
                        {
                            sameRows++;
                        }
                        else
                        {
                            differentRows++;
                        }
                        lineFirstFile = firstFile.ReadLine();
                        lineSecondFile = secondFile.ReadLine();
                    }
                    Console.WriteLine("Same rows: {0}",sameRows);
                    Console.WriteLine("Different rows: {0}",differentRows);

                }
            }
            
        }
    }
}
