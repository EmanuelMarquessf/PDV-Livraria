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
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }

        private void UpdateListView()
        {
            ltvShowAdm.Items.Clear();
            AdmDAO admDao = new AdmDAO();

            List<Adm> adms = admDao.ListAllAdmsStatus();
            if (adms.Count > 0)
            {
                foreach (var adm in adms)
                {
                    ListViewItem lv = new ListViewItem(adm.Id.ToString());
                    if (adm.Status == false)
                        lv.BackColor = Color.FromArgb(255, 150, 143);
                    else
                        lv.BackColor = Color.FromArgb(148, 255, 176);
                    lv.SubItems.Add(adm.Login);
                    lv.SubItems.Add(adm.Name);
                    lv.SubItems.Add(adm.Password);
                    lv.SubItems.Add(adm.Office);
                    ltvShowAdm.Items.Add(lv);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmAdm adm = new FrmAdm();
            adm.ShowDialog();
            UpdateListView();
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
            string office = ltvShowAdm.Items[ltvShowAdm.FocusedItem.Index].SubItems[4].Text;

            Adm adm = new Adm(id ,login, name, password, office);
            if(adm.Id == 1) 
            {
                MessageBox.Show("Não é possivel modificar este usuário!!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FrmEditAdm frmEditAdm = new FrmEditAdm(adm);
                frmEditAdm.ShowDialog();
                if (adm.Status)
                    UpdateListView();
                else
                    ckbStatus_CheckedChanged(sender, e);
            }       
        }
        private void ltvShowAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltvShowAdm_DoubleClick(sender, e);
            }
        }
        private void FrmConsultAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnRegister_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if(txbSearch.Text.Length > 2) 
            { 
                ltvShowAdm.Items.Clear();
                AdmDAO admDao = new AdmDAO();

                List<Adm> adms = admDao.ListSearchAdms(txbSearch.Text);
                if (adms.Count > 0)
                {
                    foreach (var adm in adms)
                    {
                        ListViewItem lv = new ListViewItem(adm.Id.ToString());
                        if (adm.Status == false)
                            lv.BackColor = Color.FromArgb(255, 150, 143);
                        else
                            lv.BackColor = Color.FromArgb(148, 255, 176);
                        lv.SubItems.Add(adm.Login);
                        lv.SubItems.Add(adm.Name);
                        lv.SubItems.Add(adm.Password);
                        lv.SubItems.Add(adm.Office);
                        ltvShowAdm.Items.Add(lv);
                    }
                }
            }
            else
            {
                UpdateListView();
            }
        }

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbStatus.Checked == true)
            {
                ltvShowAdm.Items.Clear();
                AdmDAO admDao = new AdmDAO();

                List<Adm> adms = admDao.ListAllAdms();
                if (adms.Count > 0)
                {
                    foreach (var adm in adms)
                    {
                        ListViewItem lv = new ListViewItem(adm.Id.ToString());
                        if (adm.Status == false)
                            lv.BackColor = Color.FromArgb(255, 150, 143);
                        else
                            lv.BackColor = Color.FromArgb(148, 255, 176);
                        lv.SubItems.Add(adm.Login);
                        lv.SubItems.Add(adm.Name);
                        lv.SubItems.Add(adm.Password);
                        lv.SubItems.Add(adm.Office);
                        ltvShowAdm.Items.Add(lv);
                    }
                }
            }
            else
            {
                UpdateListView();
            }
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateListView();
            txbSearch.Clear();
            txbSearch.Select();
        }
    }
}
