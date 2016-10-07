using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmeAfl
{
    class Tower
    {
        public Point Position { get; set; }
        public int Key { get; set; }

        public Tower(Point position, int key)
        {

            this.Position = position;
            this.Key = key;
        }
    }
}
