using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.View
{
    public partial class FrmSelectDateOrder : Form
    {
        public FrmSelectDateOrder()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {

            FrmReportOrder order = new FrmReportOrder(dtpDateOrder1.Value, dtpDateOrder2.Value);
            order.ShowDialog();
        }
    }
}
