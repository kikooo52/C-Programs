using System;
using System.Linq;

namespace RefactorCode
{
    class PrintNumber
    {
        public const int MaxCount = 6;

        class Method
        {
           public void PrintBoolValue(bool boolVariable)
            {
                string stringVeriable = boolVariable.ToString();
                Console.WriteLine(stringVeriable);
            }
        }

        public static void Main()
        {
            PrintNumber.Method print = new PrintNumber.Method();
            print.PrintBoolValue(true);
        }
    }
}
