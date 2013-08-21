//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter
//of the string with the first of the key, the second – with the second, etc. When the last key character
//is reached, the next is the first.
using System;
using System.Linq;
using System.Text;
namespace Ex07CodeDecode
{
    class Key
    {
        static void Main()
        {
            string cipher = "pesho"; //Our coding is such that each of the neighbor letters are changed
            string textToCode = "I am coding some text here.";
            Console.WriteLine(DecodeText(CodeText(textToCode, cipher), cipher));
            //string codedText = CodeText(textToCode, cipher);
            //Console.WriteLine("This is the coded text:");
            //Console.WriteLine(codedText);                         //This is the code, calling the methods step by step.
            //string decodedText = DecodeText(codedText, cipher);
            //Console.WriteLine("Here is the decoded text:");
            //Console.WriteLine(decodedText);         
        }

        public static string CodeText(string textToCode, string cipher)
        {
            StringBuilder crypted = new StringBuilder();
            for (int i = 0; i < textToCode.Length; i++)
            {
                crypted.Append((char)((ushort)textToCode[i] ^ (ushort)cipher[ i%cipher.Length ]));
            }
            return crypted.ToString();
        }

        public static string DecodeText(string textToDecode, string cipher)
        {
            StringBuilder decrypted = new StringBuilder();
            for (int i = 0; i < textToDecode.Length; i++)
            {
                decrypted.Append((char)((ushort)textToDecode[i] ^ (ushort)cipher[i%cipher.Length]));
            }
            return decrypted.ToString();
        }
    }
}
