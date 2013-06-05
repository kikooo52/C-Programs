using System;

namespace _11.ConvertsANumber
{
    class NumberConvertor
    {
        static void Main()
        {
            string[] fourthnum = new string[] { };
            String[] FirstDigitString = new String[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            String[] SecondDigitString = new String[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            String[] SpecialDigitString = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            int N;
            do
            {
                Console.WriteLine("Enter a number between 0 and 999");
                N = int.Parse(Console.ReadLine());
            }
            while (N < 0 || N > 999);

            int FirstDigit = N % 10;
            N /= 10;
            int counter = 1;
            int SecondDigit = 0;
            int ThirdDigit = 0;
            if ((N + 9) / 10 != 0)
            {
                SecondDigit = N % 10;
                N /= 10;
                counter++;
            }
            if ((N + 9) / 10 != 0)
            {
                ThirdDigit = N % 10;
                N /= 10;
                counter++;
            }

            if (counter == 1)
            {
                if (FirstDigit == 0)
                {
                    Console.WriteLine("zero");
                }
                else
                {
                    Console.WriteLine(FirstDigitString[FirstDigit]);
                }
            }

            if (counter == 2)
            {
                if (SecondDigit == 1)
                {
                    Console.WriteLine(SpecialDigitString[FirstDigit]);
                }
                else
                {
                    Console.WriteLine("{0} {1}", SecondDigitString[SecondDigit], FirstDigitString[FirstDigit]);
                }
            }

            if (counter == 3)
            {
                if (SecondDigit == 1)
                {
                    Console.WriteLine("{0} hundred and {1}", FirstDigitString[ThirdDigit], SpecialDigitString[FirstDigit]);
                }
                else if (FirstDigit == 0 && SecondDigit == 0)
                {
                    Console.WriteLine("{0} hundred", FirstDigitString[ThirdDigit]);
                }
                else
                {
                    Console.WriteLine("{0} hunred and {1} {2}", FirstDigitString[ThirdDigit], SecondDigitString[SecondDigit], FirstDigitString[FirstDigit]);
                }
            }
        }
    }
}
