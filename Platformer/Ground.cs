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
        ScrollingTexture backgroundScrolling;
        public Ground(int x, int y, Bitmap background) : base(x, y, background)
        {
            typeOfPhysicalObject = "Ground";
            backgroundScrolling = new ScrollingTexture(background);
        }
        
        public override void draw(Graphics g,int playermovementtox)
        {
            
            g.DrawImage(backgroundScrolling.getImageAtOffsetLocation(playermovementtox), 0 , y,790,108);
            
        }
    }
}
