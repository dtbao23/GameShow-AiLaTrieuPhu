using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi;
using DTOpoj;

namespace Client
{
    public partial class frmMain : Form
    {
        string Path_DSGameShow = "../../../ListGameShow.txt";
        string flag = "";
        List<DateTime> lstSchedule = new List<DateTime>();

        //gameshow có thời gian gần nhất
        GameShow timeGame = null;

        public frmMain()
        {
            InitializeComponent();
            lblTimeNow.Text = "There is not Broadcast Schedule";
            ShowSchedule();
        }

        public GameShow GameShowGanNhat(List<GameShow> lstGameShow)
        {
            DateTime timeNow = DateTime.Now;

            GameShow gameShow = null;

            foreach (GameShow game in lstGameShow)
            {
                if (timeNow < game.EndDate)
                {
                    if (gameShow == null)
                        gameShow = game;
                    if (game.StartDate.Subtract(timeNow).TotalMilliseconds < gameShow.StartDate.Subtract(timeNow).TotalMilliseconds)
                    {
                        gameShow = game;
                    }
                }
            }
            return gameShow;

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {

            if(lblTimeNow.Text == "There is not Broadcast Schedule")
            {
                MessageBox.Show("Không có sẳn lịch phát sóng nào. Hãy đợi thêm giây lát bạn nhé!");
            }    

            else
            {
                SoundPlayer simpleSound = new SoundPlayer(global::Client.Properties.Resources.fileLogIn);
                simpleSound.Play();
                this.Hide();
                frmConnectToServer connect = new frmConnectToServer();
                connect.ShowDialog();
                this.Close();
            }    
            


            //DateTime Time_Schedule = DateTime.ParseExact(lblTimeNow.Text.Substring(0, 16), "dd/MM/yyyy hh:mm", null);
            //int flag = 0;
            //for (int i = 0; i < lstSchedule.Count; i++)
            //{
            //    if (DateTime.Compare(Time_Schedule, lstSchedule[i]) == 0)
            //    {
            //        flag = 1;
            //    }
            //}
            //if (flag == 1)
            //{
            //    this.Hide();
            //    frmConnectToServer connect = new frmConnectToServer();
            //    connect.ShowDialog();
            //    this.Close();
            //}
            //else if (flag == 0)
            //{
            //    MessageBox.Show("Không có sẳn lịch phát sóng nào. Hãy đợi thêm giây lát bạn nhé!");
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            frmHuongDang frm = new frmHuongDang();
            frm.Show();
        }
        private void ShowSchedule()
        {
            StreamReader sr = new StreamReader(Path_DSGameShow);

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
                    lstSchedule.Add(DateTime.ParseExact(line.Substring(1, 16), "dd/MM/yyyy hh:mm", null));
                }
                if (line.StartsWith("#"))
                {
                    gameshow.EndDate = DateTime.ParseExact(line.Substring(1), "dd/MM/yyyy hh:mm:ss tt", null);
                    lstGameShow.Add(gameshow);
                }
            }
            dgvSchedule.DataSource = lstGameShow;
            sr.Close();
            timeGame = GameShowGanNhat(lstGameShow);
            //if (flag == "ShowSchedule")
            //{
            //    StreamReader sr = new StreamReader(Path_DSGameShow);

            //    List<GameShow> lstGameShow = new List<GameShow>();

            //    string line = null;

            //    GameShow gameshow = null;

            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        if (line.StartsWith("*"))
            //        {
            //            gameshow = new GameShow();
            //            gameshow.ID = int.Parse(line.Substring(1));
            //        }
            //        if (line.StartsWith("@"))
            //        {
            //            gameshow.Name = line.Substring(1);
            //        }
            //        if (line.StartsWith("&"))
            //        {
            //            gameshow.StartDate = DateTime.ParseExact(line.Substring(1), "dd/MM/yyyy hh:mm:ss tt", null);
            //            lstSchedule.Add(DateTime.ParseExact(line.Substring(1, 16), "dd/MM/yyyy hh:mm", null));
            //        }
            //        if (line.StartsWith("#"))
            //        {
            //            gameshow.EndDate = DateTime.ParseExact(line.Substring(1), "dd/MM/yyyy hh:mm:ss tt", null);
            //            lstGameShow.Add(gameshow);
            //        }
            //    }
            //    dgvSchedule.DataSource = lstGameShow;
            //    sr.Close();
            //    timeGame = GameShowGanNhat(lstGameShow);
            //}
            //else
            //    return;
        }

        private void btnGetSchedule_Click(object sender, EventArgs e)
        {
            ShowSchedule();
            if(timeGame != null)
            {
                lblTimeNow.Text = timeGame.StartDate.ToString("dd/MM/yyyy hh:mm:ss");
            }    
        }
    }
}
