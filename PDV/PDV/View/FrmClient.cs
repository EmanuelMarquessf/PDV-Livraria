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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string cpf = mtbCpf.Text;
            string email = txbEmail.Text;
            string fone = mtbFone.Text;

            try
            {
                ClientDAO clientDAO = new ClientDAO();
                Client client = new Client(name, cpf, email, fone);
                clientDAO.Insert(client);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbName.Focus();
                if (err.Message.ToUpper().Contains("Nome"))
                    txbName.Focus();
                if (err.Message.ToUpper().Contains("CPF"))
                    mtbCpf.Focus();
                if (err.Message.ToUpper().Contains("Email"))
                    txbEmail.Focus();
                if (err.Message.ToUpper().Contains("Telefone"))
                    mtbFone.Focus();
                return;
            }
            MessageBox.Show("Cliente Cadastrado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            mtbCpf.Clear();
            txbEmail.Clear();
            mtbFone.Clear();
            txbName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = txbName.Text;
                string cpf = mtbCpf.Text;
                string email = txbEmail.Text;
                string fone = mtbFone.Text;

                try
                {
                    ClientDAO clientDAO = new ClientDAO();
                    Client client = new Client(name, cpf, email, fone);
                    clientDAO.Insert(client);
                }
                catch (Exception err)
                {
                    MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbName.Focus();
                    if (err.Message.ToUpper().Contains("Nome"))
                        txbName.Focus();
                    if (err.Message.ToUpper().Contains("CPF"))
                        mtbCpf.Focus();
                    if (err.Message.ToUpper().Contains("Email"))
                        txbEmail.Focus();
                    if (err.Message.ToUpper().Contains("Telefone"))
                        mtbFone.Focus();
                    return;
                }
                MessageBox.Show("Cliente Cadastrado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
