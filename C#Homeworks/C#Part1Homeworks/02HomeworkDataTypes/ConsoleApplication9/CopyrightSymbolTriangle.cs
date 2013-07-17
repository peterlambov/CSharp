using System;
class CopyrightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char a = '\u00A9';
        int rows = 3;
        int columns = 5;
        int character = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int Space = 0; Space < columns - i; Space++)
            {
                Console.Write(" ");
            }
            for (int symbol = 0; symbol < character; symbol++)
            {
                Console.Write(a);
            }
            character = character + 2;
            Console.WriteLine();

        }
    
}
        
    
}
