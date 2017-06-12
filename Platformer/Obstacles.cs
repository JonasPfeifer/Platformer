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
        public Obstacles(int x, int y, Bitmap background) : base (x,y,background)
        {
            typeOfPhysicalObject = "Obstacles";
            this.backgroundcolor = System.Drawing.Color.Transparent;
        }
    }
}
