using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Platformer
{
    class PhysicalObject : System.Windows.Forms.Panel
    {
        public String typeOfPhysicalObject= "PhysicalObject";
        public PhysicalObject(int x, int y, int h, int w, Bitmap background)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(w, h);
            this.BackgroundImage = background;
        }
        public PhysicalObject(int x, int y, int h, int w, Color backgroundcolor)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(w, h);
            this.BackColor = backgroundcolor;
        }
        public PhysicalObject(int x, int y, int h, int w)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(w, h);
        }
        public String gettypeOfPhysicalObject()
        {
            return typeOfPhysicalObject;
        }
    }
}
