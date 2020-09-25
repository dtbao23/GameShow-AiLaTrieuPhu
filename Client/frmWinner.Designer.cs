namespace Client
{
    partial class frmWinner
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
            this.lblHangNhat = new System.Windows.Forms.Label();
            this.lblHangHai = new System.Windows.Forms.Label();
            this.lblHangBa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHangNhat
            // 
            this.lblHangNhat.AutoSize = true;
            this.lblHangNhat.BackColor = System.Drawing.Color.Transparent;
            this.lblHangNhat.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangNhat.ForeColor = System.Drawing.Color.Red;
            this.lblHangNhat.Location = new System.Drawing.Point(346, 9);
            this.lblHangNhat.Name = "lblHangNhat";
            this.lblHangNhat.Size = new System.Drawing.Size(92, 31);
            this.lblHangNhat.TabIndex = 5;
            this.lblHangNhat.Text = "label1";
            // 
            // lblHangHai
            // 
            this.lblHangHai.AutoSize = true;
            this.lblHangHai.BackColor = System.Drawing.Color.Transparent;
            this.lblHangHai.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangHai.ForeColor = System.Drawing.Color.Red;
            this.lblHangHai.Location = new System.Drawing.Point(73, 110);
            this.lblHangHai.Name = "lblHangHai";
            this.lblHangHai.Size = new System.Drawing.Size(99, 34);
            this.lblHangHai.TabIndex = 6;
            this.lblHangHai.Text = "label2";
            // 
            // lblHangBa
            // 
            this.lblHangBa.AutoSize = true;
            this.lblHangBa.BackColor = System.Drawing.Color.Transparent;
            this.lblHangBa.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangBa.ForeColor = System.Drawing.Color.Red;
            this.lblHangBa.Location = new System.Drawing.Point(627, 170);
            this.lblHangBa.Name = "lblHangBa";
            this.lblHangBa.Size = new System.Drawing.Size(99, 34);
            this.lblHangBa.TabIndex = 7;
            this.lblHangBa.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trao Giải Thưởng";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Client.Properties.Resources._87_512;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHangBa);
            this.panel1.Controls.Add(this.lblHangHai);
            this.panel1.Controls.Add(this.lblHangNhat);
            this.panel1.Location = new System.Drawing.Point(137, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 511);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Client.Properties.Resources.giphy__2_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1086, 642);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frmWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "frmWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWinner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHangNhat;
        private System.Windows.Forms.Label lblHangHai;
        private System.Windows.Forms.Label lblHangBa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}