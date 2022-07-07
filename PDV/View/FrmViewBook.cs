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
    public partial class FrmViewBook : Form
    {
        public Book BookProp { get; set; }
        public FrmViewBook(Book book)
        {
            BookProp = book;
            BookDAO bookDAO = new BookDAO();
            Book selectedBook = new Book(book.Id);
            selectedBook = bookDAO.AddBook(BookProp.Id);
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);

            lblTitle.Text = selectedBook.Title;
            lblAuthor.Text = selectedBook.Author;
            lblCompany.Text = selectedBook.Company;
            lblVolume.Text = (selectedBook.Volume).ToString();
            lblEdition.Text = selectedBook.Edition;
            lblCover.Text = selectedBook.Cover;
            lblQtd.Text = (selectedBook.Pages).ToString();
            lblGender.Text = selectedBook.Gender;
            lblLanguage.Text = selectedBook.Language;
            lblReleaseDate.Text = (selectedBook.ReleaseDate).ToString();
            lblISBN13.Text = selectedBook.Isbn;
            lblPrice.Text = "R$ " + (selectedBook.Value).ToString("F2");
        }
        private void FrmViewBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
