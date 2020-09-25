using DTOpoj;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class frmHost : Form
    {
        string Path_ListGameShow = "../../../ListGameShow.txt";
        string Path_ListQuestion = "../../../ListQuestion.txt";

        delegate void SetChartCallback(int a, int b, int c, int d);

        int PORT = 5000;

        int PORT_Video = 1234;

        int IdPhong = 0;

        int SoPhong = 5000;

        string strHostName;

        IPHostEntry iphostentry;

        //IPAddress IP;

        TcpListener listener;

        NetworkStream ns;

        Thread t = null;

        List<Player> lstPlayer = null;

        GameShow gameShow = null;

        int OrigTime = 1800;

        List<Question> lstQuestion = new List<Question>();

        //current question
        Question Cur_Question = null;

        //Question send to client
        QuestionForClient questionforclient = null;

        //count question sent to client
        int questionNum = 1;

        //Time to answer questions
        int TimeForAnswer = 15;

        //Counting time to answer questions
        int count = 1;

        //delegate to set number of client
        delegate void SetTextCallback(string text);

        //Send announce the winning for client
        public delegate void SendResult(List<DTOpoj.GetResult> Statistical_Result);
        public event SendResult sendresult;

        //count the correct answers
        Count Correct_Question = new Count();

        //send sign to show broadcast schedule for client
        public string flag = "ShowSchedule";

        //gameshow có thời gian gần nhất
        GameShow timeGame = null;
        public frmHost()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //strHostName = Dns.GetHostName();
            //iphostentry = Dns.GetHostByName(strHostName);
            //IP = iphostentry.AddressList[0];

            this.axVideoChatServer1.InitServer(PORT_Video, 300);
            SoPhong = axVideoChatServer1.CreateConference();
            this.axVideoChatServer1.UseRandomNumber = false;
        }

        private void Host_Load(object sender, EventArgs e)
        {
            gameShow = new GameShow();

            LoadListSchedule();

            lblName.Text = "The Ultimate Minions Quiz!";

            kiemTraThoiGianPhatSong();

            Correct_Question.CauA = 0;
            Correct_Question.CauB = 0;
            Correct_Question.CauC = 0;
            Correct_Question.CauD = 0;

            fillChart(0, 0, 0, 0);

            IdPhong = axVideoChatServer1.AddUser(SoPhong);

            VideoChat(IdPhong);
        }

        void kiemTraThoiGianPhatSong()
        {
            if (timeGame != null)
            {
                lblTime.Text = timeGame.StartDate.ToString("dd/MM/yyyy hh:mm:ss");
                lblName.Text = timeGame.Name;
                OrigTime = TimeCountDown(timeGame.StartDate, DateTime.Now);
                gameTimer.Enabled = true;
            }
            else
            {
                lblCountDown.Text = "There is not broadcast schedule";
            }
        }

        private void LoadQuestion()
        {
            GetListQuestion();

            gameShow.LoadListQuestions(lstQuestion);

            Cur_Question = lstQuestion[0];

            questionforclient = new QuestionForClient();
            questionforclient.Content = Cur_Question.Content;
            questionforclient.DSCauTraLoi.Clear();
            questionforclient.DSCauTraLoi.AddRange(Cur_Question.ListAnswer);

            ShowQuestion(Cur_Question);
        }

        public GameShow GameShowGanNhat(List<GameShow> lstGameShow)
        {
            DateTime timeNow = DateTime.Now;

            GameShow gameShow = null;

            foreach (GameShow game in lstGameShow)
            {
                if (timeNow < game.StartDate)
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
        private void LoadListSchedule()
        {
            StreamReader sr = new StreamReader(Path_ListGameShow);

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
                }
            }
            dgvSchedule.DataSource = lstGameShow;
            sr.Close();
            timeGame = GameShowGanNhat(lstGameShow);
        }

        private void fillChart(int a, int b, int c, int d)
        {
            chart1.Series["SoNguoiTraLoi"].Points.Clear();
            chart1.Series["SoNguoiTraLoi"].Points.AddXY("A", a);
            chart1.Series["SoNguoiTraLoi"].Points.AddXY("B", b);
            chart1.Series["SoNguoiTraLoi"].Points.AddXY("C", c);
            chart1.Series["SoNguoiTraLoi"].Points.AddXY("D", d);
        }

        int TimeCountDown(DateTime StartDate, DateTime dateNow)
        {
            return (int)Math.Round((StartDate - dateNow).TotalSeconds, 0);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);
        }

        void timeX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            lblCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (OrigTime <= 0)
            {
                gameTimer.Enabled = false;
                btnStart.Enabled = true;
                btnSend.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void GetListQuestion()
        {
            StreamReader sr = new StreamReader(Path_ListQuestion);

            string line = null;
            Question cauHoi = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("*"))
                {
                    cauHoi = new Question();
                    cauHoi.ID = int.Parse(line.Substring(1));
                }
                if (line.StartsWith("@"))
                {
                    cauHoi.Content = line.Substring(1);
                }
                if (line.StartsWith("&"))
                {
                    cauHoi.ListAnswer.Add(line.Substring(1));
                }
                if (line.StartsWith("#"))
                {
                    cauHoi.Answer = line.Substring(1);

                    lstQuestion.Add(cauHoi);
                }
            }
            sr.Close();
        }

        void ShowQuestion(Question cauHoi)
        {
            txtQuestion.Text = cauHoi.Content;

            lblDapAnDung.Text = cauHoi.Answer;

            ucAnswerA.Content = cauHoi.ListAnswer[0];
            ucAnswerB.Content = cauHoi.ListAnswer[1];
            ucAnswerC.Content = cauHoi.ListAnswer[2];
            ucAnswerD.Content = cauHoi.ListAnswer[3];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(global::DoAnCuoiKi.Properties.Resources.fileNext);
            simpleSound.Play();
            lblTimeTLCH.Text = "0";
            lblCauHoi.Text = "";
            if (questionNum < lstQuestion.Count)
            {
                btnSend.Enabled = true; //
                Cur_Question = lstQuestion[questionNum++];
                ShowQuestion(Cur_Question);

                questionforclient.Content = Cur_Question.Content;
                questionforclient.DSCauTraLoi.Clear();
                questionforclient.DSCauTraLoi.AddRange(Cur_Question.ListAnswer);
                lblCauHoi.Text += "Câu hỏi " + questionNum.ToString() + ": ";
            }
            else
            {
                frmWinner frmwinner = new frmWinner();
                frmwinner.Show();
                btnNext.Enabled = false;
                btnSend.Enabled = false;
                btnResult.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(global::DoAnCuoiKi.Properties.Resources.fileSend);
            simpleSound.Play();
            Correct_Question.CauA = 0;
            Correct_Question.CauB = 0;
            Correct_Question.CauC = 0;
            Correct_Question.CauD = 0;
            SetChart(Correct_Question.CauA, Correct_Question.CauB, Correct_Question.CauC, Correct_Question.CauD);
            if (lstPlayer != null)
            {
                if (lstPlayer.Count > 0)
                {
                    try
                    {
                        if (Cur_Question != null)
                        {
                            foreach (Player item in lstPlayer)
                            {
                                ns = item.client.GetStream();
                                try
                                {
                                    SendQuestion();
                                }
                                catch
                                {
                                    lstPlayer.Remove(item);
                                    item.client.Close();

                                    SetText(lstPlayer.Count.ToString());
                                }
                            }
                            traLoiCauHoitimer.Enabled = true;
                            count = 1;
                            btnNext.Enabled = false;
                            btnSend.Enabled = false;
                            btnSendChart.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("chưa có câu hỏi được chọn");
                        }
                    }
                    catch
                    {
                        lstPlayer.Clear();
                        SetText("0");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có client kết nối");
                }
            }
            else
            {
                MessageBox.Show("Chưa có client kết nối");
            }
        }
        void SendQuestion()
        {
            byte[] byteTime = Utils.ObjectToByteArray(questionforclient);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        void SendTimeForAnswer()
        {
            byte[] byteTime = Utils.ObjectToByteArray(TimeForAnswer);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        private void traLoiCauHoitimer_Tick(object sender, EventArgs e)
        {
            if (count > TimeForAnswer)
            {
                traLoiCauHoitimer.Enabled = false;
                btnNext.Enabled = true;
                //btnSend.Enabled = true; //
                btnSendChart.Enabled = true;
            }
            else
            {
                lblTimeTLCH.Text = count.ToString();
                count++;
            }
        }

        void GetSubscribe(Player player)
        {
            byte[] bytes = new byte[1024];
            ns.Read(bytes, 0, bytes.Length);
            player.Name = (string)Utils.ByteArrayToObject(bytes);
        }

        private void SetText(string text)
        {
            try
            {
                if (this.txtNumPlayer.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.txtNumPlayer.Text = text;
                }
            }
            catch
            {

            }
        }

        void SetChart(int a, int b, int c, int d)
        {
            if (this.chart1.InvokeRequired)
            {
                SetChartCallback chart = new SetChartCallback(SetChart);
                this.Invoke(chart, new object[] { a, b, c, d });
            }
            else
            {
                fillChart(a, b, c, d);
            }
        }


        void Get_Connect()
        {
            lstPlayer = new List<Player>();

            listener = new TcpListener(IPAddress.Any, PORT);
            listener.Start();

            t = new Thread(() => {
                try
                {
                    int i = 0;
                    while (true)
                    {
                        i++;
                        Player player = new Player
                        {
                            ID = i,
                            client = listener.AcceptTcpClient()
                        };

                        ns = player.client.GetStream();

                        GetSubscribe(player);

                        lstPlayer.Add(player);

                        SetText(lstPlayer.Count.ToString());

                        IdPhong = axVideoChatServer1.AddUser(5000);

                        GuiIdPhong(player, IdPhong);

                        Thread d = new Thread(Get_Result);
                        d.Start(player);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            });
            t.Start();
        }

        private void GuiIdPhong(Player player, int IdPhong)
        {
            ns = player.client.GetStream();
            byte[] byteTime = Utils.ObjectToByteArray(IdPhong);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        public void Get_Result(Object obj)
        {
            byte[] bytes = new byte[1024];

            Player player = (Player)obj;

            string answer = null;

            try
            {
                while (true)
                {
                    ns = player.client.GetStream();
                    ns.Read(bytes, 0, bytes.Length);

                    object data = Utils.ByteArrayToObject(bytes); //

                    if (answer != (string)data)//
                    {
                        answer = (string)data;
                        lock (this)
                        {
                            gameShow.CheckAnswer(player.ID, Cur_Question.ID, answer);
                            foreach (PlayerScore playerScore in gameShow.ListUserScores[player.ID])
                            {
                                if (playerScore.QuestionId == Cur_Question.ID)
                                {
                                    if (player.client.Connected)
                                    {
                                        bool result = playerScore.Result;
                                        try
                                        {
                                            Send_Result(result, player);
                                            CountTheSameAnswer(answer);
                                            SetChart(Correct_Question.CauA, Correct_Question.CauB, Correct_Question.CauC, Correct_Question.CauD);
                                        }
                                        catch
                                        {
                                            player.client.Close();
                                            lstPlayer.Remove(player);
                                            SetText(lstPlayer.Count.ToString());
                                            ResetTheSameAnswer(answer);
                                            SetChart(Correct_Question.CauA, Correct_Question.CauB, Correct_Question.CauC, Correct_Question.CauD);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else //
                    {
                        player.client.Close();
                        lstPlayer.Remove(player);
                        SetText(lstPlayer.Count.ToString());
                    }    
                }
            }
            catch (Exception ex)
            {
                player.client.Close();
                lstPlayer.Remove(player);
                SetText(lstPlayer.Count.ToString());
            }
        }

        void CountTheSameAnswer(string DapAn)
        {
            for (int d = 0; d < Cur_Question.ListAnswer.Count; d++)
            {
                if (DapAn.Contains(Cur_Question.ListAnswer[d]))
                {
                    if (d == 0)
                        Correct_Question.CauA++;
                    else if (d == 1)
                        Correct_Question.CauB++;
                    else if (d == 2)
                        Correct_Question.CauC++;
                    else if (d == 3)
                        Correct_Question.CauD++;
                }
            }
        }

        void ResetTheSameAnswer(string DapAn)
        {
            for (int d = 0; d < Cur_Question.ListAnswer.Count; d++)
            {
                if (DapAn.Contains(Cur_Question.ListAnswer[d]))
                {
                    if (d == 0)
                        Correct_Question.CauA--;
                    else if (d == 1)
                        Correct_Question.CauB--;
                    else if (d == 2)
                        Correct_Question.CauC--;
                    else if (d == 3)
                        Correct_Question.CauD--;
                }
            }
        }

        void Send_Chart(List<Player> lstNguoiChoi, Count demCau)
        {
            foreach (Player nguoiChoi in lstNguoiChoi)
            {
                ns = nguoiChoi.client.GetStream();
                byte[] byteTime = Utils.ObjectToByteArray(demCau);
                ns.Write(byteTime, 0, byteTime.Length);
            }
        }

        void Send_Result(bool ketQua, Player nguoiChoi)
        {
            ns = nguoiChoi.client.GetStream();
            byte[] byteTime = Utils.ObjectToByteArray(ketQua);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        private void txtCauHoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        void Message(Player pl)
        {
            string ms = "message";

            ns = pl.client.GetStream();

            byte[] byteTime = Utils.ObjectToByteArray(ms);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        private void Host_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (lstPlayer != null)
                {
                    foreach (Player item in lstPlayer)
                    {
                        if (item.client.Connected)
                        {
                            Message(item);
                            ns.Close();
                        }
                    }
                    listener.Stop();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Host close " + ex.Message);
            }
        }

        private void SendAnnounceWin(Player player)
        {
            string Announce = "Chúc Mừng Bạn Là Người Chiến Thắng";

            ns = player.client.GetStream();
            byte[] byteTime = Utils.ObjectToByteArray(Announce);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        private void GuiDanhSachDaThongKe(List<Player> lstPlayer)
        {
            foreach(Player player in lstPlayer)
            {
                ns = player.client.GetStream();
                byte[] byteTime = Utils.ObjectToByteArray(gameShow.lstThongKeKetQua);
                ns.Write(byteTime, 0, byteTime.Length);
            }    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Add file wav
            SoundPlayer simpleSound = new SoundPlayer(global::DoAnCuoiKi.Properties.Resources.fileStart);
            simpleSound.Play();

            Get_Connect();

            //LoadListSchedule();

            LoadQuestion();

            btnStart.Enabled = false;
            btnQuestion.Enabled = false;
            btnGameShow.Enabled = false;
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            frmListQuestion QLCH = new frmListQuestion();
            QLCH.Show();
        }

        private void btnGameShow_Click(object sender, EventArgs e)
        {
            frmListGameShow QLgameshow = new frmListGameShow();
            QLgameshow.ShowDialog();

            LoadListSchedule();

            kiemTraThoiGianPhatSong();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            btnWin.Enabled = true;
            frmResult Status_Result = new frmResult(this);
            Status_Result.Show();
            gameShow.ThongKeKetQua();
            foreach (Player nguoiChoi in lstPlayer)
            {
                foreach (DTOpoj.GetResult tk in gameShow.lstThongKeKetQua)
                {
                    if (nguoiChoi.ID == tk.ID)
                    {
                        tk.Name = nguoiChoi.Name;
                    }
                }
            }
            sendresult(gameShow.lstThongKeKetQua);
            btnResult.Enabled = false;
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            GuiDanhSachDaThongKe(lstPlayer);
        }

        private void btnSendChart_Click(object sender, EventArgs e)
        {
            Send_Chart(lstPlayer, Correct_Question);
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSchedule.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VideoChat(int IdPhong)
        {
            VideoChatServer.VideoDevice = 0;
            VideoChatServer.AudioDevice = 0;
            VideoChatServer.VideoFormat = 0;
            VideoChatServer.FrameRate = 25;
            VideoChatServer.VideoBitrate = 1280000;
            VideoChatServer.AudioComplexity = 0;
            VideoChatServer.AudioQuality = 8;
            VideoChatServer.SendAudioStream = true;
            VideoChatServer.SendVideoStream = true;
            VideoChatServer.ConferenceNumber = SoPhong;
            VideoChatServer.ConferenceUserID = IdPhong;
            VideoChatServer.Connect("127.0.0.1", PORT_Video);
        } 
    }
}
