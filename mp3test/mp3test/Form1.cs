using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WMPLib;

namespace mp3test
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        bool move; 

        int xpos = 400;
        int cx = 400;
        int delta;
        int idx = 0;
        public DateTime time;
        public Form1()
        {
            InitializeComponent();
            wmp.URL = @"Resources\mario.mp3";
            timer1.Interval = 30; //30ms 
            timer1.Enabled = true;
            time = DateTime.Now;
        }

        private void GameUpdate()
        {
            if (MouseButtons == MouseButtons.Left)
            {
                if (!move)
                {
                    move = true;
                    time = DateTime.Now;
                }
                if (xpos == 0 || xpos == 800 )
                    cx += delta;
                if (cx == 400)
                    xpos += delta;   

                if (cx < 10) cx = 10;
                else if (cx > 730) cx = 730;
                
            }
            else
                move = false;
            if (xpos < 0)
                xpos = 0;
            else if (xpos > 800)
                xpos = 800;
        }

        private void Render()
        {
            TimeSpan t = DateTime.Now.Subtract(time);
            if (move)
            {
                
                idx = t.Milliseconds / 100 % 7;
            }              
            else idx = 0;

            Graphics g = this.CreateGraphics();
            Bitmap b1 = Properties.Resources.back1;
            Bitmap b2 = Properties.Resources.back2;
            Bitmap bg = new Bitmap(Width, Height);
            Graphics g2 = Graphics.FromImage(bg);

            Rectangle r = new Rectangle(xpos, 0, 800, 480);
            Bitmap b3 = b2.Clone(r, b2.PixelFormat);
            Rectangle c = new Rectangle(64*idx,0,64,64);
            Bitmap sm = Properties.Resources.smurf.Clone(c, Properties.Resources.smurf.PixelFormat);
            if (delta < 0)
                sm.RotateFlip(RotateFlipType.Rotate180FlipY);
            g2.DrawImage(b1, 0, 0);
            g2.DrawImage(b3, 0, 0);
            g2.DrawImage(sm, cx, 320);

            g2.DrawString(t.Milliseconds +"" , new Font("나눔고딕", 20, GraphicsUnit.Pixel), Brushes.Red, 10, 10);
            g.DrawImage(bg, 0, 0);
            bg.Dispose();
            g2.Dispose();
            g.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameUpdate();
            Render();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 400)
                delta = 10;
            else
                delta = -10;
        }

       
    }
}
