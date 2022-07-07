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
    public partial class FrmEditAdm : Form
    {
        public Adm AdmProp { get; set; }
        public FrmEditAdm(Adm adm)
        {
            AdmProp = adm;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = AdmProp.Id;
            string login = txbLogin.Text;
            string name = txbName.Text;
            string password = txbPassword.Text;

            try
            {
                AdmDAO admDAO = new AdmDAO();
                Adm adm = new Adm(id ,login, name, password);
                admDAO.Update(adm);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbName.Focus();
                if (err.Message.ToUpper().Contains("Login"))
                    txbLogin.Focus();
                if (err.Message.ToUpper().Contains("Nome"))
                    txbName.Focus();
                if (err.Message.ToUpper().Contains("Senha"))
                    txbPassword.Focus();

                return;
            }
            MessageBox.Show("Administrador Alterado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdmDAO admDao = new AdmDAO();

            try
            {
                admDao.Delete(AdmProp.Id);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Administrador Excluido!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmEditAdm_Load(object sender, EventArgs e)
        {
            txbLogin.Text = AdmProp.Login;
            txbName.Text = AdmProp.Name;
            txbPassword.Text = AdmProp.Password;
        }
    }
}
