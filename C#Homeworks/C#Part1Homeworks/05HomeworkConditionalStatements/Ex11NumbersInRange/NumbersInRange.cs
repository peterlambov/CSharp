//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
using System;
    class NumbersInRange
    {
        static void Main()
        {
            Console.WriteLine("Please enter your number in the range [0..999] :");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("zero"); 
            }
            else if (number < 0 || number > 999)
            {
                Console.WriteLine("Invalid number!");
            }
            if(number<20 && number>=10)
            {
                int ones= number%10;
                switch (ones)
                {
                    case 0: Console.WriteLine("ten");
                        break;
                    case 1: Console.WriteLine("eleven");
                        break;
                    case 2: Console.WriteLine("twelve");
                        break;
                    case 3: Console.WriteLine("thirteen");
                        break;
                    case 4: Console.WriteLine("fourteen");
                        break;
                    case 5: Console.WriteLine("fifteen");
                        break;
                    case 6: Console.WriteLine("sixteen");
                        break;
                    case 7: Console.WriteLine("seventeen");
                        break;
                    case 8: Console.WriteLine("eighteen");
                        break;
                    case 9: Console.WriteLine("nineteen");
                        break;
                    default: Console.WriteLine("Error!");
                        break;
                }
            }
            else if(number>=20 && number<100)
            {
                int  ones = (number%10);
                int tens = (number/10);
                switch (tens)
                {
                    case 2: Console.Write("twenty"+ " ");
                        break;
                    case 3: Console.Write("thirty" + " ");
                        break;
                    case 4: Console.Write("forty" + " ");
                        break;
                    case 5: Console.Write("fifty" + " ");
                        break;
                    case 6: Console.Write("sixty" + " ");
                        break;
                    case 7: Console.Write("seventy" + " ");
                        break;
                    case 8: Console.Write("eighty" + " ");
                        break;
                    case 9: Console.Write("ninety" + " ");
                        break;
                    default: Console.Write("Error");
                        break;
                }
                switch (ones)
                {
                    case 0: Console.WriteLine(" ");
                        break;
                    case 1: Console.WriteLine("one");
                        break;
                    case 2: Console.WriteLine("two");
                        break;
                    case 3: Console.WriteLine("three");
                        break;
                    case 4: Console.WriteLine("four");
                        break;
                    case 5: Console.WriteLine("five");
                        break;
                    case 6: Console.WriteLine("six");
                        break;
                    case 7: Console.WriteLine("seven");
                        break;
                    case 8: Console.WriteLine("eight");
                        break;
                    case 9: Console.WriteLine("nine");
                        break;
                    default: Console.WriteLine("Error");
                        break;
                }
                
                }
                if (number > 20 && number >= 100 && number <= 999 && (number % 100) > 20 || (number % 100) < 10 || number % 10 == 0&&(number/100)!=0)
            {
                int hundreds = number /100;
                int tens = (number%100)/10 ;
                int ones = number % 10;
                switch (hundreds)
                {
                    
                    case 1: Console.Write("one hundred" + " ");
                        break;
                    case 2: Console.Write("two hundred" + " ");
                        break;
                    case 3: Console.Write("three hundred" + " ");
                        break;
                    case 4: Console.Write("four hundred" + " ");
                        break;
                    case 5: Console.Write("five hundred" + " ");
                        break;
                    case 6: Console.Write("six hundred" + " ");
                        break;
                    case 7: Console.Write("seven hundred" + " ");
                        break;
                    case 8: Console.Write("eight hundred" + " ");
                        break;
                    case 9: Console.Write("nine hundred" + " ");
                        break;
                    default: Console.Write(" ");
                        break;
                }
                switch (tens)
                {
                    case 0: Console.Write("");
                        break;
                    case 1: Console.Write( "and" + " "+ "ten" + " ");
                        break;
                    case 2: Console.Write("and" + " " + "twenty" + " ");
                        break;
                    case 3: Console.Write("and" + " " + "thirty" + " ");
                        break;
                    case 4: Console.Write("and" + " " + "forty" + " ");
                        break;
                    case 5: Console.Write("and" + " " + "fifty" + " ");
                        break;
                    case 6: Console.Write("and" + " " + "sixty" + " ");
                        break;
                    case 7: Console.Write("and" + " " + "seventy" + " ");
                        break;
                    case 8: Console.Write("and" + " " + "eighty" + " ");
                        break;
                    case 9: Console.Write("and" + " " + "ninety" + " ");
                        break;
                    default: Console.Write(" ");
                        break;

                }
                switch (ones)
                {
                    case 0: Console.Write(" ");
                        break;
                    case 1: Console.Write("one");
                        break;
                    case 2: Console.Write("two");
                        break;
                    case 3: Console.Write("three");
                        break;
                    case 4: Console.Write("four");
                        break;
                    case 5: Console.Write("five");
                        break;
                    case 6: Console.Write("six");
                        break;
                    case 7: Console.Write("seven");
                        break;
                    case 8: Console.Write("eight");
                        break;
                    case 9: Console.Write("nine");
                        break;
                    default: Console.Write(" ");
                        break;
                }
            }
            
                
                else if (number>20 && (number % 100) > 10 && (number % 100) < 20)
                        {
                            int hundredsY = number / 100;
                            switch (hundredsY)
                            {
                                case 1: Console.Write("one hundred" );
                                    break;
                                case 2: Console.Write("two hundred" );
                                    break;
                                case 3: Console.Write("three hundred" );
                                    break;
                                case 4: Console.Write("four hundred" );
                                    break;
                                case 5: Console.Write("five hundred" );
                                    break;
                                case 6: Console.Write("six hundred" );
                                    break;
                                case 7: Console.Write("seven hundred" );
                                    break;
                                case 8: Console.Write("eight hundred" );
                                    break;
                                case 9: Console.Write("nine hundred" );
                                    break;
                                default: Console.Write(" ");
                                    break;
                            }
                            int tensTwo = number % 100;
                            switch (tensTwo)
                            {
                                case 11: Console.WriteLine(" " + "and" +" "+ "eleven");
                                    break;
                                case 12: Console.WriteLine(" " + "and" + " " + "twelve");
                                    break;
                                case 13: Console.WriteLine(" " + "and" + " " + "thirteen");
                                    break;
                                case 14: Console.WriteLine(" " + "and" + " " + "fourteen");
                                    break;
                                case 15: Console.WriteLine(" " + "and" + " " + "fifteen");
                                    break;
                                case 16: Console.WriteLine(" " + "and" + " " + "sixteen");
                                    break;
                                case 17: Console.WriteLine(" " + "and" + " " + "seventeen");
                                    break;
                                case 18: Console.WriteLine(" " + "and" + " " + "eighteen");
                                    break;
                                case 19: Console.WriteLine(" " + "and" + " " + "nineteen");
                                    break;
                                default: Console.WriteLine(" ");
                                    break;
                            
                            }
                            
                        
                
            }
            Console.WriteLine();

        }
    }


