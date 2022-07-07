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
    public partial class FrmSelectPayForm : Form
    {
        private string _selectedPayForm = null;
        public Order OrderProp { get; set; }

        public FrmSelectPayForm(float amount)
        {
            InitializeComponent();
            txbTotalValue.Text = amount.ToString("F2");
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
            cbbPagament.SelectedIndex = 0;

        }
        public string SelectPayForm
        {
            get
            {
                return _selectedPayForm;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string payForm = cbbPagament.Text;
            string selectedPayForm = payForm;
            _selectedPayForm = selectedPayForm;
            this.Close();
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedPayForm = null;
            this.Close();
        }

        private void cbbPagament_SelectedIndexChanged_1(object sender, EventArgs e)
        
        {
            if (cbbPagament.SelectedIndex == 0)
            {
                cbbPagament.Text = "Dinheiro";
            }
            else if (cbbPagament.SelectedIndex == 1)
            {
                cbbPagament.Text = "Cartao de Credito";
            }
            else if (cbbPagament.SelectedIndex == 2)
            {
                cbbPagament.Text = "Cartao de Debito";
            }
            else if (cbbPagament.SelectedIndex == 3)
            {
                cbbPagament.Text = "Pix";
            } 
        }
        private void cbbPagament_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbReceivedValue.Text = txbTotalValue.Text;
                txbReceivedValue.Select();
            }
        }
        private void txbReceivedValue_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                float total, received, change;
                received = float.Parse(txbReceivedValue.Text);
                total = float.Parse(txbTotalValue.Text);
                change = total - received;
                if (float.Parse(txbReceivedValue.Text) >= float.Parse(txbTotalValue.Text))
                {
                    txbValueChange.Text = (change * -1).ToString("F2");
                    btnSave.Enabled = true;
                    btnSave.Select();
                }
                else
                {
                    MessageBox.Show("Valor recebido menor que o valor da venda!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbReceivedValue.Text = txbReceivedValue.Text;
                    cbbPagament.Select();
                }
            }
        }
        private void txbValueChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Enabled = true;
                btnSave.Select();
            }
        }
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void FrmSelectPayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _selectedPayForm = null;
                this.Close();
            }
        }

        private void txbReceivedValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
