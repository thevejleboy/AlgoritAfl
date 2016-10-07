using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmeAfl
{
    class Key:GameObject
    {
        public Point Position { get; set; }

        public string KeyName { get; set; }

        public Key(Point position, string keyName): base(position, keyName)
        {

            this.Position = position;;
            KeyName = keyName;


        }
    }
}
