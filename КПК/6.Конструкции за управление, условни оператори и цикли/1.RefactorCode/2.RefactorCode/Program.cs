using System;
using System.Linq;

namespace RefactorCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 23;
            const int MAX_X = 43;
            const int MIN_X = 1;

            const int MAX_Y = 423;
            const int MIN_Y = 3;
            
            bool isXinRange = MIN_X <= x && x <= MAX_X;
            bool isYinRange = MIN_Y <= y && y <= MAX_Y;
            bool visitedCell = true;

            if (isXinRange && isYinRange && visitedCell)
            {
                VisitCell();
            }

           Potato potato = new Potato();
           potato.IsPeeled = true;

            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("The cell has been visited!");
        }

        private static void Cook(Potato potato)
        {
            Console.WriteLine("Cookiing!");
        }
    }
}
