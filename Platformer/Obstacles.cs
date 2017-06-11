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
        public String typeOfPhysicalObject = "Obstacles";
        public Obstacles(int x, int y, int h, int w, Bitmap background) : base (x,y,h,w,background)
        {
            typeOfPhysicalObject = "Obstacles";
            this.backgroundcolor = System.Drawing.Color.Transparent;
        }
        public Obstacles(int x, int y, int h, int w, Color backgroundcolor) : base(x, y, h, w, backgroundcolor)
        {
            typeOfPhysicalObject = "Obstacles";
            this.backgroundcolor = System.Drawing.Color.Transparent;
        }
    }
}
