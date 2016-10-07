using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmeAfl
{
    public partial class Form1 : Form
    {
        private GridManager visualManager;
        string destination;

        public Form1()
        {
            InitializeComponent();

            ClientSize = new Size(800,800);
            
            visualManager = new GridManager(CreateGraphics(),this.DisplayRectangle);
            



        }


        private void Loop_Tick(object sender, EventArgs e)
        {
            visualManager.Render();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            WorldSetup worldSetup = new WorldSetup();
            foreach (GameObject wall in worldSetup.CreateWorld())
            {
                if (wall is Wall) { visualManager.CellSpot(wall.Position, "WALL"); }
                
            }
            foreach (GameObject tower in worldSetup.CreateWorld())
            {
                if (tower is Tower) { visualManager.CellSpot(tower.Position, "TOWER"); }
            }
            foreach (GameObject key in worldSetup.CreateWorld())
            {
                if (key is Key) { visualManager.CellSpot(key.Position, "KEY"); }
               
            }
            foreach (GameObject tree in worldSetup.CreateWorld())
            {
                if (tree is Tree) { visualManager.CellSpot(tree.Position, "TREE"); }
            }
            visualManager.CellSpot(new Point(150, 600), "WIZARD");
            visualManager.CellSpot(new Point(100, 600), "PORTAL");
            destination = "Key1";
            Cell goal = DFS<string>(visualManager.GridList, destination); //Finds the destination with DFS
            Console.WriteLine("\nDFS WITH Edges");
            TrackPath<string>(goal, visualManager.GridList[0]);

        }
        private Cell DFS<T>(List<Cell> cells, T goal)
        {

            Stack<Cell> stack = new Stack<Cell>();

            Cell currentCell = cells[0];

            stack.Push(currentCell);

            while (stack.Count > 0)
            {
                currentCell = stack.Pop();

                if (currentCell.Name.Equals(goal))
                {
                    return currentCell;
                }
                if (!currentCell.Visited)
                {
                    currentCell.Visited = true;

                    foreach (Edge e in currentCell.MyEdge)
                    {

                        if (!e.To.Visited)
                        {
                            e.To.Parent = currentCell;
                            stack.Push(e.To);
                        }
                    }
                }
            }

            return null;
        }
        private List<Cell> TrackPath<T>(Cell cell, Cell start)
        {
            List<Cell> path = new List<Cell>();

            while (!cell.Equals(start))
            {
                path.Add(cell);
                cell = cell.Parent;
            }
            path.Add(start);

            path.Reverse();

            foreach (Cell pathCell in path)
            {
                pathCell.ChooseCell("WALKED");

            }

            return path;
        }
    }
}
