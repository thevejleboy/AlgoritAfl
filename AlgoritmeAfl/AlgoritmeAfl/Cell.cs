using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    
    class Cell
    {
        private Point position;
        private int cellSize;
        private Image sprite;

        public Rectangle BoundingRectangle
        {
            get
            {
                return new Rectangle(position.X*cellSize,position.Y*cellSize,cellSize,cellSize);
            }
        }

        public Cell(Point position, int size)
        {
            this.position = position;
            this.cellSize = size;
        }

        public void Render(Graphics dc)
        {
            dc.FillRectangle(new SolidBrush(Color.White),BoundingRectangle );
            dc.DrawRectangle(new Pen(Color.Black),BoundingRectangle );
            if (sprite != null)
            {
                dc.DrawImage(sprite,BoundingRectangle);
            }

        }
        public void ChooseCell(string cellType)
        {
            if (cellType == "WALL")
            {
                sprite = Image.FromFile(@"Images\Wall.png");

            }
        }

        
    }
}
