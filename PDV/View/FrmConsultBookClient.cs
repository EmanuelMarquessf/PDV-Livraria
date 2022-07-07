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
    public partial class FrmConsultBookClient : Form
    {
        public FrmConsultBookClient()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
            txbSearch.Select();

        }
        private void UpdateListView()
        {
            ltvShowBook.Items.Clear();
            BookDAO bookDao = new BookDAO();

            List<Book> books = bookDao.ListAllBooksStock();
            if (books.Count > 0)
            {
                foreach (var pro in books)
                {
                    ListViewItem lv = new ListViewItem(pro.Id.ToString());
                    lv.SubItems.Add(pro.Title);
                    lv.SubItems.Add(pro.Author.ToString());
                    lv.SubItems.Add(pro.Gender.ToString());
                    lv.SubItems.Add(pro.ReleaseDate.ToString());
                    lv.SubItems.Add(pro.Cover.ToString());
                    lv.SubItems.Add(pro.Value.ToString("F2"));

                    ltvShowBook.Items.Add(lv);
                }
            }
        }
        private void FrmConsultBookClient_Load(object sender, EventArgs e)
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
                        lv.SubItems.Add(pro.Author.ToString());
                        lv.SubItems.Add(pro.Gender.ToString());
                        lv.SubItems.Add(pro.ReleaseDate.ToString());
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

        private void ltvShowBook_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[0].Text);

            Book selectedBook = new Book(id);
            FrmViewBook viewBook = new FrmViewBook(selectedBook);
            viewBook.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSearch_TextChanged(sender, e);
            }
        }
        private void ltvShowBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltvShowBook_DoubleClick(sender, e);
            }
        }

        private void FrmConsultBookClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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
