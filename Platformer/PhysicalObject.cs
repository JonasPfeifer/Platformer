using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Platformer
{
    class PhysicalObject
    {
        public String typeOfPhysicalObject = "PhysicalObject";
        public int x, y, w, h , offsetx;
        public Bitmap background;
        public System.Drawing.Color backgroundcolor;
        public PhysicalObject(int x, int y, Bitmap background)
        {
            this.x = x;
            this.y = y;
            this.background = background;
            this.w = background.Width;
            this.h = background.Height;
            this.offsetx = x;
        }
		public PhysicalObject(int x, int y,int w,int h , Bitmap background)
		{
			this.x = x;
			this.y = y;
			this.background = background;
			this.w = w;
			this.h = h;
			this.offsetx = x;
		}

		public String gettypeOfPhysicalObject()
        {
            return typeOfPhysicalObject;
        }
        public virtual void draw(Graphics g, int playermovementtox)
        {
            if (playermovementtox != 0)
            {
                x += playermovementtox;
            }
            
            g.DrawImage(background, x, y);
        }
        public Bitmap getBackground()
        {
            return background;
        }
        public void setx(int x)
        {
            this.x = x;
        }
        public int getx()
        {
            return x ;
        }
        public void sety(int y)
        {
            this.y = y;
        }
        public int gety()
        {
            return y;
        }
        public void seth(int h)
        {
            this.h = h;
        }
        public int geth()
        {
            return h;
        }
        public void setw(int w)
        {
            this.w = w;
        }
        public int getw()
        {
            return w;
        }
        public int getbottom()
        {
            return y +h ;
        }
        public int gettop()
        {
            return y ;
        }
        public int getleft()
        {
            return x;
        }
        public int getright()
        {
            return x + w;
        }
    }
}
