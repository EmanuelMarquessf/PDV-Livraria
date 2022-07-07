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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string description = txbDescription.Text;
            int quant = int.Parse(nmcQuant.Text);
            float value = float.Parse(txbValue.Text);

            try
            {
                ProductDAO productDao = new ProductDAO();
                Product product = new Product(description, quant, value);
                productDao.Insert(product);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDescription.Focus();
                if (err.Message.ToUpper().Contains("Descricao"))
                    txbDescription.Focus();
                if (err.Message.ToUpper().Contains("Quantidade"))
                    nmcQuant.Focus();
                if (err.Message.ToUpper().Contains("Valor"))
                    txbValue.Focus();
                return;
            }
            MessageBox.Show("Produto Cadastrado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbDescription.Clear();
            nmcQuant.Value = 0;
            txbValue.Clear();
        }

        private void FrmCostumer_Load(object sender, EventArgs e)
        {

        }
    }
}
