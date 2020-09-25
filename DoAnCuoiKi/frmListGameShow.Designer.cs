namespace DoAnCuoiKi
{
    partial class frmListGameShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnNotSave = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.dgvQLGameShow = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameShowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGameShow)).BeginInit();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameShowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChucNang
            // 
            this.gbChucNang.BackColor = System.Drawing.Color.SkyBlue;
            this.gbChucNang.Controls.Add(this.btnExit);
            this.gbChucNang.Controls.Add(this.btnSave);
            this.gbChucNang.Controls.Add(this.btnDelete);
            this.gbChucNang.Controls.Add(this.btnNotSave);
            this.gbChucNang.Controls.Add(this.btnUpdate);
            this.gbChucNang.Controls.Add(this.btnAdd);
            this.gbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.Location = new System.Drawing.Point(12, 291);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChucNang.Size = new System.Drawing.Size(1178, 109);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Tools";
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.MistyRose;
            this.btnExit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.IndicateFocus = true;
            this.btnExit.Location = new System.Drawing.Point(1047, 30);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(112, 62);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.MistyRose;
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(763, 30);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(112, 62);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.MistyRose;
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.IndicateFocus = true;
            this.btnDelete.Location = new System.Drawing.Point(300, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(112, 62);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNotSave
            // 
            this.btnNotSave.Animated = true;
            this.btnNotSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNotSave.CheckedState.Parent = this.btnNotSave;
            this.btnNotSave.CustomImages.Parent = this.btnNotSave;
            this.btnNotSave.FillColor = System.Drawing.Color.MistyRose;
            this.btnNotSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNotSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotSave.ForeColor = System.Drawing.Color.Black;
            this.btnNotSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnNotSave.HoverState.Parent = this.btnNotSave;
            this.btnNotSave.IndicateFocus = true;
            this.btnNotSave.Location = new System.Drawing.Point(908, 30);
            this.btnNotSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNotSave.ShadowDecoration.Parent = this.btnNotSave;
            this.btnNotSave.Size = new System.Drawing.Size(112, 62);
            this.btnNotSave.TabIndex = 16;
            this.btnNotSave.Text = "Not Save";
            this.btnNotSave.UseTransparentBackground = true;
            this.btnNotSave.Click += new System.EventHandler(this.btnNotSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.MistyRose;
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.IndicateFocus = true;
            this.btnUpdate.Location = new System.Drawing.Point(156, 30);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(112, 62);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.MistyRose;
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(15, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(112, 62);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvQLGameShow
            // 
            this.dgvQLGameShow.AutoGenerateColumns = false;
            this.dgvQLGameShow.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLGameShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLGameShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLGameShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dgvQLGameShow.DataSource = this.gameShowBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLGameShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLGameShow.GridColor = System.Drawing.Color.Red;
            this.dgvQLGameShow.Location = new System.Drawing.Point(12, 41);
            this.dgvQLGameShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLGameShow.Name = "dgvQLGameShow";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLGameShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLGameShow.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dgvQLGameShow.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQLGameShow.RowTemplate.Height = 28;
            this.dgvQLGameShow.Size = new System.Drawing.Size(1178, 244);
            this.dgvQLGameShow.TabIndex = 2;
            this.dgvQLGameShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLGameShow_CellClick);
            this.dgvQLGameShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLGameShow_CellContentClick);
            // 
            // gbThongTin
            // 
            this.gbThongTin.BackColor = System.Drawing.Color.PowderBlue;
            this.gbThongTin.Controls.Add(this.dtpTimeEnd);
            this.gbThongTin.Controls.Add(this.dtpTimeStart);
            this.gbThongTin.Controls.Add(this.tbxID);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.dtpEndTime);
            this.gbThongTin.Controls.Add(this.dtpStartTime);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.txtName);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.Location = new System.Drawing.Point(14, 406);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTin.Size = new System.Drawing.Size(1178, 331);
            this.gbThongTin.TabIndex = 3;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Information";
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.CustomFormat = "hh:mm:ss tt";
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeEnd.Location = new System.Drawing.Point(416, 246);
            this.dtpTimeEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.ShowUpDown = true;
            this.dtpTimeEnd.Size = new System.Drawing.Size(217, 35);
            this.dtpTimeEnd.TabIndex = 12;
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.CustomFormat = "hh:mm:ss tt";
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeStart.Location = new System.Drawing.Point(416, 178);
            this.dtpTimeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.ShowUpDown = true;
            this.dtpTimeStart.Size = new System.Drawing.Size(217, 35);
            this.dtpTimeStart.TabIndex = 11;
            // 
            // tbxID
            // 
            this.tbxID.Enabled = false;
            this.tbxID.Location = new System.Drawing.Point(174, 50);
            this.tbxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxID.Multiline = true;
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(219, 43);
            this.tbxID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "dd/MM/yyyy";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(174, 245);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(236, 35);
            this.dtpEndTime.TabIndex = 8;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "dd/MM/yyyy";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(174, 178);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(236, 35);
            this.dtpStartTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Time:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 109);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(458, 43);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "List GameShow";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 210;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 210;
            // 
            // gameShowBindingSource
            // 
            this.gameShowBindingSource.DataSource = typeof(DoAnCuoiKi.GameShow);
            // 
            // frmListGameShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 739);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.dgvQLGameShow);
            this.Controls.Add(this.gbChucNang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmListGameShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lịch Phát GameShow";
            this.Load += new System.EventHandler(this.QuanLyGameShow_Load);
            this.gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGameShow)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameShowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.DataGridView dgvQLGameShow;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gameShowBindingSource;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnUpdate;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnNotSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    }
}