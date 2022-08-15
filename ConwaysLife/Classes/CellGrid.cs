using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysLife.Classes
{
    // This class contains the logic of all the cells, as well as setting the grid structure.
    class CellGrid
    {
        // GridWidth (currently set to 1000) = CellSize * GridRows
        // GridHeight (currently set to 500) = CellSize * GridColumns
        public int GridRows;
        public int GridColumns;
        public double InitialCellPercentage;
        public int CellSize;

        public bool[,] cells1; // cells1 decides what shows up on the grid.
        public bool[,] cells2; // cells2 is the state of the next grid.

        public CellGrid(int gridRows, int gridColumns, double initialCellPercentage, int cellSize)
        { // Setup initial grid by randomizing.
            GridRows = gridRows;
            GridColumns = gridColumns;
            InitialCellPercentage = initialCellPercentage;
            CellSize = cellSize;

            cells1 = new bool[GridRows, GridColumns];
            cells2 = new bool[GridRows, GridColumns];

            Random rand = new Random();

            for (int i = 0; i < GridRows; i++)
            {
                for (int j = 0; j < GridColumns; j++)
                {
                    cells1[i, j] = rand.NextDouble() < InitialCellPercentage;
                    cells2[i, j] = false;
                }
            }
        }

        private int GetNeighborCount(bool[,] cells, int x, int y)
        {
            // These if statements prevent index out of bounds.
            // x represents rows, y represents columns.
            int x1 = (x > 0) ? x - 1 : x;
            int x2 = (x < GridRows - 1) ? x + 1 : x;
            int y1 = (y > 0) ? y - 1 : y;
            int y2 = (y < GridColumns - 1) ? y + 1 : y;

            int count = 0;

            for (int i = x1; i <= x2; i++) // Check the 3x3 area surrounding an area.
            {
                for (int j = y1; j<=y2; j++)
                {
                    count += (cells[i, j]) ? 1 : 0;
                }
            }
            if(cells[x,y])
            {
                count--;
            }
            return count;
        }

        public void Advance() // Changes to the next state of the grid.
        {
            bool[,] cells = cells1;
            for (int i = 0; i < GridRows; i++) // Check every cell in a Row * Column area.
            {
                for (int j = 0; j < GridColumns; j++)
                {
                    cells2[i, j] = cells[i, j]; // Copy the current state of cell1, to ensure that a cell doesn't just disappear for no reason.
                    int count = GetNeighborCount(cells, i, j);
                    if (count == 3) // If this spot has 3 cell neighbors, a cell is spawned.
                    {
                        cells2[i, j] = true;
                    }
                    if (count < 2 || count > 3) // If a cell ahs less than 2 or more than 3 cell neighbors, the cell dies.
                    {
                        cells2[i, j] = false;
                    }
                }
            }

            cells1 = cells2; // cells2 becomes the new current state.
            cells2 = cells; // Preserve previous state in cell2.
        }
    }
}
