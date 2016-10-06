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

       
        public WorldSetup()
        {
            CreateScene();

        }
        public List<Wall> CreateScene()
        {
            List<Wall> walls = new List<Wall>();
            walls.Add(new Wall(new Point(200,200)));
            walls.Add(new Wall(new Point(400,400)));

            return walls;
        }
    }
}
