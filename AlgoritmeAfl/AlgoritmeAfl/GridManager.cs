using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    class GridManager
    {
        BufferedGraphics backBuffer;
        Graphics dc;
        Rectangle displayRectangle;

        // Number of rows
        int cellRowCount;

        private List<Cell> grid; 

        public GridManager(Graphics dc, Rectangle displayRectangle)
        {
            this.backBuffer = BufferedGraphicsManager.Current.Allocate(dc, displayRectangle);

            this.dc = backBuffer.Graphics;

            this.displayRectangle = displayRectangle;

            cellRowCount = 10;

            CreateGrid();
        }


        //Render Celler
        public void Render()
        {
            dc.Clear(Color.White);
            foreach (Cell cell in grid)
            {
                cell.Render(dc);
            }

            backBuffer.Render();
        }

        //Creates Grid
        public void CreateGrid()
        {
            grid= new List<Cell>();

            int cellSize = displayRectangle.Width/cellRowCount;

            //Creates Cells
            for (int x=0;x<cellRowCount;x++)
            {
                for (int y = 0; y < cellRowCount; y++)
                {
                    grid.Add(new Cell(new Point(x, y), cellSize));
                }
            }
        }

    }
}
