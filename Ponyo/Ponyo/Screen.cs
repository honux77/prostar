using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
namespace Ponyo
{
    public class Screen
    {
        private int Width;
        private int Height;
        private Bitmap b;
        public Graphics graphics;

        public Screen(int w, int h)
        {
            Width = w;
            Height = h;
            b = new Bitmap(w, h);
            graphics = Graphics.FromImage(b);
        }

        public void draw(Graphics g)
        {
            g.DrawImage(b, 0, 0);
        }
    }
}
