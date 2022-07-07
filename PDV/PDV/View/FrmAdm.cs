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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txbLogin.Text;
            string name = txbName.Text;
            string password = Security.ComputeSha256Hash(txbPassword.Text);

            try
            {
                AdmDAO admDAO = new AdmDAO();
                Adm adm = new Adm(email, name, password);
                admDAO.Insert(adm);
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
            MessageBox.Show("Administrador Cadastrado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
