using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    public class GridManager
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

            cellRowCount = 12;

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

           // worldSetup.CreateScene();
            backBuffer.Render();
        }

        //Creates Grid
        public void CreateGrid()
        {
            grid= new List<Cell>();

            int cellSize = displayRectangle.Width/cellRowCount;

            //Creates Cells
            for (int x = 0;x < cellRowCount; x++)
            {
                for (int y = 0; y < cellRowCount; y++)
                {
                    grid.Add(new Cell(new Point(x, y), cellSize));
                }
            }
        }
   
        public void CellSpot(Point position, string clickType)
        {
            foreach (Cell cell in grid) //Finds the cell that we just clicked
            {
                if (cell.BoundingRectangle.IntersectsWith(new Rectangle(position, new Size(1, 1))))
                {
                    cell.ChooseCell(clickType);
                }

            }
        }

    }
}
