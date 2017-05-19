using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin1
{
    class point
    {
        float x;
        float y;
        SolidBrush myBrush = new SolidBrush(Color.Red);
        public point(float x,float y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw(Graphics g)
        {
            y =100*(float)Math.Cos(Math.PI * x / 180.0) +100;
            g.FillEllipse(myBrush, new RectangleF(x,y, 5, 5));
        }
        
    }
}
