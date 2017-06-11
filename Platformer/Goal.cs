using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Goal : PhysicalObject
    {
        public Goal(int x, int y, int h, int w, Bitmap background) : base (x,y,h,w,background)
        {
            typeOfPhysicalObject = "Goal";
        }
        public Goal(int x, int y, int h, int w, Color backgroundcolor) : base(x, y, h, w, backgroundcolor)
        {
            typeOfPhysicalObject = "Goal";
        }
    }
}
