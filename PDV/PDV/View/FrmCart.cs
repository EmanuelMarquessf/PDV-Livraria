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
    public partial class FrmCart : Form
    {
        public Client ClientProp { get; set; }

        public Product ProductProp { get; set; }

        public float amount = 0;


        public FrmCart(Client client)
        {
            ClientProp = client;
            InitializeComponent();
            llbAddClient.Text = "Cliente: " + ClientProp.Name;
            lblIdClient.Text = ClientProp.Id.ToString();
        }


        private void UpdateListView()
        {
            ltvShowCart.Items.Clear();
             
            List<Product> products = new List<Product>();
            if (products.Count > 0)
            {
                foreach (var pro in products)
                {
                    ListViewItem lv = new ListViewItem(pro.Id.ToString());
                    lv.SubItems.Add(pro.Id.ToString());
                    lv.SubItems.Add(pro.Description);
                    lv.SubItems.Add(pro.Quant.ToString());
                    lv.SubItems.Add(pro.Value.ToString());
                    ltvShowCart.Items.Add(lv);
                }
            }
        }
        private void FrmCart_Load(object sender, EventArgs e)
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

        private void lblClient_Click(object sender, EventArgs e)
        {
           
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbAddClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddClient addClient = new FrmAddClient();
            addClient.ShowDialog();
            int idClient = addClient.SelectedClient.Id;
            string nameClient = addClient.SelectedClient.Name;
            if (nameClient != null)
            {
                lblIdClient.Text = idClient.ToString();
                llbAddClient.Text = "Cliente: " + nameClient;
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            FrmAddProducts addProduct = new FrmAddProducts();
            
            addProduct.ShowDialog();

            int idProduct = addProduct.SelectedProduct.Id;
            string nameProduct = addProduct.SelectedProduct.Description;
            float priceProduct = addProduct.SelectedProduct.Value;


            if (nameProduct != null)
            {
                txbIdProduct.Text = idProduct.ToString();
                txbPrice.Text = priceProduct.ToString("F2");
                txbAddProduct.Text = nameProduct;
                lblIdClient.Text = ClientProp.Id.ToString();
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txbAddProduct.Text.Equals(String.Empty))
            {
                MessageBox.Show("Nenhum produto selecionado!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(nmcQuant.Value == 0)
            {
                MessageBox.Show("Quantidade deve ser maior do que zero!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbPrice.Text.Equals(String.Empty))
            {
                MessageBox.Show("Preco não pode ser vazio!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem lv = new ListViewItem(txbIdProduct.Text);
            lv.SubItems.Add(txbAddProduct.Text);
            lv.SubItems.Add(nmcQuant.Value.ToString());
            lv.SubItems.Add(float.Parse(txbPrice.Text).ToString("F2"));

            float total = float.Parse(txbPrice.Text) * Decimal.ToInt32(nmcQuant.Value);
            lv.SubItems.Add(total.ToString("F2"));
            ltvShowCart.Items.Add(lv);

            //test2.Text = productsQuant;

            txbAddProduct.Clear();
            txbIdProduct.Clear();
            nmcQuant.Value = 1;
            txbPrice.Clear();
            btnAddCart.Focus();

            amount = amount + total;


            lblAmount.Text = "Valor: R$ ";
            lblAmount2.Text = amount.ToString("F2");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string payForm = cbbPagament.Text;
            int idClient = int.Parse(lblIdClient.Text);
            DateTime date = DateTime.Now;
            float amount = float.Parse(lblAmount2.Text);

            try
            {
                OrderDAO orderDAO = new OrderDAO();
                Order order = new Order(payForm, idClient, date, amount);
                orderDAO.Insert(order);
                for (int i = 0; i < ltvShowCart.Items.Count; i++)
                {
                    int idProduct = int.Parse(ltvShowCart.Items[i].SubItems[0].Text);
                    int quant = int.Parse(ltvShowCart.Items[i].SubItems[2].Text);

                    ItemOrderDAO itemOrderDAO = new ItemOrderDAO();
                    ItemOrder itemOrder = new ItemOrder(idProduct, quant);
                    itemOrderDAO.Insert(itemOrder);
                    lblIdClient.Text = 0.ToString();
                    btnClear_Click(null, null);
                }    
            }

            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (err.Message.ToUpper().Contains("Quantidade"))
                    nmcQuant.Focus();
                if (err.Message.ToUpper().Contains("Valor"))
                    txbPrice.Focus();
                if (err.Message.ToUpper().Contains("Forma de Pagamento"))
                    cbbPagament.Focus();
                return;
            }
            MessageBox.Show("Pedido realizado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbIdProduct.Clear();
            cbbPagament.SelectedIndex = -1;
            txbAddProduct.Clear();
            nmcQuant.Value = 1;
            txbPrice.Clear();
            ltvShowCart.Items.Clear();
            amount = 0;
            lblAmount.Text = "Valor: R$ ";
            lblAmount2.Text = "00,00";
            lblIdClient.Text = 0.ToString();
            llbAddClient.Text = "Cliente: ";
            btnAddCart.Focus();
        }

        private void cbbPagament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPagament.SelectedIndex == 0)
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
        }
        private void FrmCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
