using DTOpoj;
using Guna.UI2.WinForms;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmConnectToServer : Form
    {        
        int PORT = 5000;

        string IP = null;

        TcpClient client = new TcpClient();

        NetworkStream ns;

        Thread t = null;

        DTOpoj.Player player = new DTOpoj.Player();

        public delegate void GetNetworkStream(NetworkStream ns, TcpClient client);
        public event GetNetworkStream getNetworkStream;

        delegate void SetTextCallback(string text);

        public frmConnectToServer()
        {
            InitializeComponent();
        }           

        bool KetNoiServer()
        {
            try
            {
                client.Connect(IPAddress.Parse(IP), PORT);           
                ns = client.GetStream();
                if (ns == null)
                {
                    MessageBox.Show("Không thể kết nối");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối");
            }
            return false;
            
        }

        private void SendRegistration()
        {
            byte[] byteTime = Utils.ObjectToByteArray(player.Name);
            ns.Write(byteTime, 0, byteTime.Length);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            player.Name = txtName.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }
        private void txtIPAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtIPAddress.Text == "IP Address")
            {
                txtIPAddress.Text = "";
                txtIPAddress.ForeColor = Color.Black;
            }    
            
        }
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "User Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }    
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Guna2TextBox)
                {
                    Guna2TextBox tb = (Guna2TextBox)ctrl;
                    if (string.IsNullOrEmpty(tb.Text) || tb.Text == "IP Address" || tb.Text == "User Name")
                    {
                        tb.Text = "";
                        tb.Focus();
                        MessageBox.Show("Thông tin không đúng, Vui lòng nhập lại");
                        return;
                    }
                }
            }
            if (KetNoiServer())
            {
                try
                {
                    SendRegistration();
                    frmPlayer player = new frmPlayer(this);
                    this.Hide();
                    getNetworkStream(ns, client);
                    player.Message = IP;
                    player.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in connect to server" + ex.Message);
                }
            }
        }

        private void txtIPAddress_TextChanged(object sender, EventArgs e)
        {
            IP = txtIPAddress.Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }
    }
}
