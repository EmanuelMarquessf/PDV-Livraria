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
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
            pnlTop.BackColor = Color.FromArgb(54, 78, 104);
            cbbCover.SelectedIndex = 0;
            nmcVolume.Value = 1;
            txbTitle.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string description = txbTitle.Text;
            int quant = int.Parse(nmcQuant.Text);
            float value = float.Parse(txbValue.Text);
            string author = txbAuthor.Text;
            string company = txbCompany.Text;
            int pages = int.Parse(nmcPages.Text);
            string gender = txbGender.Text;
            int volume = int.Parse(nmcVolume.Text);
            string edition = txbEdition.Text;
            string isbn = txbIsbn.Text;
            string language = txbLanguage.Text;
            string cover = cbbCover.Text;
            string releaseDate = txbYear.Text;

            try
            {
                BookDAO bookDao = new BookDAO();
                Book book = new Book(description, quant, value, author, company, pages, gender, volume, edition, isbn, language, cover, releaseDate);
                bookDao.Insert(book);
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
                if (err.Message.ToUpper().Contains("Autor"))
                    txbValue.Focus();
                if (err.Message.ToUpper().Contains("Company"))
                    txbCompany.Focus();
                if (err.Message.ToUpper().Contains("Paginas"))
                    nmcPages.Focus();
                if (err.Message.ToUpper().Contains("Gênero"))
                    txbGender.Focus();
                if (err.Message.ToUpper().Contains("Volume"))
                    nmcVolume.Focus();
                if (err.Message.ToUpper().Contains("Edição"))
                    txbEdition.Focus();
                if (err.Message.ToUpper().Contains("ISBN"))
                    txbIsbn.Focus();
                if (err.Message.ToUpper().Contains("Idioma"))
                    txbLanguage.Focus();
                if (err.Message.ToUpper().Contains("Capa"))
                    cbbCover.Focus();
                return;
            }
            MessageBox.Show("Produto Cadastrado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbTitle.Clear();
            txbAuthor.Clear();
            txbCompany.Clear();
            txbEdition.Clear();
            txbYear.Clear();
            txbGender.Clear();
            txbLanguage.Clear();
            nmcVolume.Value = 1;
            cbbCover.SelectedIndex = 0;
            nmcPages.Value = 0;
            txbIsbn.Clear();
            txbValue.Clear();
            nmcQuant.Value = 0;

            txbTitle.Select();
        }
        private void FrmBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnCancel_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
