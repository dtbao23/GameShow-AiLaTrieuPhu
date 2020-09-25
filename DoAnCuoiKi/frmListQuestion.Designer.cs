namespace DoAnCuoiKi
{
    partial class frmListQuestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnNotSave = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.gbTraLoi = new System.Windows.Forms.GroupBox();
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.lblDapAn = new System.Windows.Forms.Label();
            this.tbxAnswerD = new System.Windows.Forms.TextBox();
            this.tbxAnswerC = new System.Windows.Forms.TextBox();
            this.tbxAnswerB = new System.Windows.Forms.TextBox();
            this.tbxAnswerA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.dgvQuanLy = new System.Windows.Forms.DataGridView();
            this.gbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauHoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbChucNang.SuspendLayout();
            this.gbQuestion.SuspendLayout();
            this.gbTraLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).BeginInit();
            this.gbID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChucNang
            // 
            this.gbChucNang.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbChucNang.Controls.Add(this.btnExit);
            this.gbChucNang.Controls.Add(this.btnAdd);
            this.gbChucNang.Controls.Add(this.btnSave);
            this.gbChucNang.Controls.Add(this.btnUpdate);
            this.gbChucNang.Controls.Add(this.btnDelete);
            this.gbChucNang.Controls.Add(this.btnNotSave);
            this.gbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.Location = new System.Drawing.Point(9, 294);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChucNang.Size = new System.Drawing.Size(1203, 109);
            this.gbChucNang.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(1071, 30);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(112, 62);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(17, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(112, 62);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnSave.Location = new System.Drawing.Point(804, 29);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(112, 62);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(148, 29);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(112, 62);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(275, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(112, 62);
            this.btnDelete.TabIndex = 21;
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
            this.btnNotSave.Location = new System.Drawing.Point(938, 30);
            this.btnNotSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNotSave.ShadowDecoration.Parent = this.btnNotSave;
            this.btnNotSave.Size = new System.Drawing.Size(112, 62);
            this.btnNotSave.TabIndex = 22;
            this.btnNotSave.Text = "Not Save";
            this.btnNotSave.UseTransparentBackground = true;
            this.btnNotSave.Click += new System.EventHandler(this.btnNotSave_Click_1);
            // 
            // gbQuestion
            // 
            this.gbQuestion.BackColor = System.Drawing.Color.LightBlue;
            this.gbQuestion.Controls.Add(this.tbxQuestion);
            this.gbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestion.Location = new System.Drawing.Point(144, 417);
            this.gbQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbQuestion.Size = new System.Drawing.Size(534, 288);
            this.gbQuestion.TabIndex = 1;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Question";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(12, 29);
            this.tbxQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(516, 255);
            this.tbxQuestion.TabIndex = 2;
            // 
            // gbTraLoi
            // 
            this.gbTraLoi.BackColor = System.Drawing.Color.LightBlue;
            this.gbTraLoi.Controls.Add(this.tbxAnswer);
            this.gbTraLoi.Controls.Add(this.lblDapAn);
            this.gbTraLoi.Controls.Add(this.tbxAnswerD);
            this.gbTraLoi.Controls.Add(this.tbxAnswerC);
            this.gbTraLoi.Controls.Add(this.tbxAnswerB);
            this.gbTraLoi.Controls.Add(this.tbxAnswerA);
            this.gbTraLoi.Controls.Add(this.label3);
            this.gbTraLoi.Controls.Add(this.label2);
            this.gbTraLoi.Controls.Add(this.label1);
            this.gbTraLoi.Controls.Add(this.lblA);
            this.gbTraLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTraLoi.Location = new System.Drawing.Point(686, 417);
            this.gbTraLoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTraLoi.Name = "gbTraLoi";
            this.gbTraLoi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTraLoi.Size = new System.Drawing.Size(526, 288);
            this.gbTraLoi.TabIndex = 2;
            this.gbTraLoi.TabStop = false;
            this.gbTraLoi.Text = "Answer";
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Location = new System.Drawing.Point(105, 225);
            this.tbxAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswer.TabIndex = 9;
            // 
            // lblDapAn
            // 
            this.lblDapAn.AutoSize = true;
            this.lblDapAn.Location = new System.Drawing.Point(15, 228);
            this.lblDapAn.Name = "lblDapAn";
            this.lblDapAn.Size = new System.Drawing.Size(84, 25);
            this.lblDapAn.TabIndex = 8;
            this.lblDapAn.Text = "Đáp Án";
            // 
            // tbxAnswerD
            // 
            this.tbxAnswerD.Location = new System.Drawing.Point(105, 172);
            this.tbxAnswerD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnswerD.Name = "tbxAnswerD";
            this.tbxAnswerD.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerD.TabIndex = 7;
            // 
            // tbxAnswerC
            // 
            this.tbxAnswerC.Location = new System.Drawing.Point(105, 130);
            this.tbxAnswerC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnswerC.Name = "tbxAnswerC";
            this.tbxAnswerC.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerC.TabIndex = 6;
            // 
            // tbxAnswerB
            // 
            this.tbxAnswerB.Location = new System.Drawing.Point(105, 85);
            this.tbxAnswerB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnswerB.Name = "tbxAnswerB";
            this.tbxAnswerB.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerB.TabIndex = 5;
            // 
            // tbxAnswerA
            // 
            this.tbxAnswerA.Location = new System.Drawing.Point(105, 38);
            this.tbxAnswerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnswerA.Name = "tbxAnswerA";
            this.tbxAnswerA.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(32, 42);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 25);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // dgvQuanLy
            // 
            this.dgvQuanLy.AutoGenerateColumns = false;
            this.dgvQuanLy.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.answerADataGridViewTextBoxColumn,
            this.answerBDataGridViewTextBoxColumn,
            this.answerCDataGridViewTextBoxColumn,
            this.answerDDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn});
            this.dgvQuanLy.DataSource = this.cauHoiBindingSource;
            this.dgvQuanLy.GridColor = System.Drawing.Color.Red;
            this.dgvQuanLy.Location = new System.Drawing.Point(9, 51);
            this.dgvQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLy.Name = "dgvQuanLy";
            this.dgvQuanLy.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQuanLy.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Aqua;
            this.dgvQuanLy.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQuanLy.RowTemplate.Height = 28;
            this.dgvQuanLy.Size = new System.Drawing.Size(1203, 239);
            this.dgvQuanLy.TabIndex = 3;
            this.dgvQuanLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLy_CellClick);
            // 
            // gbID
            // 
            this.gbID.BackColor = System.Drawing.Color.LightBlue;
            this.gbID.Controls.Add(this.txtID);
            this.gbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbID.Location = new System.Drawing.Point(8, 417);
            this.gbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbID.Name = "gbID";
            this.gbID.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbID.Size = new System.Drawing.Size(130, 288);
            this.gbID.TabIndex = 4;
            this.gbID.TabStop = false;
            this.gbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(6, 38);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 40);
            this.txtID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "List Question";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerADataGridViewTextBoxColumn
            // 
            this.answerADataGridViewTextBoxColumn.DataPropertyName = "AnswerA";
            this.answerADataGridViewTextBoxColumn.HeaderText = "AnswerA";
            this.answerADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerADataGridViewTextBoxColumn.Name = "answerADataGridViewTextBoxColumn";
            this.answerADataGridViewTextBoxColumn.ReadOnly = true;
            this.answerADataGridViewTextBoxColumn.Width = 150;
            // 
            // answerBDataGridViewTextBoxColumn
            // 
            this.answerBDataGridViewTextBoxColumn.DataPropertyName = "AnswerB";
            this.answerBDataGridViewTextBoxColumn.HeaderText = "AnswerB";
            this.answerBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerBDataGridViewTextBoxColumn.Name = "answerBDataGridViewTextBoxColumn";
            this.answerBDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerBDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerCDataGridViewTextBoxColumn
            // 
            this.answerCDataGridViewTextBoxColumn.DataPropertyName = "AnswerC";
            this.answerCDataGridViewTextBoxColumn.HeaderText = "AnswerC";
            this.answerCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerCDataGridViewTextBoxColumn.Name = "answerCDataGridViewTextBoxColumn";
            this.answerCDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerCDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerDDataGridViewTextBoxColumn
            // 
            this.answerDDataGridViewTextBoxColumn.DataPropertyName = "AnswerD";
            this.answerDDataGridViewTextBoxColumn.HeaderText = "AnswerD";
            this.answerDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerDDataGridViewTextBoxColumn.Name = "answerDDataGridViewTextBoxColumn";
            this.answerDDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerDDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerDataGridViewTextBoxColumn.Width = 150;
            // 
            // cauHoiBindingSource
            // 
            this.cauHoiBindingSource.DataSource = typeof(DTOpoj.Question);
            // 
            // frmListQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 717);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbID);
            this.Controls.Add(this.dgvQuanLy);
            this.Controls.Add(this.gbTraLoi);
            this.Controls.Add(this.gbQuestion);
            this.Controls.Add(this.gbChucNang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmListQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyCauHoi";
            this.Load += new System.EventHandler(this.QuanLyCauHoi_Load);
            this.gbChucNang.ResumeLayout(false);
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.gbTraLoi.ResumeLayout(false);
            this.gbTraLoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).EndInit();
            this.gbID.ResumeLayout(false);
            this.gbID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.GroupBox gbTraLoi;
        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Label lblDapAn;
        private System.Windows.Forms.TextBox tbxAnswerD;
        private System.Windows.Forms.TextBox tbxAnswerC;
        private System.Windows.Forms.TextBox tbxAnswerB;
        private System.Windows.Forms.TextBox tbxAnswerA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DataGridView dgvQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cauHoiBindingSource;
        private System.Windows.Forms.GroupBox gbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnUpdate;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnNotSave;
    }
}