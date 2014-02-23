using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
  class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;
            for (int col = 0; col <WorldCols; col++)
            {
                IndestructibleBlock wallLeftBlock = new IndestructibleBlock(new MatrixCoords(0,col));
                engine.AddObject(wallLeftBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                if (i == 7) //the seventh block is the first block, being hit by the ball
                {
                    currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
                }
                else if (i == endCol-3) //you'll have to wait a little bit to see hit that block with the gift 
                {
                    currBlock = new GiftBlock(new MatrixCoords(startRow, i));
                }
                engine.AddObject(currBlock);
                
            }
            //Add side walls
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock wallLeftBlock = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(wallLeftBlock);
                IndestructibleBlock wallRightBlock = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(wallRightBlock);
            }
            //trail object
            char[,] signOfTrail={{'*'}};
            TrailObject trail=new TrailObject(new MatrixCoords(13,13),signOfTrail,10);
            engine.AddObject(trail);


            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));
            //testing the meteorite ball
            MeteoriteBall secondBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));

            engine.AddObject(secondBall);
            //engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

           // adding an unpassable block and an unstoppable ball
            for (int i = 10; i < WorldRows; i++)
            {
                engine.AddObject(new UnpassableBlock(new MatrixCoords(i, 8)));
            }
            
            engine.AddObject(new UnstoppableBall(new MatrixCoords(WorldRows - 1, WorldCols / 2 + 1), new MatrixCoords(-1, 1)));


        }

       public static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            int sleepTime = 500;
            EngineForShootingRacket gameEngine = new EngineForShootingRacket(renderer, keyboard,sleepTime);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

          

            Initialize(gameEngine);

          

            gameEngine.Run();
        }
    }
}
