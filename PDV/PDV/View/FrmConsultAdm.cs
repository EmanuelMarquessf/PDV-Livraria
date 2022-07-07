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
    public partial class FrmConsultAdm : Form
    {
        public FrmConsultAdm()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            ltvShowAdm.Items.Clear();
            AdmDAO admDao = new AdmDAO();

            List<Adm> adms = admDao.ListAllAdms();
            if (adms.Count > 0)
            {
                foreach (var adm in adms)
                {
                    ListViewItem lv = new ListViewItem(adm.Id.ToString());
                    lv.SubItems.Add(adm.Login);
                    lv.SubItems.Add(adm.Name);
                    lv.SubItems.Add(adm.Password);
                    ltvShowAdm.Items.Add(lv);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmAdm adm = new FrmAdm();
            adm.ShowDialog();
            UpdateListView();
            this.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultAdm_Load(object sender, EventArgs e)
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
        private void ltvShowAdm_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(ltvShowAdm.Items[ltvShowAdm.FocusedItem.Index].SubItems[0].Text);
            string login = ltvShowAdm.Items[ltvShowAdm.FocusedItem.Index].SubItems[1].Text;
            string name = ltvShowAdm.Items[ltvShowAdm.FocusedItem.Index].SubItems[2].Text;
            string password = ltvShowAdm.Items[ltvShowAdm.FocusedItem.Index].SubItems[3].Text;

            this.Visible = false;

            Adm adm = new Adm(id ,login, name, password);
            FrmEditAdm frmEditAdm = new FrmEditAdm(adm);
            frmEditAdm.ShowDialog();
            UpdateListView();
            this.Visible = true;
        }
    }
}
