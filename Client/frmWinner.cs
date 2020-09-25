using DTOpoj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmWinner : Form
    {

        List<GetResult> lst = null;
        public frmWinner()
        {
            InitializeComponent();
        }

        public frmWinner(frmPlayer frm)
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(global::Client.Properties.Resources.winner2);
            player.Play();
            frm.truyenDanhSachThongKe += new frmPlayer.TruyenDuLieu(LayDanhSach);
        }

        private void LayDanhSach(List<GetResult> getResults)
        {
            lst = getResults;
            if(lst.Count >= 3)
            {
                if(lst[0].SoCauDung == lst[1].SoCauDung && lst[1].SoCauDung == lst[2].SoCauDung)
                {
                    lblHangNhat.Text = lst[0].Name + " - " + lst[1].Name + " - " + lst[2].Name;
                    lblHangHai.Hide();
                    lblHangBa.Hide();
                }
                if(lst[0].SoCauDung == lst[1].SoCauDung && lst[0].SoCauDung > lst[2].SoCauDung)
                {
                    lblHangNhat.Text = lst[0].Name  + " - " + lst[1].Name;
                    lblHangHai.Text = lst[2].Name;
                    lblHangBa.Hide();
                }
                if(lst[0].SoCauDung > lst[1].SoCauDung && lst[1].SoCauDung == lst[2].SoCauDung)
                {
                    lblHangNhat.Text = lst[0].Name;
                    lblHangHai.Text = lst[1].Name + " - " + lst[2].Name;
                    lblHangBa.Hide();
                }   
                if(lst[0].SoCauDung != lst[1].SoCauDung && lst[1].SoCauDung != lst[2].SoCauDung && lst[0].SoCauDung != lst[2].SoCauDung)
                {
                    lblHangNhat.Text = lst[0].Name;
                    lblHangHai.Text = lst[1].Name;
                    lblHangBa.Text = lst[2].Name;
                }    
            }
            else if (lst.Count == 2)
            {
                if(lst[0].SoCauDung == lst[1].SoCauDung)
                {
                    lblHangNhat.Text = lst[0].Name + " - " + lst[1].Name;
                    lblHangHai.Hide();
                    lblHangBa.Hide();
                }
                else
                {
                    lblHangNhat.Text = lst[0].Name;
                    lblHangHai.Text = lst[1].Name;
                    lblHangBa.Hide();
                }    
            }
            else if (lst.Count == 1)
            {
                lblHangNhat.Text = lst[0].Name;
                lblHangHai.Hide();
                lblHangBa.Hide();
            }
            else
            {
                lblHangNhat.Hide();
                lblHangHai.Hide();
                lblHangBa.Hide();
            }    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
