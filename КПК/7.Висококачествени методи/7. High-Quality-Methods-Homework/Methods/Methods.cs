using System;

namespace Methods
{
    class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArithmeticException("Sides have to by positive number");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

             throw new ArgumentOutOfRangeException("The number have to be in range[0..9]");
        }

        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("The array can not to be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Please enter arguments");
            }

            int maxNumber = 0;
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        public static void PrintAsNumber(object number)
        { 
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintRightAlignedNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)         
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        public static bool IsVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;

            return isVertical;
        }

        public static bool IsHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;

            return isHorizontal;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));       
            Console.WriteLine(NumberToDigit(5));  
            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3);
            PrintAsPercent(0.75);
            PrintRightAlignedNumber(2.30);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsHorizontal(3,3));
            Console.WriteLine("Vertical? " + IsVertical(3,2));

            Student peter = new Student("Peter", "Ivanov", "From Sofia", "1/03/1992 14:00:00");

            Student stella = new Student("Stella", "Markova", "From Vidin", "03/11/1993 14:00:00");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella, peter));
        }
    }
}
