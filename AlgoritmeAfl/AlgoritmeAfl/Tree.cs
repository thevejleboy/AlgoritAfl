﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmeAfl
{
    class Tree : GameObject
    {
        string name;
        private Point position;
        public Tree(Point position, string name) : base(position,name)
        {
            this.position = position;
            this.name = name;
        }
    }
}
