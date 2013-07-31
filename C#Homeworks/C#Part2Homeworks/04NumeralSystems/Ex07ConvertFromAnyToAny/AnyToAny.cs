//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ex07ConvertFromAnyToAny
{
    class AnyToAny
    {
        static void Main()
        {
            Console.WriteLine("Enter your number:");
            string number = Console.ReadLine();
            Console.WriteLine("Enter the first base s:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second base d:");
            int d = int.Parse(Console.ReadLine());
            if (s == 16)
            {
                char[] decArray = number.ToCharArray();
                Array.Reverse(decArray);
                int sum = 0;//This is where we going to keep the actual decimal number.
                for (int i = 0; i < decArray.Length; i++)
                {
                    int digit = 0;
                    switch (decArray[i])
                    {
                        case 'A': digit = 10;
                            break;
                        case 'B': digit = 11;
                            break;
                        case 'C': digit = 12;
                            break;
                        case 'D': digit = 13;
                            break;
                        case 'E': digit = 14;
                            break;
                        case 'F': digit = 15;
                            break;
                        default: digit = int.Parse(decArray[i].ToString());
                            break;
                    }
                    for (int j = 0; j < i; j++)
                    {
                        digit = digit * 16;
                    }

                    sum += digit;
                }

                List<string> final = new List<string>();
                while (sum > 0)
                {
                    switch (sum % d)
                    {
                        case 10:
                            final.Add("A");
                            break;
                        case 11:
                            final.Add("B");
                            break;
                        case 12:
                            final.Add("C");
                            break;
                        case 13:
                            final.Add("D");
                            break;
                        case 14:
                            final.Add("E");
                            break;
                        case 15:
                            final.Add("F");
                            break;
                        default:
                            final.Add((sum % d).ToString());
                            break;
                    }
                    sum = sum / d;
                }
                final.Reverse();
                Console.WriteLine("This is the representation of the number with base {0}:", d);
                for (int i = 0; i < final.Count; i++)
                {
                    Console.Write(final[i]);
                }
                Console.WriteLine();

            }
            else
            {
                StringBuilder reversion = new StringBuilder();
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    reversion.Append(number[i]);
                }
                number = reversion.ToString();
                //Conversion from number of base s to decimal number.
                int decimalNumber = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    decimalNumber += int.Parse(number[i].ToString()) * Convert.ToInt32(Math.Pow(s, i));
                }
                if (d == 10)
                {
                    Console.WriteLine("The converted number with base {0} is {1} .", d, decimalNumber);
                }
                else
                {

                    List<string> final = new List<string>();
                    while (decimalNumber > 0)
                    {
                        switch (decimalNumber % d)
                        {
                            case 10:
                                final.Add("A");
                                break;
                            case 11:
                                final.Add("B");
                                break;
                            case 12:
                                final.Add("C");
                                break;
                            case 13:
                                final.Add("D");
                                break;
                            case 14:
                                final.Add("E");
                                break;
                            case 15:
                                final.Add("F");
                                break;
                            default:
                                final.Add((decimalNumber % d).ToString());
                                break;
                        }
                        decimalNumber = decimalNumber / d;
                    }
                    final.Reverse();
                    Console.WriteLine("This is the representation of the number with base {0}:", d);
                    for (int i = 0; i < final.Count; i++)
                    {
                        Console.Write(final[i]);
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
