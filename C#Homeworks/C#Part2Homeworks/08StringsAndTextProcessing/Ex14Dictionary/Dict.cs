//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary.
using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex14Dictionary  
{
    class Dict
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();//Valid dictionary keys are .NET , CLR , namespace , if you enter s.th different the program throws an exception
            Console.Clear();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");
            string result = dict[key];
            Console.Write("{0} - {1}",key,result);
            Console.WriteLine();
            //string[] dictionary = { ".NET - platform for applications from Microsoft",
            //                    "CLR - managed execution environment for .NET",
            //                    "namespace - hierarchical - organization of classes"};
            //string word = Console.ReadLine();
            //for (int i = 0; i < dictionary.Length; i++)
            //{
            //    if (dictionary[i].IndexOf(word+" -") == 0)
            //    {
            //        Console.WriteLine(dictionary[i]);
            //    }
            //}
        }

        

        
    }
}
