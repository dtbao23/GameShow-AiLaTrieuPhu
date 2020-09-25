using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class frmListGameShow : Form
    {
        string Path_ListGameShow = "../../../ListGameShow.txt";

        bool IsAdd = false;
        bool CheckInput = true;
        bool IsUpdate = false;

        List<GameShow> DsGameShow = null;

        public IFormatProvider Nothing { get; private set; }

        public frmListGameShow()
        {
            InitializeComponent();
        }
        private void LoadListGameShow()
        {
            StreamReader sr = new StreamReader(Path_ListGameShow);

            DsGameShow = new List<GameShow>();

            List<GameShow> lstGameShow = new List<GameShow>();

            string line = null;

            GameShow gameshow = null;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("*"))
                {
                    gameshow = new GameShow();
                    gameshow.ID = int.Parse(line.Substring(1));
                }
                if (line.StartsWith("@"))
                {
                    gameshow.Name = line.Substring(1);
                }
                if (line.StartsWith("&"))
                {
                    gameshow.StartDate = DateTime.ParseExact(line.Substring(1), "dd/MM/yyyy hh:mm:ss tt", null);
                }
                if (line.StartsWith("#"))
                {
                    gameshow.EndDate = DateTime.ParseExact(line.Substring(1), "dd/MM/yyyy hh:mm:ss tt", null);
                    lstGameShow.Add(gameshow);
                    DsGameShow.Add(gameshow);
                }
            }
            dgvQLGameShow.DataSource = lstGameShow;
            sr.Close();
        }

       
        private GameShow GetInFoGameShow()
        {
            GameShow gameshow = new GameShow();
            if (txtName.Text != "")
            {
                gameshow.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Hay nhap vao ten gameshow");
                CheckInput = false;
            }
            try
            {
                gameshow.StartDate = dtpStartTime.Value.Date + dtpTimeStart.Value.TimeOfDay;
            }
            catch
            {
                MessageBox.Show("thời gian phát sóng không hợp lệ");
                CheckInput = false;
            }
            try
            {
                gameshow.EndDate = dtpEndTime.Value.Date + dtpTimeEnd.Value.TimeOfDay;
            }
            catch
            {
                MessageBox.Show("Thời gian ngắt phát sóng không hợp lệ");
                CheckInput = false;
            }
            return gameshow;
        }
        private bool SaveToFlie(GameShow gameshow)
        {
            int ID = dgvQLGameShow.Rows.Count + 1;
            using (FileStream fs = new FileStream(Path_ListGameShow, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    if (CheckInput)
                    {
                        sw.WriteLine(Environment.NewLine + "*" + ID);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }
                    if (CheckInput)
                    {
                        sw.WriteLine("@" + gameshow.Name);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }
                    if (CheckInput)
                    {
                        string starttime = gameshow.StartDate.ToString("dd/MM/yyyy hh:mm:ss tt");
                        sw.WriteLine("&" + starttime);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }
                    if (CheckInput)
                    {
                        string endtime = gameshow.EndDate.ToString("dd/MM/yyyy hh:mm:ss tt");
                        sw.WriteLine("#" + endtime);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }
                    sw.Close();
                }
                fs.Close();
            }
            return true;
        }
       

       

        private void dgvQLGameShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQLGameShow.Rows[e.RowIndex];

                //Set data into textbox
                //ID
                tbxID.Text = row.Cells[0].Value.ToString();
                tbxID.Tag = row.Cells[0].Value;

                //Name gameshow
                txtName.Text = row.Cells[1].Value.ToString();
                txtName.Tag = row.Cells[1].Value.ToString();

                //get start date and time
                //get start date
                string day_start = row.Cells[2].Value.ToString();
                dtpStartTime.Value = DateTime.Parse(day_start.Substring(0, day_start.Length - 12));
                dtpStartTime.Tag = DateTime.Parse(row.Cells[2].Value.ToString());

                //get start time
                string time_start = row.Cells[2].Value.ToString();
                dtpTimeStart.Value = DateTime.Parse(time_start.Substring(time_start.Length - 11, 11));

                //get end date and time
                //get end date
                string day_end = row.Cells[3].Value.ToString();
                dtpEndTime.Value = DateTime.Parse(day_end.Substring(0, day_end.Length - 12));
                dtpEndTime.Tag = DateTime.Parse(row.Cells[3].Value.ToString());

                //get end time
                string time_end = row.Cells[3].Value.ToString();
                dtpTimeEnd.Value = DateTime.Parse(time_end.Substring(time_end.Length - 11, 11));

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;         
            }
        }

        private void QuanLyGameShow_Load(object sender, EventArgs e)
        {
            LoadListGameShow();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnNotSave.Enabled = false;
        }

               
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxID.Clear();
            txtName.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnNotSave.Enabled = true;
            txtName.Clear();
            dtpStartTime.ResetText();
            dtpEndTime.ResetText();
            IsAdd = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnNotSave.Enabled = true;
            IsUpdate = true;
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;

            DialogResult rs = MessageBox.Show("Confirm", "Are you sure want to delete this file ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                using (FileStream fs = new FileStream(Path_ListGameShow, FileMode.Truncate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        for (int i = 0; i < dgvQLGameShow.Rows.Count; i++)
                        {
                            if (!DsGameShow[i].ID.Equals(tbxID.Tag))
                            {
                                sw.WriteLine("*" + DsGameShow[i].ID);
                                sw.WriteLine("@" + DsGameShow[i].Name);
                                sw.WriteLine("&" + DsGameShow[i].StartDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
                                sw.WriteLine("#" + DsGameShow[i].EndDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
                            }
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
                LoadListGameShow();
                dgvQLGameShow.Refresh();

                tbxID.Clear();
                txtName.Clear();
                dtpStartTime.ResetText();
                dtpEndTime.ResetText();

                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                return;
            }
        }

        private void dgvQLGameShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvQLGameShow.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNotSave.Enabled = false;
            if (IsAdd)
            {
                GameShow gameshow = GetInFoGameShow();
                if (gameshow != null)
                {
                    bool SaveSuccess = SaveToFlie(gameshow);
                    if (SaveSuccess)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadListGameShow();
                        dgvQLGameShow.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                        return;
                    }
                }
                txtName.Clear();
                dtpStartTime.ResetText();
                dtpEndTime.ResetText();
                IsAdd = false;
            }
            if (IsUpdate)
            {
                string[] readText = File.ReadAllLines(Path_ListGameShow);

                using (FileStream fs = new FileStream(Path_ListGameShow, FileMode.Truncate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        for (int i = 0; i < dgvQLGameShow.Rows.Count; i++)
                        {
                            if (!DsGameShow[i].ID.Equals(tbxID.Tag))
                            {
                                sw.WriteLine("*" + DsGameShow[i].ID);
                                sw.WriteLine("@" + DsGameShow[i].Name);
                                sw.WriteLine("&" + DsGameShow[i].StartDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
                                sw.WriteLine("#" + DsGameShow[i].EndDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
                            }
                            else
                            {
                                if (DsGameShow[i].ID.Equals(tbxID.Tag))
                                {
                                    sw.WriteLine("*" + DsGameShow[i].ID);
                                }
                                if (DsGameShow[i].Name.Equals(txtName.Tag))
                                {
                                    sw.WriteLine("@" + txtName.Text);
                                }
                                if ((DsGameShow[i].StartDate).Equals(dtpStartTime.Tag))
                                {
                                    sw.WriteLine("&" + (dtpStartTime.Value.Date + dtpTimeStart.Value.TimeOfDay).ToString("dd/MM/yyyy hh:mm:ss tt"));
                                }
                                if (DsGameShow[i].EndDate.Equals(dtpEndTime.Tag))
                                {
                                    sw.WriteLine("#" + (dtpEndTime.Value.Date + dtpTimeEnd.Value.TimeOfDay).ToString("dd/MM/yyyy hh:mm:ss tt"));
                                }
                            }
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
                LoadListGameShow();
                dgvQLGameShow.Refresh();

                tbxID.Clear();
                txtName.Clear();
                dtpStartTime.ResetText();
                dtpEndTime.ResetText();
                IsUpdate = false;
            }
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnNotSave_Click(object sender, EventArgs e)
        {
            tbxID.Clear();
            txtName.Clear();
            dtpStartTime.ResetText();
            dtpEndTime.ResetText();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnNotSave.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
