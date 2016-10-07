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



        }
        public List<Wall> CreateWalls()
        {
            List<Wall> walls = new List<Wall>();
            walls.Add(new Wall(new Point(350, 400), "wall"));
            walls.Add(new Wall(new Point(400, 400), "wall"));
            walls.Add(new Wall(new Point(350, 300), "wall"));
            walls.Add(new Wall(new Point(400, 300), "wall"));
            walls.Add(new Wall(new Point(350, 200), "wall"));
            walls.Add(new Wall(new Point(400, 200), "wall"));
            walls.Add(new Wall(new Point(350, 150), "wall"));
            walls.Add(new Wall(new Point(400, 150), "wall"));
            walls.Add(new Wall(new Point(350, 350), "wall"));
            walls.Add(new Wall(new Point(400, 350), "wall"));

            return walls;
        }
        public List<Tower> CreateTowers()
        {
            List<Tower> towers = new List<Tower>();
            towers.Add(new Tower(new Point(50, 50), 2));
            towers.Add(new Tower(new Point(700, 700), 1));

            return towers;
        }
        public List<Key> CreateKeys()
        {
            List<Key> Key = new List<Key>();
            Key.Add(new Key(new Point(150, 150), 2));
            Key.Add(new Key(new Point(600, 600), 1));

            return Key;
        }
        public List<Tree> CreateTrees()
        {
            List<Tree> tree = new List<Tree>();
            tree.Add(new Tree(new Point(300, 500)));
            tree.Add(new Tree(new Point(500, 500)));
            tree.Add(new Tree(new Point(350, 500)));
            tree.Add(new Tree(new Point(400, 500)));
            tree.Add(new Tree(new Point(300, 550)));
            tree.Add(new Tree(new Point(500, 550)));
            tree.Add(new Tree(new Point(350, 550)));
            tree.Add(new Tree(new Point(400, 550)));
            tree.Add(new Tree(new Point(300, 700)));
            tree.Add(new Tree(new Point(500, 700)));
            tree.Add(new Tree(new Point(350, 700)));
            tree.Add(new Tree(new Point(400, 700)));
            tree.Add(new Tree(new Point(300, 750)));
            tree.Add(new Tree(new Point(500, 750)));
            tree.Add(new Tree(new Point(350, 750)));
            tree.Add(new Tree(new Point(400, 750)));


            return tree;
        }



    }
}
