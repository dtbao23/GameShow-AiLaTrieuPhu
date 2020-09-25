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

namespace Client
{
    public partial class frmHuongDang : Form
    {
        string Path_HuongDanCachChoi = "../../../HuongDanCachChoi.txt";
        public frmHuongDang()
        {
            InitializeComponent();
        }
        private void frmHuongDang_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Path_HuongDanCachChoi);           
            string line = null;
            lblContent.Text = "";
            while ((line = sr.ReadLine()) != null)
            {
                lblContent.Text += line+"\n";
            }           
            sr.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
