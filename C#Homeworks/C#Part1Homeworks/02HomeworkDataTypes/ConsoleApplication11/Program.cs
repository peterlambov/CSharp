
using System;
using System.Text;

class TriangleOfCopyrightSymbols
{
    static void Main()
    {
        Console.Title = "Triangle of copyright symbols";

        Console.OutputEncoding = Encoding.UTF8;
        char copyRightSymbol = '\u00a9';
        int rows = 3;
        int columns = 5;
        int character = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int blankSpace = 0; blankSpace < columns - i; blankSpace++)
            {
                Console.Write(" ");
            }
            for (int symbol = 0; symbol < character; symbol++)
            {
                Console.Write(copyRightSymbol);
            }
            character += 2; //or character = character + 2;
            Console.WriteLine();

        }
    }
}