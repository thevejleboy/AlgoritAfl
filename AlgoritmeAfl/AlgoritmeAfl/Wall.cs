using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    class Wall:GameObject
    {
        string image;
        

        public Wall(string imagePath,PointF position, float scaleFactor) : base(imagePath, position, scaleFactor)
        {
            
        }
    }
}
