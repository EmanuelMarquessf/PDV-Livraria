using PDV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.View
{
    public partial class FrmConsultOrder : Form
    {
        public FrmConsultOrder()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }

        private void pDVDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultOrder_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pDVDataSet.Order'. Você pode movê-la ou removê-la conforme necessário.
            this.orderTableAdapter.Fill(this.pDVDataSet.Order);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGetReport_Click(object sender, EventArgs e)
        {
            btnGetReport.BackColor = Color.DarkSeaGreen;

            FrmSelectDateOrder date = new FrmSelectDateOrder();
            date.ShowDialog();

            btnGetReport.BackColor = Color.WhiteSmoke;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void orderBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
           if(txbSearch.Text.Length > 0 && Regex.IsMatch(txbSearch.Text, @"^[0-9]+$")) { 
               OrderDAO orderDao = new OrderDAO();
               dataGridView1.DataSource = orderDao.DisplayAndSearch(int.Parse(txbSearch.Text));
           }
            else {
                OrderDAO orderDao = new OrderDAO();
                dataGridView1.DataSource = orderDao.DisplayAndSearchNull();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
            txbSearch.Select();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string cpf = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string func = dataGridView1.Rows[index].Cells[4].Value.ToString();
            DateTime date = DateTime.Parse(dataGridView1.Rows[index].Cells[5].Value.ToString());
            string payForm = dataGridView1.Rows[index].Cells[6].Value.ToString();
            float amount = float.Parse(dataGridView1.Rows[index].Cells[7].Value.ToString());

            FrmViewOrder frmViewOrder = new FrmViewOrder(id, name, cpf, func, date, payForm, amount);
            frmViewOrder.ShowDialog();
        }

        private void FrmConsultOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string cpf = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string func = dataGridView1.Rows[index].Cells[4].Value.ToString();
            DateTime date = DateTime.Parse(dataGridView1.Rows[index].Cells[5].Value.ToString());
            string payForm = dataGridView1.Rows[index].Cells[6].Value.ToString();
            float amount = float.Parse(dataGridView1.Rows[index].Cells[7].Value.ToString());
            FrmViewOrder frmViewOrder = new FrmViewOrder(id, name, cpf, func, date, payForm, amount);
            frmViewOrder.ShowDialog();

        }
    }
}
