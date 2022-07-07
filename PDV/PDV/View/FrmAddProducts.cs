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
    public partial class FrmAddProducts : Form
    {
        private Product _selectedProduct = null;
        public FrmAddProducts()
        {
            InitializeComponent();
        }
        public Product SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
        }
        private void UpdateListView()
        {
            ltvShowProduct.Items.Clear();
            ProductDAO productDao = new ProductDAO();

            List<Product> products = productDao.ListAllProducts();
            if (products.Count > 0)
            {
                foreach (var pro in products)
                {
                    ListViewItem lv = new ListViewItem(pro.Id.ToString());
                    lv.SubItems.Add(pro.Description);
                    lv.SubItems.Add(pro.Quant.ToString());
                    lv.SubItems.Add(pro.Value.ToString("F2"));
                    ltvShowProduct.Items.Add(lv);
                }
            }
        }

        private void FrmAddProducts_Load(object sender, EventArgs e)
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

        private void ltvShowProduct_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(ltvShowProduct.Items[ltvShowProduct.FocusedItem.Index].SubItems[0].Text);
            string description = ltvShowProduct.Items[ltvShowProduct.FocusedItem.Index].SubItems[1].Text;
            int quant = int.Parse(ltvShowProduct.Items[ltvShowProduct.FocusedItem.Index].SubItems[2].Text);
            float value = float.Parse(ltvShowProduct.Items[ltvShowProduct.FocusedItem.Index].SubItems[3].Text);

            Product selectedProduct = new Product(id, description, quant, value);
            int index = ltvShowProduct.FocusedItem.Index;
            _selectedProduct = selectedProduct;
            this.Close();
        }
    }
}
