using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOpoj;
//using MyLib;

namespace DoAnCuoiKi
{
    public partial class frmListQuestion : Form
    {
        string Path_ListQuestion = "../../../ListQuestion.txt";

        //Check add question
        bool IsAdd = false;

        //Check update question
        bool IsUpdate = false;

        //Check delete question
        bool IsDelete = false;

        //Check input
        bool CheckInput = true;

        List<Question> lst_Question = null;

        public frmListQuestion()
        {
            InitializeComponent();
        }
        private void LoadListQuestions()
        {
            StreamReader sr = new StreamReader(Path_ListQuestion);

            lst_Question = new List<Question>();

            List<Question> lstCauHoi = new List<Question>();

            List<string> ListAnswer = null;

            string line = null;

            Question question = null;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("*"))
                {
                    question = new Question();
                    ListAnswer = new List<string>();
                    question.ID = int.Parse(line.Substring(1));
                }
                if (line.StartsWith("@"))
                {
                    question.Content = line.Substring(1);
                }
                if (line.StartsWith("&"))
                {
                    ListAnswer.Add(line.Substring(1));
                    question.ListAnswer.Add(line.Substring(1));
                }
                if (line.StartsWith("#"))
                {
                    question.Answer = line.Substring(1);

                    question.AnswerA = ListAnswer[0];
                    question.AnswerB = ListAnswer[1];
                    question.AnswerC = ListAnswer[2];
                    question.AnswerD = ListAnswer[3];

                    lstCauHoi.Add(question);
                    lst_Question.Add(question);
                }
            }
            dgvQuanLy.DataSource = lstCauHoi;
            sr.Close();
        }

        private void QuanLyCauHoi_Load(object sender, EventArgs e)
        {
            LoadListQuestions();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnNotSave.Enabled = false;
        }

        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQuanLy.Rows[e.RowIndex];

                //Đưa dữ liệu vào textbox
                txtID.Text = row.Cells[0].Value.ToString();
                txtID.Tag = row.Cells[0].Value;

                tbxQuestion.Text = row.Cells[1].Value.ToString();
                tbxQuestion.Tag = row.Cells[1].Value.ToString();

                tbxAnswerA.Text = row.Cells[2].Value.ToString();
                tbxAnswerA.Tag = row.Cells[2].Value.ToString();

                tbxAnswerB.Text = row.Cells[3].Value.ToString();
                tbxAnswerB.Tag = row.Cells[3].Value.ToString();

                tbxAnswerC.Text = row.Cells[4].Value.ToString();
                tbxAnswerC.Tag = row.Cells[4].Value.ToString();

                tbxAnswerD.Text = row.Cells[5].Value.ToString();
                tbxAnswerD.Tag = row.Cells[5].Value.ToString();

                tbxAnswer.Text = row.Cells[6].Value.ToString();
                tbxAnswer.Tag = row.Cells[6].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private Question GetContentQuestion()
        {
            Question cauHoi = new Question();

            if (tbxQuestion.Text != "")
            {
                cauHoi.Content = tbxQuestion.Text;
            }
            else
            {
                MessageBox.Show("Hãy nhập vào nội dung câu hỏi");
                CheckInput = false;
            }
            if (tbxAnswerA.Text != "")
            {
                cauHoi.AnswerA = tbxAnswerA.Text;
            }
            else
            {
                MessageBox.Show("Hãy nhập vào nội dung cho đáp án A");
                CheckInput = false;
            }
            if (tbxAnswerB.Text != "")
            {
                cauHoi.AnswerB = tbxAnswerB.Text;
            }
            else
            {
                MessageBox.Show("Hãy nhập vào nội dung cho đáp án B");
                CheckInput = false;
            }
            if (tbxAnswerC.Text != "")
            {
                cauHoi.AnswerC = tbxAnswerC.Text;
            }
            else
            {
                MessageBox.Show("Hãy nhập vào nội dung cho đáp án C");
                CheckInput = false;
            }
            if (tbxAnswerD.Text != "")
            {
                cauHoi.AnswerD = tbxAnswerD.Text;
            }
            else
            {
                MessageBox.Show("Hãy nhập vào nội dung cho đáp án D");
                CheckInput = false;
            }
            if (tbxAnswer.Text != "")
            {
                cauHoi.Answer = tbxAnswer.Text;
            }
            else
            {
                MessageBox.Show("Hãy nhập vào nội dung cho đáp án đúng");
                CheckInput = false;
            }
            return cauHoi;
        }
        private bool SaveToFlie(Question cauHoi)
        {
            List<string> ListAnswer = new List<string>();
            ListAnswer.Add(cauHoi.AnswerA);
            ListAnswer.Add(cauHoi.AnswerB);
            ListAnswer.Add(cauHoi.AnswerC);
            ListAnswer.Add(cauHoi.AnswerD);
            int id = dgvQuanLy.Rows.Count + 1;
            using (FileStream fs = new FileStream(Path_ListQuestion, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    if (CheckInput)
                    {
                        sw.WriteLine(Environment.NewLine + "*" + id);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }
                    if (CheckInput)
                    {
                        sw.WriteLine("@" + cauHoi.Content);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }
                    if (CheckInput)
                    {
                        foreach (string answer in ListAnswer)
                        {
                            sw.WriteLine("&" + answer);
                        }
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }
                    if (CheckInput)
                    {
                        sw.WriteLine("#" + cauHoi.Answer);
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

        private void btnNotSave_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            tbxQuestion.Clear();
            tbxAnswerA.Clear();
            tbxAnswerB.Clear();
            tbxAnswerC.Clear();
            tbxAnswerD.Clear();
            tbxAnswer.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnNotSave.Enabled = false;
        }

        private void btnNotSave_Click_1(object sender, EventArgs e)
        {
            txtID.Clear();
            tbxQuestion.Clear();
            tbxAnswerA.Clear();
            tbxAnswerB.Clear();
            tbxAnswerC.Clear();
            tbxAnswerD.Clear();
            tbxAnswer.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnNotSave.Enabled = false;
        }

        private void DeleteRow()
        {
            if (IsDelete)
            {
                DialogResult rs = MessageBox.Show("Confirm", "Are you sure want to delete this file ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    using (FileStream fs = new FileStream(Path_ListQuestion, FileMode.Truncate, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                        {
                            for (int i = 0; i < dgvQuanLy.Rows.Count; i++)
                            {
                                if (!lst_Question[i].ID.Equals(txtID.Tag))
                                {
                                    sw.WriteLine("*" + lst_Question[i].ID);
                                    sw.WriteLine("@" + lst_Question[i].Content);
                                    sw.WriteLine("&" + lst_Question[i].AnswerA);
                                    sw.WriteLine("&" + lst_Question[i].AnswerB);
                                    sw.WriteLine("&" + lst_Question[i].AnswerC);
                                    sw.WriteLine("&" + lst_Question[i].AnswerD);
                                    sw.WriteLine("#" + lst_Question[i].Answer);
                                }
                            }
                            sw.Close();
                        }
                        fs.Close();
                    }
                    LoadListQuestions();
                    dgvQuanLy.Refresh();

                    txtID.Clear();
                    tbxQuestion.Clear();
                    tbxAnswerA.Clear();
                    tbxAnswerB.Clear();
                    tbxAnswerC.Clear();
                    tbxAnswerD.Clear();
                    tbxAnswer.Clear();

                    btnDelete.Enabled = false;
                    btnAdd.Enabled = true;
                    IsDelete = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Set button
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnNotSave.Enabled = true;

            //Clean textbox
            txtID.Clear();
            tbxQuestion.Clear();
            tbxAnswerA.Clear();
            tbxAnswerB.Clear();
            tbxAnswerC.Clear();
            tbxAnswerD.Clear();
            tbxAnswer.Clear();

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
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            IsDelete = true;
            DeleteRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNotSave.Enabled = false;
            if (IsAdd)
            {
                Question question = GetContentQuestion();
                if (question != null)
                {
                    bool SaveSuccess = SaveToFlie(question);
                    if (SaveSuccess)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadListQuestions();
                        dgvQuanLy.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                        return;
                    }
                }
                tbxQuestion.Clear();
                tbxAnswerA.Clear();
                tbxAnswerB.Clear();
                tbxAnswerC.Clear();
                tbxAnswerD.Clear();
                tbxAnswer.Clear();
                IsAdd = false;
            }
            if (IsUpdate)
            {
                using (FileStream fs = new FileStream(Path_ListQuestion, FileMode.Truncate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        for (int i = 0; i < dgvQuanLy.Rows.Count; i++)
                        {
                            if (!lst_Question[i].ID.Equals(txtID.Tag))
                            {
                                sw.WriteLine("*" + lst_Question[i].ID);
                                sw.WriteLine("@" + lst_Question[i].Content);
                                sw.WriteLine("&" + lst_Question[i].AnswerA);
                                sw.WriteLine("&" + lst_Question[i].AnswerB);
                                sw.WriteLine("&" + lst_Question[i].AnswerC);
                                sw.WriteLine("&" + lst_Question[i].AnswerD);
                                sw.WriteLine("#" + lst_Question[i].Answer);
                            }
                            else
                            {
                                sw.WriteLine("*" + txtID.Text);
                                if (lst_Question[i].Content.Equals(tbxQuestion.Tag))
                                {
                                    sw.WriteLine("@" + tbxQuestion.Text);
                                }
                                if (lst_Question[i].AnswerA.Equals(tbxAnswerA.Tag))
                                {
                                    sw.WriteLine("&" + tbxAnswerA.Text);
                                }
                                if (lst_Question[i].AnswerB.Equals(tbxAnswerB.Tag))
                                {
                                    sw.WriteLine("&" + tbxAnswerB.Text);
                                }
                                if (lst_Question[i].AnswerC.Equals(tbxAnswerC.Tag))
                                {
                                    sw.WriteLine("&" + tbxAnswerC.Text);
                                }
                                if (lst_Question[i].AnswerD.Equals(tbxAnswerD.Tag))
                                {
                                    sw.WriteLine("&" + tbxAnswerD.Text);
                                }
                                if (lst_Question[i].Answer.Equals(tbxAnswer.Tag))
                                {
                                    sw.WriteLine("#" + tbxAnswer.Text);
                                }
                            }
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
                LoadListQuestions();
                dgvQuanLy.Refresh();

                tbxQuestion.Clear();
                tbxAnswerA.Clear();
                tbxAnswerB.Clear();
                tbxAnswerC.Clear();
                tbxAnswerD.Clear();
                tbxAnswer.Clear();

                IsUpdate = false;
            }
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
