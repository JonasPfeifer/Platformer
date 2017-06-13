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
        Bitmap CroppedImage;
        int groundcount=1;
        public Ground(int x, int y, Bitmap background) : base(x, y, background)
        {
            typeOfPhysicalObject = "Ground";
        }
        
        public override void draw(Graphics g,int playermovementtox)
        {
            if(0 > groundcount - playermovementtox)
            {
                groundcount = 1;
            }
            else
            {
                groundcount -= playermovementtox;
                
            }
           //groundcount -= playermovementtox;
            CroppedImage = background.Clone(new System.Drawing.Rectangle(groundcount, 0,790, 108), background.PixelFormat);
            g.DrawImage(CroppedImage, 0 , y,790,108);
            
        }
    }
}
