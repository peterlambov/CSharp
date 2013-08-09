//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George			Peter
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Ex06SortNames
{
    class Names
    {
        static void Main()
        {
            StreamReader unsorted = new StreamReader(@"..\..\names.txt");
            using (unsorted)
            {
                StreamWriter sorted = new StreamWriter(@"..\..\sortedNames.txt");
                using (sorted)
                {
                    List<string> sortingList = new List<string>();
                    string line = unsorted.ReadLine();
                    while (line != null)
                    {
                        sortingList.Add(line);
                        line = unsorted.ReadLine();
                    }
                    sortingList.Sort();
                    for (int i = 0; i < sortingList.Count; i++)
                    {
                        sorted.WriteLine(sortingList[i]);
                    }
                    Console.WriteLine("Operation completed!");
                }
            }

        }
    }
}
