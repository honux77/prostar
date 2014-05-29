using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ponyo
{
    public class Stage
    {
        public Screen scr;
        public int mx;
        public int my;
        public bool isClicked = false;
        public GObject cha;
        public long ms;

        private Bitmap bg;
        private DateTime old;
        public Stage(int w, int h)
        {
            scr = new Screen(w, h);
            bg = Properties.Resources.sea;
            cha = new GObject(w/2, h/2);
            cha.setImage(Properties.Resources.f1, 0);
            cha.setImage(Properties.Resources.f2, 1);
            cha.setImage(Properties.Resources.stop, 2);
            mx = w / 2;
            my = h / 2;
            old = DateTime.Now;
        }
        private void updateDelta()
        {
            TimeSpan d = DateTime.Now.Subtract(old);
            old = DateTime.Now;
            ms = d.Milliseconds;
        }
        public void update()
        {
            updateDelta();
            if (isClicked)
            {
                cha.setV(mx, my, 2000);
                isClicked = false;
            }
            cha.move((int)ms);

        }
        public void render(Graphics g)
        {
            scr.graphics.DrawImage(bg, 0, 0);
            cha.draw(scr.graphics);
            scr.draw(g);
        }
    }

    public class GObject
    {
        public GObject(int w, int h)
        {
            x = w;
            y = h;
        }
        const int n = 5; // max image
        public void setImage(Bitmap bmp, int n)
        {
            this.bmp[n] = bmp;
        }
        public Bitmap[] bmp = new Bitmap[n];
        public int x;
        public int y;
        public double dx;
        public double dy;
        public int fx, fy; //future loc
        public int period;

        public void draw(Graphics g)
        {
            if (period == 0)
            {
                draw(g, 2);
            }
            else if ((period / 250) % 2 == 0)
                draw(g, 0);
            else
                draw(g, 1);
        }
        public void draw(Graphics g, int n)
        {
            int dx = this.bmp[0].Width / 2;
            int dy = this.bmp[0].Height / 2;
            g.DrawImage(bmp[n], x - dx, y - dx);
        }

        public void setV(int x, int y, int msec)
        {
            fx = x;
            fy = y;
            if (msec <= 0)
            {
                stop();
                return;
            }
            dx = (double)(x - this.x) / msec;
            dy = (double)(y - this.y) / msec;
            period = msec;
        }
        public void stop()
        {
            dx = dy = 0;
            period = 0;
        }

        public void move(int ms)
        {
            x = x + (int)(dx * ms);
            y = y + (int)(dy * ms);
            period -= ms;
            setV(fx, fy, period);
        }


    }
}
