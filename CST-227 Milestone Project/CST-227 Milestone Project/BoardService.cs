using System;

namespace CST_227_Milestone_Project
{
    public class BoardService
    {
        public Board b;
        
        public BoardService(Board gameBoard)
        {
            b = gameBoard;
        }

        public void populateBoardWithBombs()
        {
            // code here to add bombs
        }

        public void countBombsNearCells()
        {
            // code here to count bombs near cells
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
        }
    }
}
