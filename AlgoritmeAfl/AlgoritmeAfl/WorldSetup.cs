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

        List<GameObject> gameObject = new List<GameObject>();

        public List<GameObject> CreateWorld()
        {

            gameObject.Add(new Wall(new Point(350, 400), "wall"));
            gameObject.Add(new Wall(new Point(400, 400), "wall"));
            gameObject.Add(new Wall(new Point(350, 300), "wall"));
            gameObject.Add(new Wall(new Point(400, 300), "wall"));
            gameObject.Add(new Wall(new Point(350, 200), "wall"));
            gameObject.Add(new Wall(new Point(400, 200), "wall"));
            gameObject.Add(new Wall(new Point(350, 150), "wall"));
            gameObject.Add(new Wall(new Point(400, 150), "wall"));
            gameObject.Add(new Wall(new Point(350, 350), "wall"));
            gameObject.Add(new Wall(new Point(400, 350), "wall"));
            gameObject.Add(new Key(new Point(150, 150), "Key2"));
            gameObject.Add(new Key(new Point(600, 600), "Key1"));
            gameObject.Add(new Tree(new Point(300, 500), "tree"));
            gameObject.Add(new Tree(new Point(500, 500), "tree"));
            gameObject.Add(new Tree(new Point(350, 500), "tree"));
            gameObject.Add(new Tree(new Point(400, 500), "tree"));
            gameObject.Add(new Tree(new Point(300, 550), "tree"));
            gameObject.Add(new Tree(new Point(500, 550), "tree"));
            gameObject.Add(new Tree(new Point(350, 550), "tree"));
            gameObject.Add(new Tree(new Point(400, 550), "tree"));
            gameObject.Add(new Tree(new Point(300, 700), "tree"));
            gameObject.Add(new Tree(new Point(500, 700), "tree"));
            gameObject.Add(new Tree(new Point(350, 700), "tree"));
            gameObject.Add(new Tree(new Point(400, 700), "tree"));
            gameObject.Add(new Tree(new Point(300, 750), "tree"));
            gameObject.Add(new Tree(new Point(500, 750), "tree"));
            gameObject.Add(new Tree(new Point(350, 750), "tree"));
            gameObject.Add(new Tree(new Point(400, 750), "tree"));
            gameObject.Add(new Tower(new Point(50, 50), "Tower1"));
            gameObject.Add(new Tower(new Point(700, 700), "Tower2"));

            return gameObject;
        }


    }
}
