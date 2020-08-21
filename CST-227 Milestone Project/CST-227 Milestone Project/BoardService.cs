using System;

namespace CST_227_Milestone_Project
{
    public class BoardService
    {
        public Board b;

        //public int xSize { get; private set; }

        public BoardService(Board gameBoard)
        {
            b = gameBoard;
        }

        //method to activate random percentage of cells to become live
        public void populateBoardWithBombs()
        {

        }


        public void countBombsNearCells()
        {
            //create a random percentage between 15-20 % to create live cells 
            Random rand = new Random();
            double percent = rand.Next(15, 20);
            percent = percent / 100;

            //find the complete cell count 
            double numOfCells = b.xSize * b.xSize;

            //find the number of cells that will be live 
            double ranCount = Math.Round(numOfCells * percent, 0);

            //create an array of ints to hold the number of random live cells 
            int[] ranLive = new int[Convert.ToInt32(ranCount)];

            //print test
            Console.WriteLine("number of live cells is " + ranCount);
        }

        public void printBoard()
        {
            for (int i = 0; i < b.xSize; i++)
            {
                for (int j = 0; j < b.xSize; j++)
                {
                    Cell c = b.Grid[i, j];
                    if (c.isBomb == true)
                    {
                        Console.Write("*");
                    }
                    else if (c.isBomb == true)
                    {
                        Console.Write("{0}");

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            populateBoardWithBombs();
        }
    }
}
