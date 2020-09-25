using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ucAnswer : UserControl
    {
        public ucAnswer()
        {
            InitializeComponent();
        }
        public string Title
        {
            get
            {
                return chkThuTu.Text;
            }
            set
            {
                chkThuTu.Text = value;
            }
        }
        public string Content
        {
            get
            {
                return txtNoiDung.Text;
            }
            set
            {
                txtNoiDung.Text = value;
            }
        }
        public bool IsAnswer
        {
            get
            {
                return chkThuTu.Checked;
            }
            set
            {
                chkThuTu.Checked = value;
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
