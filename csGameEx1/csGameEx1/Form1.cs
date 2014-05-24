using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csGameEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Image i1 = Properties.Resources.background;
            Bitmap bmp = new Bitmap(Properties.Resources.cha);
            Rectangle r = new Rectangle(0,0, 64,64);
            Rectangle r2 = new Rectangle(64, 0, 64, 64);
            Bitmap bmp2 = bmp.Clone(r, bmp.PixelFormat);
            Bitmap bmp3 = bmp.Clone(r2, bmp.PixelFormat);
            Graphics g = this.CreateGraphics();
            g.DrawImage(i1, 0, 0);
            g.DrawImage(bmp2, Width/2, Height/2);
            g.DrawImage(bmp3, Width / 2 +100, Height / 2);
            g.Dispose();
        }
    }
}
