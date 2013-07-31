//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05HexadecimalToBinary
{
    class HexToBin
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine();
            char[] array = hexNumber.ToCharArray();
                
            List<int> binList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case 'A': binList.Add(1010);
                        break;
                    case 'B': binList.Add(1011);
                        break;
                    case 'C': binList.Add(1100);
                        break;
                    case 'D': binList.Add(1101);
                        break;
                    case 'E': binList.Add(1110);
                        break;
                    case 'F': binList.Add(1111);
                        break;
                    default: int number = int.Parse(array[i].ToString());
                        switch (number)
                        {
                            case 0: binList.Add(0);
                                binList.Add(0);
                                binList.Add(0);
                                binList.Add(0);
                                break;
                            case 1: binList.Add(0);
                                binList.Add(0);
                                binList.Add(0);
                                binList.Add(1);
                                break;
                            case 2:
                                binList.Add(0);
                                binList.Add(0);
                                binList.Add(1);
                                binList.Add(0);
                                break;
                            case 3:
                                binList.Add(0);
                                binList.Add(0);
                                binList.Add(1);
                                binList.Add(1);
                                break;
                            case 4: 
                                binList.Add(0);
                                binList.Add(1);
                                binList.Add(0);
                                binList.Add(0);
                                break;
                            case 5:
                                binList.Add(0);
                                binList.Add(1);
                                binList.Add(0);
                                binList.Add(1);
                                break;
                            case 6: 
                                binList.Add(0);
                                binList.Add(1);
                                binList.Add(1);
                                binList.Add(0);
                                break;
                            case 7:
                                binList.Add(0);
                                binList.Add(1);
                                binList.Add(1);
                                binList.Add(1);
                                break;
                            case 8:
                                binList.Add(1);
                                binList.Add(0);
                                binList.Add(0);
                                binList.Add(0);
                                break;
                            case 9:
                                binList.Add(1);
                                binList.Add(0);
                                binList.Add(0);
                                binList.Add(1);
                                break;
                            default:
                                break;
                            
                        }
                        break;
                }                         
                        
                        

                }
            for (int i = 0; i < binList.Count; i++)
            {
                Console.Write(binList[i]);
            }
            Console.WriteLine();
            }
           
            

            
        }
    }

