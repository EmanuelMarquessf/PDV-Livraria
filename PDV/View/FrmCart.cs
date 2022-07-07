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
using System.Text.RegularExpressions;

namespace PDV.View
{
    public partial class FrmCart : Form
    {
        public Adm AdmProp { get; set; }
        public Client ClientProp { get; set; }

        public Book BookProp { get; set; }

        public float amount = 0;
        public int quant = 0;

        public FrmCart(Client client, Adm adm)
        {
            AdmProp = adm;
            ClientProp = client;
            InitializeComponent();
            if (adm.Office == "Atendente")
            {
                btnMenu.Text = "F7 - Clientes";
            }
            pnlBottom.BackColor = Color.FromArgb(19, 34, 56);          
            pnlBack.BackColor = Color.FromArgb(54, 78, 104);
            pnlTop.BackColor = Color.FromArgb(19, 34, 56);
            pnlAdd.BackColor = Color.FromArgb(19, 34, 56);
            btnClear.BackColor = Color.FromArgb(152, 204, 211);
            btnLogoutPDV.BackColor = Color.FromArgb(152, 204, 211);
            btnBookClient.BackColor = Color.FromArgb(152, 204, 211);
            btnMenu.BackColor = Color.FromArgb(152, 204, 211);
            btnFinish.BackColor = Color.FromArgb(152, 204, 211);
            btnClient.BackColor = Color.FromArgb(152, 204, 211);
            lblTime.Text = DateTime.Now.Date.ToString("d");
            
            txbIdBook.Select();
            lblIdClient.Text = (client.Id).ToString();
            llbAddClient.Text = "Cliente: " + ClientProp.Name;
            lblAdm.Text = "Olá " + AdmProp.Office + " " +  AdmProp.Name + " | Seja Bem-Vindo!!";
        }
        public void UpdateListView()
        {
            ltvShowCart.Items.Clear();

            List<Book> books = new List<Book>();
            if (books.Count > 0)
            {
                foreach (var pro in books)
                {
                    ListViewItem lv = new ListViewItem(pro.Id.ToString());
                    lv.SubItems.Add(pro.Id.ToString());
                    lv.SubItems.Add(pro.Title);
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
            txbIdBook.Select();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            FrmAddBooks addBook = new FrmAddBooks();
            addBook.ShowDialog();

            txbIdBook.Select();

            int idBook = addBook.SelectedBook.Id;
            string nameBook = addBook.SelectedBook.Title;
            float priceBook = addBook.SelectedBook.Value;
            quant = addBook.SelectedBook.Quant;


            if (nameBook != null)
            {
                txbIdBook.Text = idBook.ToString();
                txbPrice.Text = priceBook.ToString("F2");
                txbAddBook.Text = nameBook;
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txbAddBook.Text.Equals(String.Empty))
            {
                MessageBox.Show("Nenhum produto selecionado!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nmcQuant.Value == 0)
            {
                MessageBox.Show("Quantidade deve ser maior do que zero!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbPrice.Text.Equals(String.Empty))
            {
                MessageBox.Show("Preco não pode ser vazio!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nmcQuant.Value > quant)
            {
                MessageBox.Show("Quantidade não disponivel!!", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmcQuant.Value = 1;
                txbIdBook.Select();
                return;
            }

            ListViewItem lv = new ListViewItem(txbIdBook.Text);
            lv.SubItems.Add(txbAddBook.Text);
            lv.SubItems.Add(nmcQuant.Value.ToString());
            lv.SubItems.Add(float.Parse(txbPrice.Text).ToString("F2"));

            float total = float.Parse(txbPrice.Text) * Decimal.ToInt32(nmcQuant.Value);
            lv.SubItems.Add(total.ToString("F2"));
            ltvShowCart.Items.Add(lv);

            //test2.Text = booksQuant;

            txbAddBook.Clear();
            txbIdBook.Clear();
            nmcQuant.Value = 1;
            txbPrice.Clear();
            txbIdBook.Select();

            amount = amount + total;

            lblAmount.Text = "Valor: R$ ";
            lblAmount2.Text = amount.ToString("F2");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            FrmSelectPayForm addPayForm = new FrmSelectPayForm(float.Parse(lblAmount2.Text));
            addPayForm.ShowDialog();
            string payForm = addPayForm.SelectPayForm;
            int idClient = int.Parse(lblIdClient.Text);
            DateTime date = DateTime.Now;
            float amount = float.Parse(lblAmount2.Text);
            int idAdm = AdmProp.Id;

            try
            {
                if (payForm != null)
                {
                    OrderDAO orderDAO = new OrderDAO();
                    Order order = new Order(payForm, idClient, date, amount, idAdm);
                    orderDAO.Insert(order);
                    for (int i = 0; i < ltvShowCart.Items.Count; i++)
                    {
                        int idBook = int.Parse(ltvShowCart.Items[i].SubItems[0].Text);
                        int quant = int.Parse(ltvShowCart.Items[i].SubItems[2].Text);

                        ItemOrderDAO itemOrderDAO = new ItemOrderDAO();
                        ItemOrder itemOrder = new ItemOrder(idBook, quant);
                        itemOrderDAO.Insert(itemOrder);
                        itemOrderDAO.UpdateStock(itemOrder);
                    }
                    MessageBox.Show("Pedido realizado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(null, null);
                    lblIdClient.Text = "1";
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
                    btnFinish.Select();
                return;
            }
            txbIdBook.Select();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbIdBook.Clear();
            txbAddBook.Clear();
            nmcQuant.Value = 1;
            txbPrice.Clear();
            ltvShowCart.Items.Clear();
            amount = 0;
            lblAmount.Text = "Valor: R$ ";
            lblAmount2.Text = "00,00";
            lblIdClient.Text = "1";
            llbAddClient.Text = "Cliente: ";
            txbIdBook.Select();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(AdmProp.Office == "Atendente")
            {
                FrmConsultClient consultClient = new FrmConsultClient();
                consultClient.ShowDialog();
            }
            else
            {
                FrmMain main = new FrmMain();
                main.ShowDialog();
            }
            txbIdBook.Select();
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            llbAddClient_LinkClicked(sender, null);
        }
        private void btnLogoutPDV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fazer o logout??", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void FrmCart_KeyDown(object sender, KeyEventArgs e)
        {
            
 
            if (e.KeyCode == Keys.F4)
            {
                btnClear_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnClient_Click(sender, e);
            }
            if (e.KeyCode == Keys.F6)
            {
                btnBookClient_Click(sender, e);
            }
            if (e.KeyCode == Keys.F7)
            {
                btnMenu_Click(sender, e);
            }

            if (e.KeyCode == Keys.F11 && btnFinish.Enabled == true)
            {
                btnFinish_Click(sender, e);
            }
            if (e.KeyCode == Keys.Space)
            {
                btnAddCart_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnLogoutPDV_Click(sender, e);
            }

        }

        private void txbIdBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Regex.IsMatch(txbIdBook.Text, @"^[0-9]+$"))
            {
                BookDAO bookDAO = new BookDAO();
                Book selectedBook = new Book(int.Parse(txbIdBook.Text));
                selectedBook = bookDAO.AddBook(int.Parse(txbIdBook.Text));
                quant = selectedBook.Quant;
                if(selectedBook.Title != null) { 
                    txbIdBook.Text = (selectedBook.Id).ToString();
                    txbPrice.Text = (selectedBook.Value).ToString("F2");
                    txbAddBook.Text = selectedBook.Title;
                    nmcQuant.Select();
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbIdBook.Clear();
                }
            }


        }

        private void nmcQuant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                txbIdBook.Select();
            }
        }
        private void ltvShowCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                float amount2 = float.Parse(lblAmount2.Text);
                amount = amount2 - float.Parse(ltvShowCart.Items[ltvShowCart.FocusedItem.Index].SubItems[4].Text);
                ltvShowCart.FocusedItem.Remove();
                lblAmount2.Text = amount.ToString("F2");
            }
        }

        private void lblAmount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblAmount2_TextChanged(object sender, EventArgs e)
        {
            if (amount > 0 && lblAmount2.Text != "00,00")
                btnFinish.Enabled = true;
            else
                btnFinish.Enabled = false;
        }

        private void btnBookClient_Click(object sender, EventArgs e)
        {
            FrmConsultBookClient consultBookClient = new FrmConsultBookClient();
            consultBookClient.ShowDialog();
            txbIdBook.Select();
        }
    }
}