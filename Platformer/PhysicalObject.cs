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
        public int x, y, w, h;
        public Bitmap background;
        public System.Drawing.Color backgroundcolor;
        public PhysicalObject(int x, int y, int h, int w, Bitmap background)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.background = background;
        }
        public PhysicalObject(int x, int y, int h, int w, Color backgroundcolor)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.backgroundcolor = backgroundcolor;
        }
        public PhysicalObject(int x, int y, int h, int w)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public String gettypeOfPhysicalObject()
        {
            return typeOfPhysicalObject;
        }
        public void draw(Graphics g, int offsetx)
        {
            g.DrawImage(background, x - offsetx, y);
        }
        public void setx(int x)
        {
            this.x = x;
        }
        public int getx()
        {
            return x;
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
            return y - (h / 2);
        }
        public int gettop()
        {
            return y + (h / 2);
        }
        public int getleft()
        {
            return x - (w / 2);
        }
        public int getright()
        {
            return y + (w / 2);
        }
    }
}
