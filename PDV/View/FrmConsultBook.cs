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
    public partial class FrmConsultBook : Form
    {
        public FrmConsultBook(string office)
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
            ckbStatus.Checked = false;
            if(office == "Estoquista")
            {
                btnCancel.Text = "ESC - Logout";
            }
        }

        private void UpdateListView()
        {
            ltvShowBook.Items.Clear();
            BookDAO bookDao = new BookDAO();

            List<Book> books = bookDao.ListAllBooksStatus();
            if (books.Count > 0)
            {
                foreach (var pro in books)
                {
                    ListViewItem lv = new ListViewItem(pro.Id.ToString());
                    if (pro.Status == false)
                        lv.BackColor = Color.FromArgb(255, 150, 143);
                    else
                        lv.BackColor = Color.FromArgb(148, 255, 176);
                    lv.SubItems.Add(pro.Title);
                    lv.SubItems.Add(pro.Quant.ToString());
                    lv.SubItems.Add(pro.Value.ToString("F2"));
                    ltvShowBook.Items.Add(lv);
                }
            }
        }
        private void FrmConsultBook_Load(object sender, EventArgs e)
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
            int quant = int.Parse(ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[2].Text);
            float value = float.Parse(ltvShowBook.Items[ltvShowBook.FocusedItem.Index].SubItems[3].Text);
            
            Book book = new Book(id, title, quant, value);
            FrmEditBook frmEditBook = new FrmEditBook(book);
            frmEditBook.ShowDialog();
            if (book.Status)
                UpdateListView();
            else
                ckbStatus_CheckedChanged(sender, e);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmBook book = new FrmBook();
            book.ShowDialog();
            UpdateListView();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbSearch.Text.Length > 2)
            {
                ltvShowBook.Items.Clear();
                BookDAO bookDao = new BookDAO();

                List<Book> books = bookDao.ListSearchBooks(txbSearch.Text);
                if (books.Count > 0)
                {
                    foreach (var pro in books)
                    {
                        ListViewItem lv = new ListViewItem(pro.Id.ToString());
                        if (pro.Status == false)
                            lv.BackColor = Color.FromArgb(255, 150, 143);
                        else
                            lv.BackColor = Color.FromArgb(148, 255, 176);
                        lv.SubItems.Add(pro.Title);
                        lv.SubItems.Add(pro.Quant.ToString());
                        lv.SubItems.Add(pro.Value.ToString("F2"));
                        ltvShowBook.Items.Add(lv);
                    }
                }
                else
                {
                    UpdateListView();
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            //frmRelatorioBook book = new frmRelatorioBook();
            //book.ShowDialog();
        }

        private void ltvShowBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltvShowBook_DoubleClick(sender, e);
            }
        }

        private void FrmConsultBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnGetReport_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnRegister_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbStatus.Checked == true)
            {
                ltvShowBook.Items.Clear();
                BookDAO bookDao = new BookDAO();

                List<Book> books = bookDao.ListAllBooks();
                if (books.Count > 0)
                {
                    foreach (var pro in books)
                    {
                        ListViewItem lv = new ListViewItem(pro.Id.ToString());
                        if (pro.Status == false)
                            lv.BackColor = Color.FromArgb(255, 150, 143);
                        else
                            lv.BackColor = Color.FromArgb(148, 255, 176);
                        lv.SubItems.Add(pro.Title);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateListView();
            txbSearch.Clear();
            txbSearch.Select();
        }
    }
}
