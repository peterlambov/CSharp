//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
using System;
using System.Linq;
namespace Ex03CorrectBrackets
{
    class Brackets
    {
        static void Main()
        {
            string expressionFirst = ")(((a+b+c)(*d))";
            int brackCount1 = 0;
            int brackCount2 = 0;
            for (int i = 0; i < expressionFirst.Length; i++)
            {
                if (expressionFirst[0] == ')' || expressionFirst[expressionFirst.Length - 1] == '(')
                {
                    Console.WriteLine("Invalid brackets!");
                    break;
                }
                else
                {
                    if (expressionFirst[i] == '(')
                    {
                        brackCount1++;
                    }
                    else if (expressionFirst[i] == ')')
                    {
                        brackCount2++;
                    }

                }
            }
            if (brackCount1 == brackCount2 && brackCount1!=0 && brackCount2!=0)
            {
                Console.WriteLine("The brackets are valid!");
            }
            else if (brackCount1 != brackCount2)
            {
                Console.WriteLine("Invalid brackets!");
            }

        }
    }
}
