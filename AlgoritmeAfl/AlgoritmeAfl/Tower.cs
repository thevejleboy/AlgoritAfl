using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmeAfl
{
    class Tower : GameObject
    {
        public Point Position { get; set; }
        private string name;

        public Tower(Point position, string name) : base(position, name)
        {

            this.Position = position;
            this.name = name;
        }
    }
}
