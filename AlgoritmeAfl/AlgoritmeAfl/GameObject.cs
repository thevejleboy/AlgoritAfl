using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmeAfl
{
    class GameObject
    {
        public Point Position { get; set; }
        string name;

        public GameObject(Point position, string name)
        {
            this.Position = position;
            this.name = name;
            GridManager.Name = this.name;
        }
    }
}
