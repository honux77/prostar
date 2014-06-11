namespace nex1c
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.buttonConn = new System.Windows.Forms.Button();
            this.buttonDis = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(13, 13);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(262, 222);
            this.textBoxMsg.TabIndex = 0;
            // 
            // buttonConn
            // 
            this.buttonConn.Location = new System.Drawing.Point(448, 25);
            this.buttonConn.Name = "buttonConn";
            this.buttonConn.Size = new System.Drawing.Size(75, 23);
            this.buttonConn.TabIndex = 1;
            this.buttonConn.Text = "연결";
            this.buttonConn.UseVisualStyleBackColor = true;
            this.buttonConn.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDis
            // 
            this.buttonDis.Location = new System.Drawing.Point(448, 54);
            this.buttonDis.Name = "buttonDis";
            this.buttonDis.Size = new System.Drawing.Size(75, 23);
            this.buttonDis.TabIndex = 2;
            this.buttonDis.Text = "접속끊기";
            this.buttonDis.UseVisualStyleBackColor = true;
            this.buttonDis.Click += new System.EventHandler(this.disButton_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(434, 266);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(89, 12);
            this.debugLabel.TabIndex = 3;
            this.debugLabel.Text = "Not Connected";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(13, 256);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(256, 21);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // textBoxAddr
            // 
            this.textBoxAddr.Location = new System.Drawing.Point(331, 27);
            this.textBoxAddr.Name = "textBoxAddr";
            this.textBoxAddr.Size = new System.Drawing.Size(100, 21);
            this.textBoxAddr.TabIndex = 5;
            this.textBoxAddr.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP 주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "포트";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(331, 57);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownPort.TabIndex = 9;
            this.numericUpDownPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 289);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddr);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.buttonDis);
            this.Controls.Add(this.buttonConn);
            this.Controls.Add(this.textBoxMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Button buttonConn;
        private System.Windows.Forms.Button buttonDis;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
    }
}

