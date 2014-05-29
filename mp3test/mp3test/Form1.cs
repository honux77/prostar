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

        int xpos = 400;
        int delta;
        public Form1()
        {
            InitializeComponent();
            wmp.URL = @"Resources\mario.mp3";
            timer1.Interval = 30; //30ms 
            timer1.Enabled = true;
        }

        private void GameUpdate()
        {
            if (MouseButtons == MouseButtons.Left)
                xpos += delta;
            if (xpos < 0)
                xpos = 0;
            else if (xpos > 800)
                xpos = 800;
        }

        private void Render()
        {
            Graphics g = this.CreateGraphics();
            Bitmap b1 = Properties.Resources.back1;
            Bitmap b2 = Properties.Resources.back2;
            Bitmap bg = new Bitmap(Width, Height);
            Graphics g2 = Graphics.FromImage(bg);

            Rectangle r = new Rectangle(xpos, 0, 800, 480);
            Bitmap b3 = b2.Clone(r, b2.PixelFormat);
            Rectangle c = new Rectangle(64*3,0,64,64);
            Bitmap sm = Properties.Resources.smurf.Clone(c, Properties.Resources.smurf.PixelFormat);
            g2.DrawImage(b1, 0, 0);
            g2.DrawImage(b3, 0, 0);
            g2.DrawImage(sm, 400, 350);
            DateTime t = DateTime.Now;
            string time = string.Format("{0:hh:mm:ss:ffff}", t);
            g2.DrawString(time , new Font("나눔고딕", 20, GraphicsUnit.Pixel), Brushes.Red, 10, 10);
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
                delta = 2;
            else
                delta = -2;
        }

       
    }
}
