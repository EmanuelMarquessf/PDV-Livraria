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
    public partial class FrmEditProduct : Form
    {
        public Product ProductProp { get; set; }
        public FrmEditProduct()
        {
            InitializeComponent();
        }

        public FrmEditProduct(Product product)
        {
            ProductProp = product;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = ProductProp.Id;
            string description = txbDescription.Text;
            int quant = int.Parse(nmcQuant.Text);
            float value = float.Parse(txbValue.Text);

            try
            {
                ProductDAO productDAO = new ProductDAO();
                Product product = new Product(id, description, quant, value);
                productDAO.Update(product);
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
            MessageBox.Show("Dados Alterados!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDAO productDao = new ProductDAO();

            try
            {
                productDao.Delete(ProductProp.Id);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Produti Excluido!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbDescription.Clear();
            nmcQuant.Value = 0;
            txbValue.Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmEditProduct_Load(object sender, EventArgs e)
        {
            txbDescription.Text = ProductProp.Description;
            nmcQuant.Text = ProductProp.Quant.ToString();
            txbValue.Text = ProductProp.Value.ToString();
        }
    }
}
