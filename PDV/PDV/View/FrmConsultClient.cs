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
    public partial class FrmConsultClient : Form
    {
        public FrmConsultClient()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            ltvShowClient.Items.Clear();
            ClientDAO clientDao = new ClientDAO();

            List<Client> clients = clientDao.ListAllClients();
            if (clients.Count > 0)
            {
                foreach (var cli in clients)
                {
                    ListViewItem lv = new ListViewItem(cli.Id.ToString());
                    lv.SubItems.Add(cli.Name);
                    lv.SubItems.Add(cli.Cpf);
                    lv.SubItems.Add(cli.Email);
                    lv.SubItems.Add(cli.Fone);
                    ltvShowClient.Items.Add(lv);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ltvShowClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[0].Text);
            string name = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[1].Text;
            string cpf = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[2].Text;
            string email = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[3].Text;
            string fone = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[4].Text;

            this.Visible = false;

            Client client = new Client(id, name, cpf, email, fone);
            FrmEditClient frmEditClient = new FrmEditClient(client);
            frmEditClient.ShowDialog();
            UpdateListView();
            this.Visible = true;
        }

        public void FrmClient_Load_1(object sender, EventArgs e)
        {
            try
            {
                UpdateListView();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmClient client = new FrmClient();
            client.ShowDialog();
            UpdateListView();
            this.Visible = true;
        }

        private void ltvShowClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = int.Parse(ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[0].Text);
                string name = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[1].Text;
                string cpf = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[2].Text;
                string email = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[3].Text;
                string fone = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[4].Text;

                this.Visible = false;

                Client client = new Client(id, name, cpf, email, fone);
                FrmEditClient frmEditClient = new FrmEditClient(client);
                frmEditClient.ShowDialog();
                UpdateListView();
                this.Visible = true;
            }
        }
    }
}
