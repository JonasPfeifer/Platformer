using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Ground : PhysicalObject
    {
        public Ground(int x, int y, int h, int w, Bitmap background) : base(x, y, h, w, background)
        {
            typeOfPhysicalObject = "Ground";
        }
        public Ground(int x, int y, int h, int w, Color backgroundcolor) : base(x, y, h, w, backgroundcolor)
        {
            typeOfPhysicalObject = "Ground";
        }
        public void draw(Graphics g)
        {
            g.DrawImage(background, x , y);

            /*
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            g.DrawRectangle(myPen, new Rectangle
            myPen.Dispose();
            */
        }
    }
}
