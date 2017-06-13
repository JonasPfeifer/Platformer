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
        }
        public String gettypeOfPhysicalObject()
        {
            return typeOfPhysicalObject;
        }
        public virtual void draw(Graphics g, int playermovementtox)
        {
            this.offsetx -= playermovementtox;
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            g.DrawRectangle(myPen, new Rectangle(x - offsetx, y, w, h));
            myPen.Dispose();
            g.DrawImage(background, x - offsetx, y);
            //g.DrawImage(background, x , y);
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
            //return x + offsetx;
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
            return y + (h / 2);
        }
        public int gettop()
        {
            return y - (h / 2);
        }
        public int getleft()
        {
            return (x - offsetx) - (w / 2);
            //return x - (w / 2);
        }
        public int getright()
        {
            return (x -  offsetx) + (w / 2);
            //return x + (w / 2);
        }
    }
}
