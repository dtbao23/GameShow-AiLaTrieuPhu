namespace Client
{
    partial class ucAnswer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.chkThuTu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(55, 0);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(264, 42);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // chkThuTu
            // 
            this.chkThuTu.AutoSize = true;
            this.chkThuTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuTu.Location = new System.Drawing.Point(14, 9);
            this.chkThuTu.Margin = new System.Windows.Forms.Padding(2);
            this.chkThuTu.Name = "chkThuTu";
            this.chkThuTu.Size = new System.Drawing.Size(40, 24);
            this.chkThuTu.TabIndex = 1;
            this.chkThuTu.Text = "A";
            this.chkThuTu.UseVisualStyleBackColor = true;
            // 
            // ucAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.chkThuTu);
            this.Controls.Add(this.txtNoiDung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucAnswer";
            this.Size = new System.Drawing.Size(317, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.CheckBox chkThuTu;
    }
}
