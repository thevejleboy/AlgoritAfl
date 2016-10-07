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
        WorldSetup worldSetup = new WorldSetup();

        public List<Cell> GridList { get; set; }
        public static string Name { get; set; }


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

            foreach (Cell cell in GridList)
            {
                cell.Render(dc);
            }

           // worldSetup.CreateScene();
            backBuffer.Render();
        }

        //Creates Grid
        public void CreateGrid()
        {
            GridList = new List<Cell>();

            int cellSize = displayRectangle.Width/cellRowCount;

            //Creates Cells
            for (int x = 0;x < cellRowCount; x++)
            {
                for (int y = 0; y < cellRowCount; y++)
                {
                    GridList.Add(new Cell(new Point(x, y), cellSize, Name));
                }
            }
        }
   
        public void CellSpot(Point position, string clickType)
        {
            foreach (Cell cell in GridList) //Finds the cell that we just clicked
            {
                if (cell.BoundingRectangle.IntersectsWith(new Rectangle(position, new Size(1, 1))))
                {
                    cell.ChooseCell(clickType);
                }

            }
        }
        public string Destination()
        {
            string des = "";
            if (des == "")
            {
                des = "Key1";
            }


            return des;

        }

    }
}
