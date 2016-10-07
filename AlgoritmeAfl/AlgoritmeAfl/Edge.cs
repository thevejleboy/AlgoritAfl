using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    class Edge
    {
       
        private Point from; 

        private Point to; 


        public Point To
        {
            get { return to; }
            set { to = value; }
        }

        public Point From
        {
            get { return from; }
            set { from = value; }
        }

        public Edge(Point From, Point To)
        {
            from = From;
            to = To;
        }
    }
}
