using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmeAfl
{
    class Key
    {
        public Point Position { get; set; }
        public int KeyType { get; set; }

        public Key(Point position, int keyType)
        {

            this.Position = position;
            this.KeyType = keyType;

        }
    }
}
