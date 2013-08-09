//Write a program that concatenates two text files into another text file.
using System;
using System.IO;
using System.Linq;
namespace Ex02TwoFiles //To open the test.txt after executing the program and see the result you can click on "Show all files" 
                       //on the top of the Solution Explorer  and the test.txt will appear right under Concat.cs
                       //or to go to bin>debug>test.txt 
                       //Then you can delete the written text on the file and run the program again.
{
    class Concat
    {
        static void Main()
        {
            StreamWriter writerFirst = new StreamWriter(@"..\..\test.txt",false);
            using (writerFirst)
            {
                StreamReader readFirstDoc = new StreamReader(@"..\..\Concat.cs"); //The first document is the Concat.cs.
                using (readFirstDoc)
                {
                    string lineDoc1 = readFirstDoc.ReadLine();
                        while(lineDoc1!=null)
                        {
                            writerFirst.WriteLine(lineDoc1);
                            lineDoc1=readFirstDoc.ReadLine();
                        }
                }
                
            }
            StreamWriter writerSecond = new StreamWriter(@"..\..\test.txt", true);
            using(writerSecond)
            {
                StreamReader readSecondDoc = new StreamReader(@"..\..\App.config"); //The second document is App.config
                using (readSecondDoc)
                {

                    string lineDoc2 = readSecondDoc.ReadLine();
                    while (lineDoc2 != null)
                    {
                        writerSecond.WriteLine(lineDoc2);
                        lineDoc2 = readSecondDoc.ReadLine();
                    }
                }
            }
            Console.WriteLine("Concatenation finished!");
        }
    }
}
