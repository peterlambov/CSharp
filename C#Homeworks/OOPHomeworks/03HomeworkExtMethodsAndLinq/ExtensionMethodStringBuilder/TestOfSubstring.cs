using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestOfSubstring
{

    static void Main()
    {
        StringBuilder sr = new StringBuilder();
        sr.Append("This is something for test.");
        string final = sr.Substring(0, 6).ToString();
        Console.WriteLine(final);

    }
    
}
