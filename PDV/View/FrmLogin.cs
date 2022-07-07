using PDV.Model;
using PDV.Utils;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
            txbLogin.Select();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            { 
                Adm adm = new Adm(1 ,txbLogin.Text, Security.ComputeSha256Hash(txbPassword.Text));
                AdmDAO admDao = new AdmDAO();
                adm = admDao.ValidateLogin(adm);
                if (adm.Id > 0)
                {
                    if (adm.Status) { 
                        this.Visible = false;
                        Client client = new Client(1, " ");
                        if(adm.Office == "Estoquista")
                        {
                            FrmConsultBook frmConsultBook = new FrmConsultBook(adm.Office);
                            frmConsultBook.ShowDialog();
                        }
                        else{
                            FrmCart frmCart = new FrmCart(client, adm);
                            frmCart.ShowDialog();
                        }
                        this.Visible = true;
                        txbLogin.Select();
                        btnClear_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Funcionário inativo!!", "CONTA INATIVADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique novamente suas credenciais!!", "Credenciais Incorretas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ccbViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txbPassword.PasswordChar.Equals('*'))
                txbPassword.PasswordChar = '\0';
            else
                txbPassword.PasswordChar = '*';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbLogin.Clear();
            txbPassword.Clear();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FrmConsultBookClient consultBookClient = new FrmConsultBookClient();
            consultBookClient.ShowDialog();
        }
    }
}
