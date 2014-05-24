using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace imageviewer
{
    public partial class Form1 : Form
    {
        Image img;
        ImageData id;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog1.FileName);                
                pictureBox1.Width = img.Width;
                pictureBox1.Height = img.Height;
                pictureBox1.Image = img;                
            }
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageData id1 = new ImageData();
            id1.loadFromImage(img);
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.GetEncoding("euc-kr"));
            XmlSerializer xs = new XmlSerializer(typeof(ImageData));
            xs.Serialize(sw, id1);
            sw.Close();
        }
        
        //load image from data
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;  
           
            
            
        }
    }
}
