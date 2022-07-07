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
    public partial class FrmEditBook : Form
    {
        public Book BookProp { get; set; }
        public FrmEditBook()
        {
            InitializeComponent();
        }

        public FrmEditBook(Book book)
        {
            BookProp = book;
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string title = txbTitle.Text;
            string author = txbAuthor.Text;
            string company = txbCompany.Text;
            string edition = txbEdition.Text;
            string releaseDate = txbYear.Text;
            int volume = int.Parse(nmcVolume.Text);
            string gender = txbGender.Text;
            string language = txbLanguage.Text;
            int pages = int.Parse(nmcPages.Text);
            string cover = cbbCover.Text;
            string isbn = txbIsbn.Text;
            int quant = int.Parse(nmcQuant.Text);
            float value = float.Parse(txbValue.Text);
            string status = cbbStatus.Text;
            bool statusAux;

            if (status == "Ativo")
                statusAux = true;
            else
                statusAux = false;
            try
            {
                BookDAO bookDAO = new BookDAO();
                Book book = new Book(BookProp.Id, title, quant, value, author, company, pages, gender, volume, edition, isbn, language, cover, releaseDate, statusAux);
                bookDAO.Update(book);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTitle.Focus();
                if (err.Message.ToUpper().Contains("Descricao"))
                    txbTitle.Focus();
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
            BookDAO bookDao = new BookDAO();

            try
            {
                bookDao.Delete(BookProp.Id);
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

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmEditBook_Load(object sender, EventArgs e)
        {

            BookDAO bookDAO = new BookDAO();
            Book selectedBook = new Book(BookProp.Id);
            selectedBook = bookDAO.AddBook(BookProp.Id);

            txbTitle.Text = selectedBook.Title;
            txbAuthor.Text = selectedBook.Author;
            txbCompany.Text = selectedBook.Company;
            txbEdition.Text = selectedBook.Edition;
            txbYear.Text = selectedBook.ReleaseDate.ToString();
            nmcVolume.Text = selectedBook.Volume.ToString();
            txbGender.Text = selectedBook.Gender;
            txbLanguage.Text = selectedBook.Language;
            nmcPages.Text = selectedBook.Pages.ToString();
            cbbCover.Text = selectedBook.Cover;
            txbIsbn.Text = selectedBook.Isbn;
            nmcQuant.Text = selectedBook.Quant.ToString();
            txbValue.Text = selectedBook.Value.ToString();
            if(selectedBook.Status == true)
                cbbStatus.SelectedIndex = 0;
            else if(selectedBook.Status == false)
                cbbStatus.SelectedIndex = 1;
        }

        private void FrmEditBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnSave_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
