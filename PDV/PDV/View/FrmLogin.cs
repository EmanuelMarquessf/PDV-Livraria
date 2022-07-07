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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            { 
                Adm adm = new Adm(txbLogin.Text, Security.ComputeSha256Hash(txbPassword.Text));
                AdmDAO admDao = new AdmDAO();
                if (admDao.ValidateLogin(adm))
                {
                    this.Visible = false;
                    Client client = new Client(0, " ");
                    FrmCart frmCart = new FrmCart(client);
                    frmCart.ShowDialog();
                    this.Visible = true;
                    btnClear_Click(null, null);
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
         private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
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
    }
}
