using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;

namespace Ponyo
{
    public partial class Form1 : Form
    {
        Stage stage;
        MediaPlayerClass mp3;
        public Form1()
        {
            
            InitializeComponent();
            timer1.Interval = 30;
            timer1.Enabled = true;
            stage = new Stage(this.Width, this.Height);
            mp3 = new MediaPlayerClass();
            mp3.FileName = "town.mp3";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            stage.update();
            stage.render(g);            
            label2.Text = string.Format("FPS: {0:00.00}" ,(double) stage.ms);
            //loop play
            if (mp3.CurrentPosition == 0)
                mp3.Play();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            stage.mx = e.X;
            stage.my = e.Y;
            stage.isClicked = true;
            label1.Text = stage.mx +":" + stage.my;
        }        
    }
}
