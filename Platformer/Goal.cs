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
        public Goal(int x, int y, Bitmap background) : base (x,y,background)
        {
            typeOfPhysicalObject = "Goal";
        }
        
    }
}
