using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Player : PhysicalObject
    {
        private FrameDimension dim;
        private int frameCount;
        private int currentFrame = -1;
        private bool reverse;
        private int step = 1; 
        public Player(int x, int y,int w,int h, Bitmap background) : base (x,y,w,h,background)
        {
            typeOfPhysicalObject = "Player";
            dim = new FrameDimension(background.FrameDimensionsList[0]);
            frameCount = background.GetFrameCount(dim);
            //w = 48;
            //h = 64;
        }


		public bool ReverseAtEnd
        {
            get { return reverse; }
           set { reverse = value; }
        }

        public Image GetNextFrame()
        {
            currentFrame += step;
            if(currentFrame >= frameCount ||currentFrame < 1)
            {
                if (reverse)
                {
                    step *= 1;
                    currentFrame += step;
                } else
                {
                    currentFrame = 0;
                }
            }
            return GetFrame(currentFrame);
        }
        public Image GetFrame(int index)
        {
            background.SelectActiveFrame(dim, index);
            return (Image)background.Clone();
        }

        public void draw(Graphics g)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            g.DrawRectangle(myPen, new Rectangle(x, y, w, h));
            myPen.Dispose();
            //g.DrawImage(background, x, y);
            ReverseAtEnd = false;
            g.DrawImage(GetNextFrame(), x, y,w,h);
        }
       
    }
}
