using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace miro
{    
    public partial class Form1 : Form
    {
        Bitmap vram;
        Graphics vg;
        Game game = new Game();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 33;
            vram = new Bitmap(Width, Height);
            vg = Graphics.FromImage(vram);
            timer1.Enabled = true;

            game.Load();
            string str="";
            for (int i = 0; i < game.H; i++)
            {
                for (int j = 0; j < game.W; j++)
                {
                    if(game.map[i,j] == '\0')
                        str += '*';
                    else
                        str += game.map[i, j];

                }
                str += "\r\n";
            }
            str += game.W + "," + game.H;
            textBoxLog.Text = str;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGame();
            Render();
        }

        void UpdateGame()
        {

        }

        void Render()
        {
            Graphics g = this.CreateGraphics();
            Rectangle b1 = new Rectangle(5,5,730, 490);
            //draw boxes
            vg.FillRectangle(Brushes.Coral, b1);
            

            //map draw
            for (int i = 0; i < game.H; i++)
                for (int j = 0; j < game.W; j++)                
                    DrawMap(vg, i, j);


            //drawAll
            g.DrawImage(vram, 0, 0);
        }

        void DrawMap(Graphics g, int row, int col)
        {
            Rectangle r = new Rectangle(48*2,48,48,48);
            Bitmap at=  Properties.Resources.atlas;
            Bitmap b = at.Clone(r, at.PixelFormat);         
            int x = col * 48 + 5;
            int y = row * 48 + 5;
            g.DrawImage(b, x, y,48,48);
        }
    }
}
