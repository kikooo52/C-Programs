using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Car
    {
        public int x;
        public int y;
        public char car;
        public ConsoleColor color;
    }
    class Program
    {
        static void Main()
        {
            Car newCar = new Car();
            newCar.car = '@';
            newCar.color = ConsoleColor.Blue;
            newCar.x = 4;
            newCar.y = 10;

            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 30;
            int i = 0;
            int j = 3;
            int k = 4;
            var random = new Random(); 
            while (true)
            {
           

                if (i <= 19)
                {
                     positonCar(j,i++,'B');
                    positonCar(k, i, 'V',ConsoleColor.Green);
                    if (i == 19)
                    {
                        i = 0;
                        j = random.Next(10);

                    }
                }

               // positonCar(random.Next(0,10),random.Next(0,10),'B'); 
                positonCar(newCar.x, newCar.y, newCar.car, newCar.color);
                Thread.Sleep(200);
                Console.Clear();


            }
        }
        static void positonCar(int x, int y, char car, ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.SetCursorPosition(x,y);
            Console.ForegroundColor = color;
            Console.Write(car);
        }
    }
}
