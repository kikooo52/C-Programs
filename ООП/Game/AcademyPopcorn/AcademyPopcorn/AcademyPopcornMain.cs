using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
   public class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 2;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow+1, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow + 2, i));

                engine.AddObject(currBlock);
            }


            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 35),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Ball twoBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
               new MatrixCoords(-1, 1));

            engine.AddObject(twoBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 2, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

           
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock wallLeft = new IndestructibleBlock(new MatrixCoords(row,0));
                engine.AddObject(wallLeft);
                IndestructibleBlock wallRight = new IndestructibleBlock(new MatrixCoords(row, WorldCols-1));
                engine.AddObject(wallRight);
               
            }
            for (int col = 0; col < WorldCols; col++)
            {
                IndestructibleBlock wallDown = new IndestructibleBlock(new MatrixCoords(WorldRows - 1, col));
                engine.AddObject(wallDown);
                IndestructibleBlock wallUp = new IndestructibleBlock(new MatrixCoords(startRow-2, col));
                engine.AddObject(wallUp);
            }
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
