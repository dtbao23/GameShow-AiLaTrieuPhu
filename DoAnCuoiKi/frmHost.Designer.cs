namespace DoAnCuoiKi
{
    partial class frmHost
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHost));
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.lblDapAn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblTimeTLCH = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.traLoiCauHoitimer = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDapAnDung = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.btnGameShow = new Guna.UI2.WinForms.Guna2Button();
            this.btnResult = new Guna.UI2.WinForms.Guna2Button();
            this.btnWin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSendChart = new Guna.UI2.WinForms.Guna2Button();
            this.txtSLplayer = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumPlayer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameShowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.ucAnswerD = new DoAnCuoiKi.ucAnswer();
            this.ucAnswerC = new DoAnCuoiKi.ucAnswer();
            this.ucAnswerB = new DoAnCuoiKi.ucAnswer();
            this.ucAnswerA = new DoAnCuoiKi.ucAnswer();
            this.panel9 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.VideoChatServer = new AxVideoChatSenderLib.AxVideoChatSender();
            this.axVideoChatServer1 = new AxVideoChatServerLib.AxVideoChatServer();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameShowBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoChatServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtQuestion.Location = new System.Drawing.Point(4, 29);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(680, 111);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCauHoi_KeyPress);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.ForeColor = System.Drawing.Color.Black;
            this.lblCauHoi.Location = new System.Drawing.Point(11, 7);
            this.lblCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(82, 17);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Câu hỏi 1:";
            // 
            // lblDapAn
            // 
            this.lblDapAn.AutoSize = true;
            this.lblDapAn.BackColor = System.Drawing.Color.Transparent;
            this.lblDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAn.Location = new System.Drawing.Point(5, 139);
            this.lblDapAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAn.Name = "lblDapAn";
            this.lblDapAn.Size = new System.Drawing.Size(66, 17);
            this.lblDapAn.TabIndex = 2;
            this.lblDapAn.Text = "Đáp Án:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Broadcast Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Thời gian:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 155);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "#Name";
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.Red;
            this.lblCountDown.Location = new System.Drawing.Point(246, 162);
            this.lblCountDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(21, 24);
            this.lblCountDown.TabIndex = 27;
            this.lblCountDown.Text = "#";
            // 
            // lblTimeTLCH
            // 
            this.lblTimeTLCH.AutoSize = true;
            this.lblTimeTLCH.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeTLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTLCH.ForeColor = System.Drawing.Color.Red;
            this.lblTimeTLCH.Location = new System.Drawing.Point(605, 8);
            this.lblTimeTLCH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeTLCH.Name = "lblTimeTLCH";
            this.lblTimeTLCH.Size = new System.Drawing.Size(21, 24);
            this.lblTimeTLCH.TabIndex = 30;
            this.lblTimeTLCH.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // traLoiCauHoitimer
            // 
            this.traLoiCauHoitimer.Interval = 1000;
            this.traLoiCauHoitimer.Tick += new System.EventHandler(this.traLoiCauHoitimer_Tick);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(8, 66);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "SoNguoiTraLoi";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(267, 224);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // lblDapAnDung
            // 
            this.lblDapAnDung.AutoSize = true;
            this.lblDapAnDung.BackColor = System.Drawing.Color.Transparent;
            this.lblDapAnDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnDung.Location = new System.Drawing.Point(70, 139);
            this.lblDapAnDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDapAnDung.Name = "lblDapAnDung";
            this.lblDapAnDung.Size = new System.Drawing.Size(17, 17);
            this.lblDapAnDung.TabIndex = 37;
            this.lblDapAnDung.Text = "#";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::DoAnCuoiKi.Properties.Resources.eye_24px;
            this.pictureBox1.Location = new System.Drawing.Point(384, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DoAnCuoiKi.Properties.Resources.icons8_fast_forward_64;
            this.btnNext.Location = new System.Drawing.Point(413, 168);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 61);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Image = global::DoAnCuoiKi.Properties.Resources.icons8_email_send_64;
            this.btnSend.Location = new System.Drawing.Point(413, 246);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(73, 48);
            this.btnSend.TabIndex = 7;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 25;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.Enabled = false;
            this.btnStart.FillColor = System.Drawing.Color.Red;
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(173, 510);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(217, 49);
            this.btnStart.TabIndex = 44;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnQuestion.BorderRadius = 25;
            this.btnQuestion.CheckedState.Parent = this.btnQuestion;
            this.btnQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestion.CustomImages.Parent = this.btnQuestion;
            this.btnQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnQuestion.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.btnQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnQuestion.HoverState.Parent = this.btnQuestion;
            this.btnQuestion.Location = new System.Drawing.Point(173, 564);
            this.btnQuestion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.ShadowDecoration.Parent = this.btnQuestion;
            this.btnQuestion.Size = new System.Drawing.Size(217, 49);
            this.btnQuestion.TabIndex = 45;
            this.btnQuestion.Text = "Question Management";
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnGameShow
            // 
            this.btnGameShow.BackColor = System.Drawing.Color.Transparent;
            this.btnGameShow.BorderRadius = 25;
            this.btnGameShow.CheckedState.Parent = this.btnGameShow;
            this.btnGameShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameShow.CustomImages.Parent = this.btnGameShow;
            this.btnGameShow.FillColor = System.Drawing.Color.Yellow;
            this.btnGameShow.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.btnGameShow.ForeColor = System.Drawing.Color.Black;
            this.btnGameShow.HoverState.Parent = this.btnGameShow;
            this.btnGameShow.Location = new System.Drawing.Point(173, 617);
            this.btnGameShow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGameShow.Name = "btnGameShow";
            this.btnGameShow.ShadowDecoration.Parent = this.btnGameShow;
            this.btnGameShow.Size = new System.Drawing.Size(217, 49);
            this.btnGameShow.TabIndex = 46;
            this.btnGameShow.Text = "Broadcast Schedule";
            this.btnGameShow.Click += new System.EventHandler(this.btnGameShow_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.BorderRadius = 25;
            this.btnResult.CheckedState.Parent = this.btnResult;
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.CustomImages.Parent = this.btnResult;
            this.btnResult.Enabled = false;
            this.btnResult.FillColor = System.Drawing.Color.Aquamarine;
            this.btnResult.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.btnResult.ForeColor = System.Drawing.Color.Black;
            this.btnResult.HoverState.Parent = this.btnResult;
            this.btnResult.Location = new System.Drawing.Point(280, 168);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResult.Name = "btnResult";
            this.btnResult.ShadowDecoration.Parent = this.btnResult;
            this.btnResult.Size = new System.Drawing.Size(172, 49);
            this.btnResult.TabIndex = 47;
            this.btnResult.Text = "Result";
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnWin
            // 
            this.btnWin.BackColor = System.Drawing.Color.Transparent;
            this.btnWin.BorderRadius = 25;
            this.btnWin.CheckedState.Parent = this.btnWin;
            this.btnWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWin.CustomImages.Parent = this.btnWin;
            this.btnWin.Enabled = false;
            this.btnWin.FillColor = System.Drawing.Color.PaleGreen;
            this.btnWin.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.btnWin.ForeColor = System.Drawing.Color.Black;
            this.btnWin.HoverState.Parent = this.btnWin;
            this.btnWin.Location = new System.Drawing.Point(280, 222);
            this.btnWin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnWin.Name = "btnWin";
            this.btnWin.ShadowDecoration.Parent = this.btnWin;
            this.btnWin.Size = new System.Drawing.Size(172, 49);
            this.btnWin.TabIndex = 48;
            this.btnWin.Text = "Reward";
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnSendChart
            // 
            this.btnSendChart.AutoRoundedCorners = true;
            this.btnSendChart.BackColor = System.Drawing.Color.Transparent;
            this.btnSendChart.BorderRadius = 23;
            this.btnSendChart.CheckedState.Parent = this.btnSendChart;
            this.btnSendChart.CustomImages.Parent = this.btnSendChart;
            this.btnSendChart.Enabled = false;
            this.btnSendChart.FillColor = System.Drawing.Color.Plum;
            this.btnSendChart.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendChart.ForeColor = System.Drawing.Color.Black;
            this.btnSendChart.HoverState.Parent = this.btnSendChart;
            this.btnSendChart.Location = new System.Drawing.Point(280, 114);
            this.btnSendChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSendChart.Name = "btnSendChart";
            this.btnSendChart.ShadowDecoration.Parent = this.btnSendChart;
            this.btnSendChart.Size = new System.Drawing.Size(172, 49);
            this.btnSendChart.TabIndex = 49;
            this.btnSendChart.Text = "Send Chart";
            this.btnSendChart.Click += new System.EventHandler(this.btnSendChart_Click);
            // 
            // txtSLplayer
            // 
            this.txtSLplayer.AutoRoundedCorners = true;
            this.txtSLplayer.BackColor = System.Drawing.Color.Transparent;
            this.txtSLplayer.BorderRadius = 10;
            this.txtSLplayer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLplayer.DefaultText = "";
            this.txtSLplayer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSLplayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSLplayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSLplayer.DisabledState.Parent = this.txtSLplayer;
            this.txtSLplayer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSLplayer.FillColor = System.Drawing.Color.Red;
            this.txtSLplayer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSLplayer.FocusedState.Parent = this.txtSLplayer;
            this.txtSLplayer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSLplayer.HoverState.Parent = this.txtSLplayer;
            this.txtSLplayer.Location = new System.Drawing.Point(1653, 19);
            this.txtSLplayer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSLplayer.Name = "txtSLplayer";
            this.txtSLplayer.PasswordChar = '\0';
            this.txtSLplayer.PlaceholderText = "";
            this.txtSLplayer.SelectedText = "";
            this.txtSLplayer.ShadowDecoration.Parent = this.txtSLplayer;
            this.txtSLplayer.Size = new System.Drawing.Size(51, 23);
            this.txtSLplayer.TabIndex = 50;
            this.txtSLplayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCauHoi_KeyPress);
            // 
            // txtNumPlayer
            // 
            this.txtNumPlayer.AutoRoundedCorners = true;
            this.txtNumPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtNumPlayer.BorderColor = System.Drawing.Color.Red;
            this.txtNumPlayer.BorderRadius = 9;
            this.txtNumPlayer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumPlayer.DefaultText = "0";
            this.txtNumPlayer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumPlayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumPlayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumPlayer.DisabledState.Parent = this.txtNumPlayer;
            this.txtNumPlayer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumPlayer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumPlayer.FocusedState.Parent = this.txtNumPlayer;
            this.txtNumPlayer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPlayer.ForeColor = System.Drawing.Color.Red;
            this.txtNumPlayer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumPlayer.HoverState.Parent = this.txtNumPlayer;
            this.txtNumPlayer.Location = new System.Drawing.Point(422, 18);
            this.txtNumPlayer.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumPlayer.Name = "txtNumPlayer";
            this.txtNumPlayer.PasswordChar = '\0';
            this.txtNumPlayer.PlaceholderText = "";
            this.txtNumPlayer.SelectedText = "";
            this.txtNumPlayer.SelectionStart = 1;
            this.txtNumPlayer.ShadowDecoration.Parent = this.txtNumPlayer;
            this.txtNumPlayer.Size = new System.Drawing.Size(37, 20);
            this.txtNumPlayer.TabIndex = 51;
            this.txtNumPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCauHoi_KeyPress);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(7, 177);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Time";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 25;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Coral;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(173, 671);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(217, 49);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Khaki;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.dgvSchedule);
            this.panel7.Controls.Add(this.lblTime);
            this.panel7.Controls.Add(this.lblName);
            this.panel7.Controls.Add(this.lblCountDown);
            this.panel7.Location = new System.Drawing.Point(1, 307);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(636, 199);
            this.panel7.TabIndex = 58;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AutoGenerateColumns = false;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dgvSchedule.DataSource = this.gameShowBindingSource;
            this.dgvSchedule.GridColor = System.Drawing.Color.Red;
            this.dgvSchedule.Location = new System.Drawing.Point(7, 25);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime;
            this.dgvSchedule.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedule.RowTemplate.Height = 28;
            this.dgvSchedule.Size = new System.Drawing.Size(629, 129);
            this.dgvSchedule.TabIndex = 17;
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // gameShowBindingSource
            // 
            this.gameShowBindingSource.DataSource = typeof(DoAnCuoiKi.GameShow);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::DoAnCuoiKi.Properties.Resources.panel2;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.lblCauHoi);
            this.panel8.Controls.Add(this.txtQuestion);
            this.panel8.Controls.Add(this.lblDapAn);
            this.panel8.Controls.Add(this.ucAnswerD);
            this.panel8.Controls.Add(this.btnSend);
            this.panel8.Controls.Add(this.btnNext);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.ucAnswerC);
            this.panel8.Controls.Add(this.ucAnswerB);
            this.panel8.Controls.Add(this.lblTimeTLCH);
            this.panel8.Controls.Add(this.ucAnswerA);
            this.panel8.Controls.Add(this.lblDapAnDung);
            this.panel8.Location = new System.Drawing.Point(678, 8);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(685, 372);
            this.panel8.TabIndex = 59;
            // 
            // ucAnswerD
            // 
            this.ucAnswerD.BackColor = System.Drawing.Color.Khaki;
            this.ucAnswerD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAnswerD.Content = "";
            this.ucAnswerD.Enabled = false;
            this.ucAnswerD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucAnswerD.IsAnswer = false;
            this.ucAnswerD.Location = new System.Drawing.Point(9, 300);
            this.ucAnswerD.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswerD.Name = "ucAnswerD";
            this.ucAnswerD.Size = new System.Drawing.Size(361, 46);
            this.ucAnswerD.TabIndex = 43;
            this.ucAnswerD.Title = "D";
            // 
            // ucAnswerC
            // 
            this.ucAnswerC.BackColor = System.Drawing.Color.Khaki;
            this.ucAnswerC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAnswerC.Content = "";
            this.ucAnswerC.Enabled = false;
            this.ucAnswerC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucAnswerC.IsAnswer = false;
            this.ucAnswerC.Location = new System.Drawing.Point(9, 252);
            this.ucAnswerC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswerC.Name = "ucAnswerC";
            this.ucAnswerC.Size = new System.Drawing.Size(361, 46);
            this.ucAnswerC.TabIndex = 42;
            this.ucAnswerC.Title = "C";
            // 
            // ucAnswerB
            // 
            this.ucAnswerB.BackColor = System.Drawing.Color.Khaki;
            this.ucAnswerB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAnswerB.Content = "";
            this.ucAnswerB.Enabled = false;
            this.ucAnswerB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucAnswerB.IsAnswer = false;
            this.ucAnswerB.Location = new System.Drawing.Point(9, 204);
            this.ucAnswerB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswerB.Name = "ucAnswerB";
            this.ucAnswerB.Size = new System.Drawing.Size(361, 46);
            this.ucAnswerB.TabIndex = 41;
            this.ucAnswerB.Title = "B";
            // 
            // ucAnswerA
            // 
            this.ucAnswerA.BackColor = System.Drawing.Color.Khaki;
            this.ucAnswerA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAnswerA.Content = "";
            this.ucAnswerA.Enabled = false;
            this.ucAnswerA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucAnswerA.IsAnswer = false;
            this.ucAnswerA.Location = new System.Drawing.Point(9, 157);
            this.ucAnswerA.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucAnswerA.Name = "ucAnswerA";
            this.ucAnswerA.Size = new System.Drawing.Size(361, 46);
            this.ucAnswerA.TabIndex = 40;
            this.ucAnswerA.Title = "A";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::DoAnCuoiKi.Properties.Resources.panel4;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.btnSendChart);
            this.panel9.Controls.Add(this.chart1);
            this.panel9.Controls.Add(this.btnWin);
            this.panel9.Controls.Add(this.btnResult);
            this.panel9.Location = new System.Drawing.Point(677, 383);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(685, 331);
            this.panel9.TabIndex = 60;
            // 
            // VideoChatServer
            // 
            this.VideoChatServer.Enabled = true;
            this.VideoChatServer.Location = new System.Drawing.Point(1, 3);
            this.VideoChatServer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VideoChatServer.Name = "VideoChatServer";
            this.VideoChatServer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoChatServer.OcxState")));
            this.VideoChatServer.Size = new System.Drawing.Size(377, 299);
            this.VideoChatServer.TabIndex = 63;
            // 
            // axVideoChatServer1
            // 
            this.axVideoChatServer1.Enabled = true;
            this.axVideoChatServer1.Location = new System.Drawing.Point(480, 124);
            this.axVideoChatServer1.Name = "axVideoChatServer1";
            this.axVideoChatServer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatServer1.OcxState")));
            this.axVideoChatServer1.Size = new System.Drawing.Size(100, 50);
            this.axVideoChatServer1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Trực Tiếp";
            // 
            // frmHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 638);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.axVideoChatServer1);
            this.Controls.Add(this.VideoChatServer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtNumPlayer);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSLplayer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGameShow);
            this.Controls.Add(this.btnQuestion);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Host";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Host_FormClosed);
            this.Load += new System.EventHandler(this.Host_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameShowBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoChatServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label lblDapAn;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblTimeTLCH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer traLoiCauHoitimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblDapAnDung;
        private System.Windows.Forms.BindingSource gameShowBindingSource;
        private ucAnswer ucAnswerA;
        private ucAnswer ucAnswerB;
        private ucAnswer ucAnswerC;
        private ucAnswer ucAnswerD;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnQuestion;
        private Guna.UI2.WinForms.Guna2Button btnGameShow;
        private Guna.UI2.WinForms.Guna2Button btnResult;
        private Guna.UI2.WinForms.Guna2Button btnWin;
        private Guna.UI2.WinForms.Guna2Button btnSendChart;
        private Guna.UI2.WinForms.Guna2TextBox txtSLplayer;
        private Guna.UI2.WinForms.Guna2TextBox txtNumPlayer;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private AxVideoChatSenderLib.AxVideoChatSender VideoChatServer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private AxVideoChatServerLib.AxVideoChatServer axVideoChatServer1;
        private System.Windows.Forms.Label label2;
    }
}