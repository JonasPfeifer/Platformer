using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Player : PhysicalObject
    {
        public Player(int x, int y, int h, int w, Bitmap background) : base (x,y,h,w,background)
        {
            typeOfPhysicalObject = "Player";
        }
        public Player(int x, int y, int h, int w, Color backgroundcolor) : base(x, y, h, w, backgroundcolor)
        {
            typeOfPhysicalObject = "Player";
        }
        public Player(int x, int y, int h, int w) : base(x, y, h, w)
        {
            typeOfPhysicalObject = "Player";
        }
    }
}
