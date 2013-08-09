//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name>
//<age>21</age><interests count="3"><interest> Games</instrest><interest>
//C#</instrest><interest> Java</instrest></interests></student>
using System;
using System.IO;
using System.Linq;
namespace Ex10XMLFile
{
    class Delete
    {
        static void Main()
        {

            using (StreamReader reader = new StreamReader(@"..\..\XML.txt"))
            {
                int i = reader.Read();
                while (i != -1)
                {
                    if (i == '>')
                    {
                        string text = String.Empty;

                        while ((i = reader.Read()) != -1 && i != '<')
                        {
                            text += (char)i;
                        }

                        if (!String.IsNullOrWhiteSpace(text))
                        {
                            Console.WriteLine(text.Trim());
                        }
                    }
                    i = reader.Read();
                }
                
            }
        }
    }
}
    


