using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Coin : PhysicalObject
    {
        public Coin(int x, int y, int h, int w, Bitmap background) : base (x,y,h,w,background)
        {
            typeOfPhysicalObject = "Coin";
        }
        public Coin(int x, int y, int h, int w, Color backgroundcolor) : base(x, y, h, w, backgroundcolor)
        {
            typeOfPhysicalObject = "Coin";
        }
    }
}
