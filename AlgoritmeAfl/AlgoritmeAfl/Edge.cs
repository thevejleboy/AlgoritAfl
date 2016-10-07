using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    public class Edge
    {
       
        private Cell from; 

        private Cell to; 


        public Cell To
        {
            get { return to; }
            set { to = value; }
        }

        public Cell From
        {
            get { return from; }
            set { from = value; }
        }

        public Edge(Cell From, Cell To)
        {
            from = From;
            to = To;
        }
    }
}
