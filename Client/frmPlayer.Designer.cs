namespace Client
{
    partial class frmPlayer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Chart_Result = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.VideoChatClient = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.lblTrucTiep = new System.Windows.Forms.Label();
            this.picThoiGian = new System.Windows.Forms.PictureBox();
            this.ucAnswer_D = new Client.ucAnswer();
            this.ucAnswer_C = new Client.ucAnswer();
            this.ucAnswer_B = new Client.ucAnswer();
            this.ucAnswer_A = new Client.ucAnswer();
            this.lblThoiGian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoChatClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(349, 316);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(654, 96);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Chart_Result
            // 
            this.Chart_Result.BackColor = System.Drawing.Color.Khaki;
            chartArea2.Name = "ChartArea1";
            this.Chart_Result.ChartAreas.Add(chartArea2);
            this.Chart_Result.Location = new System.Drawing.Point(1041, 390);
            this.Chart_Result.Name = "Chart_Result";
            series2.ChartArea = "ChartArea1";
            series2.Name = "SoNguoiTraLoi";
            this.Chart_Result.Series.Add(series2);
            this.Chart_Result.Size = new System.Drawing.Size(233, 176);
            this.Chart_Result.TabIndex = 10;
            this.Chart_Result.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Location = new System.Drawing.Point(349, 318);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 92);
            this.panel6.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(1001, 316);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 92);
            this.panel5.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(351, 407);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 5);
            this.panel3.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(565, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 96);
            this.panel4.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(350, 314);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 5);
            this.panel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(565, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 96);
            this.panel2.TabIndex = 53;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Client.Properties.Resources.Button_Turn_Off_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(1214, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 53);
            this.btnExit.TabIndex = 62;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // VideoChatClient
            // 
            this.VideoChatClient.Enabled = true;
            this.VideoChatClient.Location = new System.Drawing.Point(448, 12);
            this.VideoChatClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VideoChatClient.Name = "VideoChatClient";
            this.VideoChatClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoChatClient.OcxState")));
            this.VideoChatClient.Size = new System.Drawing.Size(440, 257);
            this.VideoChatClient.TabIndex = 63;
            // 
            // lblTrucTiep
            // 
            this.lblTrucTiep.AutoSize = true;
            this.lblTrucTiep.BackColor = System.Drawing.Color.Red;
            this.lblTrucTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrucTiep.ForeColor = System.Drawing.Color.White;
            this.lblTrucTiep.Location = new System.Drawing.Point(499, 17);
            this.lblTrucTiep.Name = "lblTrucTiep";
            this.lblTrucTiep.Size = new System.Drawing.Size(75, 16);
            this.lblTrucTiep.TabIndex = 66;
            this.lblTrucTiep.Text = "Trực Tiếp";
            // 
            // picThoiGian
            // 
            this.picThoiGian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picThoiGian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThoiGian.Enabled = false;
            this.picThoiGian.Image = global::Client.Properties.Resources.PVtR;
            this.picThoiGian.Location = new System.Drawing.Point(1041, 223);
            this.picThoiGian.Name = "picThoiGian";
            this.picThoiGian.Size = new System.Drawing.Size(233, 161);
            this.picThoiGian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThoiGian.TabIndex = 67;
            this.picThoiGian.TabStop = false;
            // 
            // ucAnswer_D
            // 
            this.ucAnswer_D.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucAnswer_D.Content = "";
            this.ucAnswer_D.IsAnswer = false;
            this.ucAnswer_D.Location = new System.Drawing.Point(686, 527);
            this.ucAnswer_D.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswer_D.Name = "ucAnswer_D";
            this.ucAnswer_D.Size = new System.Drawing.Size(317, 37);
            this.ucAnswer_D.TabIndex = 14;
            this.ucAnswer_D.Title = "D";
            this.ucAnswer_D.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // ucAnswer_C
            // 
            this.ucAnswer_C.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucAnswer_C.Content = "";
            this.ucAnswer_C.IsAnswer = false;
            this.ucAnswer_C.Location = new System.Drawing.Point(348, 525);
            this.ucAnswer_C.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswer_C.Name = "ucAnswer_C";
            this.ucAnswer_C.Size = new System.Drawing.Size(317, 39);
            this.ucAnswer_C.TabIndex = 13;
            this.ucAnswer_C.Title = "C";
            this.ucAnswer_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // ucAnswer_B
            // 
            this.ucAnswer_B.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucAnswer_B.Content = "";
            this.ucAnswer_B.IsAnswer = false;
            this.ucAnswer_B.Location = new System.Drawing.Point(686, 442);
            this.ucAnswer_B.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswer_B.Name = "ucAnswer_B";
            this.ucAnswer_B.Size = new System.Drawing.Size(317, 40);
            this.ucAnswer_B.TabIndex = 12;
            this.ucAnswer_B.Title = "B";
            this.ucAnswer_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // ucAnswer_A
            // 
            this.ucAnswer_A.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucAnswer_A.Content = "";
            this.ucAnswer_A.IsAnswer = false;
            this.ucAnswer_A.Location = new System.Drawing.Point(348, 440);
            this.ucAnswer_A.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswer_A.Name = "ucAnswer_A";
            this.ucAnswer_A.Size = new System.Drawing.Size(317, 41);
            this.ucAnswer_A.TabIndex = 11;
            this.ucAnswer_A.Title = "A";
            this.ucAnswer_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGian.Location = new System.Drawing.Point(1143, 292);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(32, 24);
            this.lblThoiGian.TabIndex = 68;
            this.lblThoiGian.Text = "15";
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.backgroud2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 628);
            this.ControlBox = false;
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.picThoiGian);
            this.Controls.Add(this.lblTrucTiep);
            this.Controls.Add(this.VideoChatClient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucAnswer_D);
            this.Controls.Add(this.ucAnswer_C);
            this.Controls.Add(this.ucAnswer_B);
            this.Controls.Add(this.ucAnswer_A);
            this.Controls.Add(this.Chart_Result);
            this.Controls.Add(this.txtNoiDung);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmPlayer";
            this.Text = "Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Player_FormClosed);
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Result)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoChatClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoiGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Timer timer1;
        private ucAnswer ucAnswerA;
        private ucAnswer ucAnswerC;
        private ucAnswer ucAnswerB;
        private ucAnswer ucAnswerD;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Result;
        private ucAnswer ucAnswer_A;
        private ucAnswer ucAnswer_B;
        private ucAnswer ucAnswer_C;
        private ucAnswer ucAnswer_D;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private AxVideoChatReceiverLib.AxVideoChatReceiver VideoChatClient;
        private System.Windows.Forms.Label lblTrucTiep;
        private System.Windows.Forms.PictureBox picThoiGian;
        private System.Windows.Forms.Label lblThoiGian;
    }
}