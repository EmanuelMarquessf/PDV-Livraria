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
    public partial class FrmAddClient : Form
    {
        private Client _selectedClient = null;
        public FrmAddClient()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }
        public Client SelectedClient
        {
            get
            {
                return _selectedClient;
            }
        }
        private void UpdateListView()
        {
            ltvShowClient.Items.Clear();
            ClientDAO clientDao = new ClientDAO();

            List<Client> clients = clientDao.ListAllClientsStatus();
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
        public void FrmAddClient_Load(object sender, EventArgs e)
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNothing_Click(object sender, EventArgs e)
        {
            Client client = new Client(1, " ");
            _selectedClient = client;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmClient client = new FrmClient();
            client.ShowDialog();
            UpdateListView();
        }

        private void ltvShowClient_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[0].Text);
            string name = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[1].Text;

            int index = ltvShowClient.FocusedItem.Index;
            Client client = new Client(id, name);
            _selectedClient = client;
            this.Close();
        }

        private void ltvShowClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltvShowClient_DoubleClick(sender, e);
            }
            if (e.KeyCode == Keys.E)
            {
                int id = int.Parse(ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[0].Text);
                string name = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[1].Text;
                string cpf = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[2].Text;
                string email = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[3].Text;
                string fone = ltvShowClient.Items[ltvShowClient.FocusedItem.Index].SubItems[4].Text;


                Client client = new Client(id, name, cpf, email, fone);
                FrmEditClient frmEditClient = new FrmEditClient(client);
                frmEditClient.ShowDialog();
                UpdateListView();
            }

        }
        private void FrmAddClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnRegister_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnNothing_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                btnNothing_Click(sender, e);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbSearch.Text.Length > 2)
            {
                ltvShowClient.Items.Clear();
                ClientDAO clientDao = new ClientDAO();
                
                List<Client> clients = clientDao.ListSearchClients(txbSearch.Text);
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
            else
            {
                UpdateListView();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateListView();
            txbSearch.Clear();
            txbSearch.Select();
        }
    }
}
