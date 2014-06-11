using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for mp3
using System.Runtime.InteropServices;
using MediaPlayer;

namespace SimpleGame
{
    public partial class Form1 : Form
    {
        MediaPlayer.MediaPlayerClass _player;
        public Form1()
        {
            InitializeComponent();
            _player = new MediaPlayer.MediaPlayerClass();
            _player.FileName = @"Resources\town.mp3";
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _player.Stop();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
