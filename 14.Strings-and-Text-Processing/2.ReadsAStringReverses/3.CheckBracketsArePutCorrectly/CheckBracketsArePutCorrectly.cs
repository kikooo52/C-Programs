using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CheckBracketsArePutCorrectly
{
    class CheckBracketsArePutCorrectly
    {
        static void Main(string[] args)
        {
            try
            {
                checkExpression();
            }
            catch (FormatException)
            {
                Console.WriteLine("is found wrong bracket");
                
            }
        }

        private static void checkExpression()
        {
            string expressionIncorrectly = ")(10 * 222 - 1)";
            char bracket = ')';
            char newbracket = '(';
            int counter = 0;
            int newcounter = 0;
            int lenght = expressionIncorrectly.Length;
            for (int i = 0; i < expressionIncorrectly.Length; i++)
            {
                if (expressionIncorrectly[i] == bracket)
                {
                    counter++;
                }
                if (expressionIncorrectly[i] == newbracket)
                {
                    newcounter++;
                }
            }
                if (counter == newcounter)
                {
                    Console.WriteLine("expression is right");
                }
                else
                {
                    throw new FormatException();
                }            
        }
    }
}


