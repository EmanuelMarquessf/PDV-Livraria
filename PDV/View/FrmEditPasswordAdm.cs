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
    public partial class FrmEditPasswordAdm : Form
    {
        public Adm AdmProp { get; set; }
        public FrmEditPasswordAdm(Adm adm)
        {
            AdmProp = adm;
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                int id = AdmProp.Id;
                string newPassword = Security.ComputeSha256Hash(txbNewPassword1.Text);

                try
                {
                    if(AdmProp.Password == Security.ComputeSha256Hash(txbActualPassword.Text)) { 
                        if (txbNewPassword1.Text == txbNewPassword2.Text && txbNewPassword1.Text.Length > 0)
                        {
                            AdmDAO admDAO = new AdmDAO();
                            Adm adm = new Adm(id, newPassword);
                            admDAO.UpdatePassword(adm);
                            MessageBox.Show($"Senha alterada com sucesso!!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else 
                        {
                            MessageBox.Show($"As senhas não coincidem!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    }
                    else
                        MessageBox.Show($"Senha incorreta!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);             

                }
                catch (Exception err)
                {
                    MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
