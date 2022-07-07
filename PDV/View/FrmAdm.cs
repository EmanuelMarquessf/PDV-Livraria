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
    public partial class FrmAdm : Form
    {
        public FrmAdm()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
            cbbOffice.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txbLogin.Text;
            string name = txbName.Text;
            string password = Security.ComputeSha256Hash(txbPassword.Text);
            string office = cbbOffice.Text;
            

            try
            {
                AdmDAO admDAO = new AdmDAO();
                Adm adm = new Adm(email, name, password, office, true);
                if(txbPassword.Text == txbConfirmPassword.Text)
                {
                    admDAO.Insert(adm);
                    MessageBox.Show("Administrador Cadastrado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"As senhas não coincidem!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbConfirmPassword.Select();
                }
                    
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbName.Focus();
                if (err.Message.ToUpper().Contains("Email"))
                    txbLogin.Focus();
                if (err.Message.ToUpper().Contains("Nome"))
                    txbName.Focus();
                if (err.Message.ToUpper().Contains("Senha"))
                    txbPassword.Focus();

                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbOffice.SelectedIndex == 0)
            {
                cbbOffice.Text = "Administrador";
            }
            else if (cbbOffice.SelectedIndex == 1)
            {
                cbbOffice.Text = "Estoquista";
            }
            else if (cbbOffice.SelectedIndex == 2)
            {
                cbbOffice.Text = "Atendente";
            }
        }

        private void FrmAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            txbLogin.Clear();
            txbPassword.Clear();
            txbConfirmPassword.Clear();
        }
    }
}
