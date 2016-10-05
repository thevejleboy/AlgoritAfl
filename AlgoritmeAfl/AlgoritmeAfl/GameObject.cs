using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    class GameObject
    {
        Image sprite;

        PointF position;
        float scaleFactor;

        public GameObject(string imagePath, PointF startposition, float scaleFactor)
        {
            this.scaleFactor = scaleFactor;
        }



        public void Draw(Graphics dc)
        {
            dc.DrawImage(sprite, position.X, position.Y, sprite.Width * scaleFactor, sprite.Height * scaleFactor);
        }
    }
}
