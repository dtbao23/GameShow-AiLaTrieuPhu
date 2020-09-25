using DTOpoj;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmPlayer : Form
    {
        NetworkStream ns;

        TcpClient client;

        Thread t = null;
      
        int time = 15;

        int PORT_Video = 1234;

        int IdPhong = 0;

        string answer = null;
        string IP;
        //bool chart = true;

        Count count_question = null;

        List<ucAnswer> lstAnswer;

        QuestionForClient question = null;

        delegate void SetTextCallback(object obj, Control ctrl);

        delegate void SetChartCallback(int a, int b, int c, int d);

        List<GetResult> lstGetResult = null;


        public delegate void TruyenDuLieu(List<GetResult> getResults);
        public event TruyenDuLieu truyenDanhSachThongKe;

        public frmPlayer()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return IP; }
            set { IP = value; }
        }
        public frmPlayer(frmConnectToServer frm)
        {
            InitializeComponent();
            frm.getNetworkStream += new frmConnectToServer.GetNetworkStream(SetNetworkStream);
        }

        private void SetNetworkStream(NetworkStream ns, TcpClient client)
        {
            this.ns = ns;
            this.client = client;
        }

        private void Player_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            lstAnswer = new List<ucAnswer>();

            lstAnswer.Add(ucAnswer_A);
            lstAnswer.Add(ucAnswer_B);
            lstAnswer.Add(ucAnswer_C);
            lstAnswer.Add(ucAnswer_D);

            SetChart(0, 0, 0, 0);

            t = new Thread(ReceiveData);
            t.Start();

            picThoiGian.Image = Client.Properties.Resources.PVtR;
        }

        public void ReceiveData()
        {
            //VideoChat();
            byte[] bytes = new byte[1024];
            try
            {
                while (true)
                {
                    ns.Read(bytes, 0, bytes.Length);
                    object obj = Utils.ByteArrayToObject(bytes);

                    if (obj is string)
                    {
                        lblTrucTiep.Hide();//
                        MessageBox.Show("Kết nối đã ngắt");
                        client.Close();
                        ns.Close();
                    }    

                    if (obj is QuestionForClient)
                    {
                        Receive_Question(obj);
                        SetChart(0, 0, 0, 0);
                    }
                    if (obj is bool)
                    {
                        bool result = (bool)obj;
                        Receive_Result(result);
                    }
                    if (obj is int)
                    {
                        IdPhong = (int)obj;
                        VideoChat(IdPhong);
                    }   

                    if (obj is Count)
                    {
                        Receive_Chart(obj);
                    }

                    if(obj is List<GetResult>)
                    {
                        lstGetResult = (List<GetResult>)obj;
                        Receive_AnnounceWin(obj);
                    }    
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("Kết nối đã ngắt");
                timer1.Enabled = false;
                ns.Close();
            }
        }

        private void Receive_AnnounceWin(object obj)
        {          
            SetText(obj, this);
        }

        private void Receive_Question(object obj)
        {
            question = (QuestionForClient)obj;
            SetText(question.Content, txtNoiDung);
            int i = 0;
            foreach (ucAnswer item in lstAnswer)
            {
                SetText(question.DSCauTraLoi[i], item);
                i++;
            }

            EnabledUcAnswer(true);
            UnCheck(lstAnswer);
            
        }

        void Receive_Result(bool KetQua)
        {
            if (KetQua)
            {
                foreach (ucAnswer uc in lstAnswer)
                {
                    if (uc.IsAnswer)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(global::Client.Properties.Resources.fileTrue);
                        simpleSound.Play();
                        SetText(Color.Green, uc);
                    }    
                }
            }
            else
            {
                foreach (ucAnswer uc in lstAnswer)
                {
                    if (uc.IsAnswer)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(global::Client.Properties.Resources.fileFalse);
                        simpleSound.Play();
                        SetText(Color.Red, uc);
                    }                          
                }
            }
        }

        void Receive_Chart(object obj)
        {
            count_question = (Count)obj;
            SetChart(count_question.CauA, count_question.CauB, count_question.CauC, count_question.CauD);
        }

        void NhanThoiGianChoCauHoi(int tg_Maximum)
        {
            //pbThoiGian.Maximum = tg_Maximum;
        }

        private void SetText(object obj, Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                ctrl.Invoke(d, new object[] { obj, ctrl });
            }
            else
            {
                if (ctrl is TextBox)
                {
                    this.txtNoiDung.Clear();
                    this.txtNoiDung.Text = (string)obj;
                    timer1.Enabled = true;
                    
                }
                else if (ctrl is ucAnswer)
                {
                    ucAnswer uc = (ucAnswer)ctrl;
                    if (obj is string)
                    {
                        uc.Content = (string)obj;
                    }
                    else if (obj is bool)
                    {
                        uc.Enabled = (bool)obj;
                        uc.BackColor = Color.Blue;
                    }
                    else if (obj is List<ucAnswer>)
                    {
                        uc.IsAnswer = false;
                    }
                    else if (obj is Color)
                    {
                        uc.BackColor = (Color)obj;
                    }
                   
                }
                else if (ctrl is Label)
                {
                    try
                    {
                        lblThoiGian.Show();
                        int value = (int)obj;

                        if(value < 10)
                        {
                            this.lblThoiGian.Text = "0" + value.ToString();
                        }   
                        else
                            this.lblThoiGian.Text = value.ToString();
                        
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }              
                else if (ctrl is Form)
                {                   
                    if(obj is List<GetResult>)
                    {
                        this.Hide();
                        frmWinner frmwinner = new frmWinner(this);
                        truyenDanhSachThongKe(lstGetResult);
                        frmwinner.ShowDialog();
                        this.Close();
                    }  
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picThoiGian.Enabled = true;
            if (time == 0)
            {
                EnabledUcAnswer(false);

                answer = null;
                foreach (ucAnswer uc in lstAnswer)
                {
                    if (uc.IsAnswer)
                    {
                        answer += uc.Content;
                    }
                }
                if (answer == null)
                {
                    answer = "";
                }


                SetText(time, lblThoiGian);

                Send_Result();
                timer1.Enabled = false;

                

                time = 15;
                
                picThoiGian.Enabled = false;
            }
            else
            {
                time--;
                lblThoiGian.Hide();
                SetText(time, lblThoiGian);
            }
        }

        void UnCheck(List<ucAnswer> ds_ucAnswer)
        {
            foreach (ucAnswer uc in ds_ucAnswer)
            {
                SetText(ds_ucAnswer, uc);
            }
        }

        void EnabledUcAnswer(bool b)
        {
            foreach (ucAnswer uc in lstAnswer)
            {
                SetText(b, uc);
            }
        }

        private void Send_Result()
        {
            byte[] byteTime = Utils.ObjectToByteArray(answer);

            ns.Write(byteTime, 0, byteTime.Length);
        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
            ns.Close();
        }

        private void fillChart(int a, int b, int c, int d)
        {
            Chart_Result.Series["SoNguoiTraLoi"].Points.Clear();
            Chart_Result.Series["SoNguoiTraLoi"].Points.AddXY("A", a);
            Chart_Result.Series["SoNguoiTraLoi"].Points.AddXY("B", b);
            Chart_Result.Series["SoNguoiTraLoi"].Points.AddXY("C", c);
            Chart_Result.Series["SoNguoiTraLoi"].Points.AddXY("D", d);
        }

        void SetChart(int a, int b, int c, int d)
        {
            if (this.Chart_Result.InvokeRequired)
            {
                SetChartCallback chart = new SetChartCallback(SetChart);
                this.Invoke(chart, new object[] { a, b, c, d });
            }
            else
            {
                fillChart(a, b, c, d);
                
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VideoChat(int IdPhong)
        {
            VideoChatClient.ReceiveAudioStream = true;
            VideoChatClient.ReceiveVideoStream = true;

            VideoChatClient.VideoWindowAutoMax = true;

            VideoChatClient.ConferenceNumber = 5000;
            VideoChatClient.ConferenceUserID = IdPhong;

            VideoChatClient.Listen(IP, PORT_Video);
        }
    }
}
