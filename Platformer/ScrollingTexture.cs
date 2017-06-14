using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
   
    class ScrollingTexture
    {
        Bitmap background;
        int offsetx = 1;

        public ScrollingTexture(Bitmap background)
        {
            this.background = background;
        }

        public Bitmap getImageAtOffsetLocation( int newoffset)
        {
            
            if (0 > offsetx - newoffset || (offsetx - newoffset) + 790 > background.Width-1)
            {
                offsetx = 1;
            }
            else
            {
                offsetx -= newoffset;

            }
            return background.Clone(new System.Drawing.Rectangle(offsetx, 0,790, 304), background.PixelFormat);
        }
    }

    
}
