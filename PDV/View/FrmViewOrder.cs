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
    public partial class FrmViewOrder : Form
    {
        public Order OrderProp { get; set; }
        public FrmViewOrder(int id, string name, string cpf, string func, DateTime date, string payForm, float amount)
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
            lblId.Text = (id).ToString();
            lblFunc.Text = func;
            lblClient.Text = name;
            if (cpf != "")
                lblCPF.Text = FormatCPF(cpf);
            else
                lblCPF.Text = "";
            lblPayForm.Text = payForm;
            lblDate.Text = date.ToString("d");
            lblAmount.Text = "R$ " + amount.ToString("F2");
        }
        public static string FormatCPF(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
        }
        private void FrmViewOrder_Load(object sender, EventArgs e)
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
        private void UpdateListView()
        {
            ltvShowItemOrder.Items.Clear();
            ItemOrderDAO itemOrderDao = new ItemOrderDAO();

            List<ItemOrder> itens = itemOrderDao.ListItensOrder(int.Parse(lblId.Text));

            if (itens.Count > 0)
            {
                foreach (var ite in itens)
                {
                    BookDAO bookDAO = new BookDAO();
                    Book selectedBook = new Book(ite.IdBook);
                    selectedBook = bookDAO.AddBook(ite.IdBook);



                    ListViewItem lv = new ListViewItem(ite.IdBook.ToString());
                    lv.SubItems.Add(selectedBook.Title.ToString());
                    lv.SubItems.Add(selectedBook.Cover.ToString());
                    lv.SubItems.Add(ite.Quant.ToString());
                    lv.SubItems.Add((selectedBook.Value * ite.Quant).ToString("F2"));

                    ltvShowItemOrder.Items.Add(lv);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmViewOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
