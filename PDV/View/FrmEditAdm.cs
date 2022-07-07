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
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = AdmProp.Id;
            string login = txbLogin.Text;
            string name = txbName.Text;
            string office = cbbOffice.Text;
            string status = cbbStatus.Text;
            bool statusAux;
            if (status == "Ativo")
                statusAux = true;
            else
                statusAux = false;

            try
            {
                AdmDAO admDAO = new AdmDAO();
                Adm adm = new Adm(id ,login, name, AdmProp.Password, office, statusAux);
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

                return;
            }
            MessageBox.Show("Administrador Alterado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditAdm_Load(object sender, EventArgs e)
        {
            AdmDAO admDAO = new AdmDAO();
            Adm selectedAdm = new Adm(AdmProp.Id);
            selectedAdm = admDAO.AddAdm(AdmProp.Id);

            txbLogin.Text = selectedAdm.Login;
            txbName.Text = selectedAdm.Name;
            cbbOffice.Text = selectedAdm.Office;
            if (selectedAdm.Status == true)
                cbbStatus.SelectedIndex = 0;
            else if (selectedAdm.Status == false)
                cbbStatus.SelectedIndex = 1;

        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmEditPasswordAdm adm = new FrmEditPasswordAdm(AdmProp);
            adm.ShowDialog();
            this.Close();
        }

        private void FrmEditAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnChangePassword_Click(sender,e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnSave_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        
        }
    }
}
