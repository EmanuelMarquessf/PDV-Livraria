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
            Client client = new Client(0, " ");
            _selectedClient = client;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmClient client = new FrmClient();
            client.ShowDialog();
            UpdateListView();
            this.Visible = true;
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
    }
}
