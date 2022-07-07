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
    public partial class FrmLoad : Form
    {
        public FrmLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbLoad.Value < 100)
            {
                Random rnd = new Random();
                int number = rnd.Next(5, 10);
                pgbLoad.Value += pgbLoad.Value + number > 100? 100 - pgbLoad.Value : number;
            }
            else
            {
                timer1.Stop();
                FrmLogin frmLogin = new FrmLogin();
                this.Visible = false;
                frmLogin.ShowDialog();
            }
        }

    }
}
