using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CalculateTheSurfaceOfATriangle
{
    class CalculateTheSurfaceOfATriangle
    {
        private static int choice;
        private static double sideA;
        private static double sideB;
        private static double sideC;
        private static double height;
        private static double area;
        private static double angle;

        static void Main(string[] args)
        {
            Console.WriteLine("Your choice\n\"1\" for Side and an altitude \n\"2\" for Three sides \n\"3\" For two sides and an angle between them ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: SideAndAltitude(); break;
                case 2: ThreeSides(); break;
                case 3: TwoSidesAndAnAngleBetweenThem(); break;
                default:
                    break;
            }
        }
        private static void SideAndAltitude()
        {
            Console.Write("Enter side:");
            sideA = int.Parse(Console.ReadLine());
            Console.Write("Enter altitude:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is: {0}", area = (sideA * height) / 2);
        }
        private static void ThreeSides()
        {
            Console.Write("Enter \"a\":");
            sideA = int.Parse(Console.ReadLine());
            Console.Write("Enter \"b\":");
            sideB = int.Parse(Console.ReadLine());
            Console.Write("Enter \"c\":");
            sideC = int.Parse(Console.ReadLine());
            area = (sideA + sideB + sideC) / 2;
            Console.WriteLine("Area is: {0}", Math.Sqrt(area * (area - sideA) * (area - sideB) * (area - sideC)));
        }
        private static void TwoSidesAndAnAngleBetweenThem()
        {
            Console.Write("Enter \"a\":");
            sideA = int.Parse(Console.ReadLine());
            Console.Write("Enter \"b\":");
            sideB = int.Parse(Console.ReadLine());
            Console.Write("Enter angle:");
            angle = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is: {0}", sideA * sideB * Math.Sin(Math.PI * angle / 180) / 2);
        }
    }
}
