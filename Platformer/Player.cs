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
        public Player(int x, int y, Bitmap background) : base (x,y,background)
        {
            typeOfPhysicalObject = "Player";
            
        }
        public void draw(Graphics g)
        {

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            g.DrawRectangle(myPen, new Rectangle(x, y, w, h));
            myPen.Dispose();
            g.DrawImage(background, x, y);
        }
       
    }
}
