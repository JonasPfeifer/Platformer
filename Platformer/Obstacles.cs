using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Obstacles : PhysicalObject
    {
        public Obstacles(int x, int y, int h, int w, Bitmap background) : base (x,y,h,w,background)
        {
            typeOfPhysicalObject = "Obstacles";
        }
        public Obstacles(int x, int y, int h, int w, Color backgroundcolor) : base(x, y, h, w, backgroundcolor)
        {
            typeOfPhysicalObject = "Obstacles";
        }
    }
}
