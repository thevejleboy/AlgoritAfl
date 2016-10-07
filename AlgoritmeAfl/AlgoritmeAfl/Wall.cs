using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    class Wall
    {

        public Point Position { get; set; }
        public string Name { get; set; }

        public Wall(Point position, string name) 
        {
            this.Name = name;
            this.Position = position;
            
        }
    }
}
