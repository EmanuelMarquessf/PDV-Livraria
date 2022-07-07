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
    public partial class FrmEditClient : Form
    {

        public Client ClientProp { get; set; }

        public FrmEditClient(Client client)
        {
            ClientProp = client;
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = ClientProp.Id;
            string name = txbName.Text;
            string cpf = mtbCpf.Text;
            string email = txbEmail.Text;
            string fone = mtbFone.Text;
            string status = cbbStatus.Text;
            bool statusAux;
            if (status == "Ativo")
                statusAux = true;
            else
                statusAux = false;


            try
            {
                ClientDAO clientDAO = new ClientDAO();
                Client client = new Client(id, name, cpf, email, fone, statusAux);
                clientDAO.Update(client);
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
            MessageBox.Show("Dados Alterados!!", "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
        private void FrmEditClient_Load(object sender, EventArgs e)
        {
            ClientDAO clientDAO = new ClientDAO();
            Client selectedClient = new Client(ClientProp.Id);
            selectedClient = clientDAO.AddClient(ClientProp.Id);

            txbName.Text = selectedClient.Name;
            mtbCpf.Text = selectedClient.Cpf;
            txbEmail.Text = selectedClient.Email;
            mtbFone.Text = selectedClient.Fone;
            if (selectedClient.Status == true)
                cbbStatus.SelectedIndex = 0;
            else if (selectedClient.Status == false)
                cbbStatus.SelectedIndex = 1;
        }

        private void FrmEditClient_KeyDown(object sender, KeyEventArgs e)
        {
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
