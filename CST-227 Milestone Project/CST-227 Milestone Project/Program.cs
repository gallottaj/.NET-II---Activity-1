using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Joey Gallotta
//CST-227 Milestone Project

namespace CST_227_Milestone_Project
{
	class Program
	{
		//create instance of Board 
		static Board b = new Board(10);
        static BoardService boardService;

		public static void Main(string[] args)
		{
            //print empty game board
            boardService = new BoardService(b);
            boardService.printBoard();
		
            Console.ReadLine();
            //Call the Board.setupLiveNeighbors and Board.calculateLiveNeighbors commands to initialize the grid.
            //b.setupLiveNeighbors();

            //Call the printBoard method to display the contents of the grid.
        }

        public Cell setCell()
        {
            Console.WriteLine("enter row");
            int currentRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter current column");
            int currentColumn = int.Parse(Console.ReadLine());

            return b.Grid[currentRow, currentColumn];
        }


    }
}