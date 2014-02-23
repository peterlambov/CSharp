using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Extension
{
    public static StringBuilder Substring(this StringBuilder builder, int startIndex, int length)
    {
        string temporary = builder.ToString();
        StringBuilder final = new StringBuilder();
        final.Append((temporary.Substring(startIndex, length)).ToString());
        return final;
    }

}

