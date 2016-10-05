using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmeAfl
{
    class WorldSetup
    {

        private Graphics dc;
        private static List<GameObject> objects;
        public static List<GameObject> Objects
        {
            get { return objects; }
            set { objects = value; }
        }
        public WorldSetup(Graphics dc)
        {
            objects = new List<GameObject>();

        }
        public void CreateScene()
        {
            Wall wall1 = new Wall();
            Draw();
        }
        private void Draw()
        {
            foreach (GameObject objects1 in objects)
            {
                objects1.Draw(dc);
            }
        }
    }
}
