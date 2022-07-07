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
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
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
                    if (cli.Status == true)
                        lv.BackColor = Color.FromArgb(148, 255, 176); ;
                    lv.SubItems.Add(cli.Name);
                    if(cli.Cpf != "")
                        lv.SubItems.Add(FormatCPF(cli.Cpf));
                    else
                        lv.SubItems.Add(cli.Cpf);
                    lv.SubItems.Add(cli.Email);
                    lv.SubItems.Add(cli.Fone);
                    ltvShowClient.Items.Add(lv);
                }
            }
        }
        public static string FormatCPF(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
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


            Client client = new Client(id, name, cpf, email, fone);
            FrmEditClient frmEditClient = new FrmEditClient(client);
            frmEditClient.ShowDialog();
            if (client.Status)
                UpdateListView();
            else
                ckbStatus_CheckedChanged(sender, e);
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
            FrmClient client = new FrmClient();
            client.ShowDialog();
            UpdateListView();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            FrmReportClient client = new FrmReportClient();
            client.ShowDialog();
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
                        if (cli.Status == false)
                            lv.BackColor = Color.FromArgb(255, 150, 143);
                        else
                            lv.BackColor = Color.FromArgb(148, 255, 176);
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
        private void ltvShowClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltvShowClient_MouseDoubleClick(sender, null);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmConsultClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnGetReport_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnRegister_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStatus.Checked == true)
            {
                ltvShowClient.Items.Clear();
                ClientDAO clientDao = new ClientDAO();

                List<Client> clients = clientDao.ListAllClients();
                if (clients.Count > 0)
                {
                    foreach (var cli in clients)
                    {

                        ListViewItem lv = new ListViewItem(cli.Id.ToString());
                        if (cli.Status == false)
                            lv.BackColor = Color.FromArgb(255, 150, 143);
                        else
                            lv.BackColor = Color.FromArgb(148, 255, 176);
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
            txbSearch.Clear();
            txbSearch.Select();
            UpdateListView();
        }
    }
}