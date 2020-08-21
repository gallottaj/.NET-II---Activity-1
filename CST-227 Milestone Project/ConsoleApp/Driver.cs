﻿using CST_227_Milestone_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public class Driver
	{
		public static void Main(string[] args)
		{
			//Request input
			Console.Write("What size is your grid? ");

			//Get the input
			string input = Console.ReadLine();
			int num = -1;

			//Check to make sure the input is a number
			while (!int.TryParse(input, out num))
			{
				Console.Write("Please only enter numbers.");
				input = Console.ReadLine();
				num = -1;
			}

			//Convert input to double 
			double grid = Convert.ToDouble(input);
			Grid Grid1 = new Grid(Convert.ToInt32(grid));

			// For each Cell in the Square
			for (int i = 0; i < Grid1.square.GetLength(0); i++)
			{
				// Create counter for number of Cells in row
				int counter = 0;
				for (int j = 0; j < Grid1.square.GetLength(0); j++)
				{
					counter++;
					// If not last cell in row
					if (counter < Grid1.square.GetLength(0))
					{
						bool val = Grid1.square[i, j].getLive();
						if (val)
						{
							Console.Write("*");
						}
						else
						{
							Console.Write("{0}", Grid1.square[i, j].getNeighbors());
						}
					}
					// If last cell in row Writeline to start new row
					else
					{
						bool val = Grid1.square[i, j].getLive();
						if (val)
						{
							Console.WriteLine("*");
						}
						else
						{
							Console.WriteLine("{0}", Grid1.square[i, j].getNeighbors());
						}
					}
				}
			}

			Console.ReadLine();
		}
	}
}