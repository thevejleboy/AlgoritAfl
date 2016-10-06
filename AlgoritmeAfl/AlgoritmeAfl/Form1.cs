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
            foreach (Wall wall in worldSetup.CreateWalls())
            {
                visualManager.CellSpot(wall.Position, "WALL");
            }
            foreach (Tower tower in worldSetup.CreateTowers())
            {
                visualManager.CellSpot(tower.Position, "TOWER");
            }
            foreach (Key key in worldSetup.CreateKeys())
            {
                visualManager.CellSpot(key.Position, "KEY");
            }
            foreach (Tree tree in worldSetup.CreateTrees())
            {
                visualManager.CellSpot(tree.Position, "TREE");
            }
            visualManager.CellSpot(new Point(150, 600), "WIZARD");
            visualManager.CellSpot(new Point(100, 600), "PORTAL");

        }
    }
}
