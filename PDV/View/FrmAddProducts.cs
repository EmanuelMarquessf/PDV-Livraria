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
    public partial class FrmAddBooks : Form
    {
        private Book _selectedBook = null;
        public FrmAddBooks()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }
        public Book SelectedBook
        {
            get
            {
                return _selectedBook;
            }
        }
        private void UpdateListView()
        {
            ltvShowBook.Items.Clear();
            BookDAO bookDao = new BookDAO();

            List<Book> books = bookDao.ListAllBooksStock();
            if (books.Count > 0)
            {
                foreach (var boo in books)
                {
                    ListViewItem lv = new ListViewItem(boo.Id.ToString());
                    lv.SubItems.Add(boo.Title);
                    lv.SubItems.Add(boo.Cover);
                    lv.SubItems.Add(boo.Quant.ToString());
                    lv.SubItems.Add(boo.Value.ToString("F2"));

                    ltvShowBook.Items.Add(lv);
                }
            }
        }
        private void FrmAddBook_Load(object sender, EventArgs e)
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

        private void ltvShowBook_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[0].Text);
            string title = ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[1].Text;
            int quant = int.Parse(ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[3].Text);
            float value = float.Parse(ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[4].Text);

            Book selectedBook = new Book(id, title, quant, value);
            int index = ltvShowBook.FocusedItem.Index;
            _selectedBook = selectedBook;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Book selectedBook = new Book(0, "\0", 1, 1f);
            _selectedBook = selectedBook;
            this.Close();
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbSearch.Text.Length > 2) 
            {
                ltvShowBook.Items.Clear();
                BookDAO bookDao = new BookDAO();

                List<Book> books = bookDao.ListSearchBooksClient(txbSearch.Text);
                if (books.Count > 0)
                {
                    foreach (var pro in books)
                    {
                        ListViewItem lv = new ListViewItem(pro.Id.ToString());
                        lv.SubItems.Add(pro.Title);
                        lv.SubItems.Add(pro.Cover);
                        lv.SubItems.Add(pro.Quant.ToString());
                        lv.SubItems.Add(pro.Value.ToString("F2"));
                        ltvShowBook.Items.Add(lv);
                    }
                }

            }
            else
            {
                UpdateListView();
            }
        }

        private void ltvShowBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltvShowBook_DoubleClick(sender, e);
            }
            if (e.KeyCode == Keys.V)
            {
                int id = int.Parse(ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[0].Text);

                Book selectedBook = new Book(id);
                FrmViewBook viewBook = new FrmViewBook(selectedBook);
                viewBook.ShowDialog();
            }
        }
        private void FrmAddBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateListView();
            txbSearch.Clear();
            txbSearch.Select();
        }
    }
}
