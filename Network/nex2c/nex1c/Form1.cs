using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace nex1c
{
    public partial class Form1 : Form
    {
        Client client = new Client();
        public Form1()
        { 
            InitializeComponent();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                debugLabel.Text = "엔터 눌림";
                string msg = client.Send(textBoxInput.Text);                
                textBoxMsg.Text += msg +"\r\n";                
                textBoxInput.Text = "";
                textBoxInput.Focus();
            }               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addr = textBoxAddr.Text;
            int port = (int)numericUpDownPort.Value;            
            string ret;
            if ((ret=client.Connect(addr, port))=="success")
            {
                debugLabel.Text = "Connected";
            }
            else
            {
                debugLabel.Text = "연결 오류 발생";
                textBoxMsg.Text = ret;
            }
        }

        private void disButton_Click(object sender, EventArgs e)
        {
            client.Close();
            debugLabel.Text = "접속 종료";
        }
    }
}
