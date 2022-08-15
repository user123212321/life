using ConwaysLife.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwaysLife
{
    public partial class Form1 : Form
    {
        CellGrid grid = new CellGrid(100, 50, 0.2, 10);

        public Form1()
        {
            InitializeComponent();
            Render();
        }

        private void ResetGrid()
        {
            grid = new CellGrid(100, 50, (double)numericUpDownInitialCellPercentage.Value * 0.01, 10);
        }

        private void Render()
        {
            using (Bitmap bmp = new Bitmap(1000, 500))
            using (Graphics gfx = Graphics.FromImage(bmp))
            using (SolidBrush cellBrush = new SolidBrush(Color.DeepSkyBlue))
            {
                gfx.Clear(Color.Black);

                // Adds separation in between the cells, by shaving off 1 pixel.
                Size cellSize = (grid.CellSize > 1) ? 
                    new Size(grid.CellSize - 1, grid.CellSize - 1) : 
                    new Size(grid.CellSize, grid.CellSize);

                for (int rendCol = 0; rendCol < grid.GridColumns; rendCol++)
                {
                    for (int rendRow = 0; rendRow < grid.GridRows; rendRow++)
                    {
                        bool cell = grid.cells1[rendRow, rendCol];
                        if (cell)
                        {
                            Point cellLocation = new Point(rendRow * grid.CellSize, rendCol * grid.CellSize);
                            Rectangle cellRect = new Rectangle(cellLocation, cellSize);
                            gfx.FillRectangle(cellBrush, cellRect);
                        }
                    }
                }
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }
        }

        private void CellTimer_Tick(object sender, EventArgs e)
        {
            grid.Advance();
            Render();
        }

        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            CellTimer.Interval = (int)numericUpDownSpeed.Value;
        }

        private void buttonPauseResume_MouseClick(object sender, MouseEventArgs e)
        {
            if (buttonPauseResume.Text.Equals("Pause"))
            {
                CellTimer.Enabled = false;
                buttonPauseResume.Text = "Resume";
            } else
            {
                CellTimer.Enabled = true;
                buttonPauseResume.Text = "Pause";
            }
        }

        private void buttonReset_MouseClick(object sender, MouseEventArgs e)
        {
            ResetGrid();
            Render();
        }
    }
}
