using PDV.Model;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }

        private void BtnBookMenuItem_Click(object sender, EventArgs e)
        {
            BtnBookMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultBook book = new FrmConsultBook("Administrador");
            book.ShowDialog();

            BtnBookMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void btnClientMenuItem_Click(object sender, EventArgs e)
        {
            btnClientMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultClient client = new FrmConsultClient();
            client.ShowDialog();

            btnClientMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void btnAdmMenuItem_Click(object sender, EventArgs e)
        {
            btnAdmMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultAdm adm = new FrmConsultAdm();
            adm.ShowDialog();

            btnAdmMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnClientMenuItem.BackColor = Color.DarkSeaGreen;

            this.Visible = false;
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            this.Visible = true;

            btnClientMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void btnOrderMenuItem_Click(object sender, EventArgs e)
        {
            btnClientMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultOrder order = new FrmConsultOrder();
            order.ShowDialog();

            btnClientMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnReportMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnClientMenuItem_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2)
            {
                BtnBookMenuItem_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                btnAdmMenuItem_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                btnOrderMenuItem_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
