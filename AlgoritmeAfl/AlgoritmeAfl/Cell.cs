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
        private string name;
        private Cell parent;

        public Rectangle BoundingRectangle
        {
            get
            {
                return new Rectangle(position.X*cellSize,position.Y*cellSize,cellSize,cellSize);
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        internal Cell Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public Cell(Point position, int size, string name)
        {
            this.position = position;
            this.cellSize = size;
            this.name = Name;
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
