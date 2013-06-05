using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    struct Position
    {
        public int Row;
        public int  Col;
        public Position(int Row, int Col)
        {
            this.Row = Row;
            this.Col = Col;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position[] directions = new Position[]
            {
                new Position (0, 1),//right
                new Position (0, -1), // left
                new Position (1, 0), // down
                new Position (-1, 0),// top

            };
            int direction = 0; //0
            
            Queue<Position> snakeElement = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                 snakeElement.Enqueue(new Position(0, i));
            }

            foreach (Position position in snakeElement)
            {
                Console.SetCursorPosition(position.Col, position.Row);
                Console.Write("*");

            }
            

             
            while (true)
            {
                ConsoleKeyInfo userinput = Console.ReadKey();
                if (userinput.Key == ConsoleKey.LeftArrow)
                {
                    direction = 1;
                }
                if (userinput.Key == ConsoleKey.RightArrow)
                {
                    direction = 0;
                }
                if (userinput.Key == ConsoleKey.UpArrow)
                {
                    direction = 3;
                }
                if (userinput.Key == ConsoleKey.DownArrow)
                {
                    direction = 2;
                }

                snakeElement.Dequeue();

                Position snakeHead = snakeElement.Last();
                snakeElement.Dequeue();
                Position nextdirection  = directions[direction];
                Position smakenewhead = new Position(snakeHead.Row + nextdirection.Row, snakeHead.Col + nextdirection.Col);
                snakeElement.Enqueue(smakenewhead);

                foreach (Position position in snakeElement)
                {
                    Console.SetCursorPosition(position.Col, position.Row);
                    Console.Write("*");

                }

            }
        }
    }
}
