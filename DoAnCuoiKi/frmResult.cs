using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class frmResult : Form
    {
        delegate void SetTextCallback(List<DTOpoj.GetResult> lst);
        public frmResult()
        {
            InitializeComponent();
        }
        public frmResult(frmHost frmHost)
        {
            InitializeComponent();
            frmHost.sendresult += new frmHost.SendResult(SetText);
        }
        private void SetText(List<DTOpoj.GetResult> lst)
        {          
            if (this.dgvResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.dgvResult.Invoke(d, new object[] { lst });
            }
            else
            {
                this.dgvResult.DataSource = lst;
            }
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvResult.ReadOnly = true;
        }
    }
}
