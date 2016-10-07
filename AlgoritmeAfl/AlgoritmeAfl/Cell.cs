using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    
    public class Cell
    {
        private Point position;
        private int cellSize;
        private Image sprite;
        private string name;
        private Cell parent;
        private bool visited = false;
        private List<Edge> myEdge = new List<Edge>();


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
        public bool Visited
        {
            get
            {
                return visited;
            }

            set
            {
                visited = value;
            }
        }
        public List<Edge> MyEdge
        {
            get
            {
                return myEdge;
            }

            set
            {
                myEdge = value;
            }
        }




        public Cell(Point position, int size, string name)
        {
            this.position = position;
            this.cellSize = size;
            this.name = name;
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
            if (cellType == "TOWER")
            {
                sprite = Image.FromFile(@"Images\tower2.png");

            }
            if (cellType == "KEY")
            {
                sprite = Image.FromFile(@"Images\key.png");

            }
            if (cellType == "WIZARD")
            {
                sprite = Image.FromFile(@"Images\Bound_Wizard.png");

            }
            if (cellType == "TREE")
            {
                sprite = Image.FromFile(@"Images\Tree.png");

            }
            if (cellType == "PORTAL")
            {
                sprite = Image.FromFile(@"Images\Portal.png");

            }
            if (cellType == "WALKED")
            {
                sprite = Image.FromFile(@"Images\Portal.png");

            }
        }

        
    }
}
