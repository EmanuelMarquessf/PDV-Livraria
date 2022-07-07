
namespace PDV.View
{
    partial class FrmAddBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltvShowBook = new System.Windows.Forms.ListView();
            this.clhId_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTitle_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQuant_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhValue_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clhCover_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlBack.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvShowBook
            // 
            this.ltvShowBook.BackColor = System.Drawing.Color.Gainsboro;
            this.ltvShowBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Book,
            this.clhTitle_Book,
            this.clhCover_Book,
            this.clhQuant_Book,
            this.clhValue_Book});
            this.ltvShowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ltvShowBook.FullRowSelect = true;
            this.ltvShowBook.HideSelection = false;
            this.ltvShowBook.Location = new System.Drawing.Point(8, 105);
            this.ltvShowBook.Name = "ltvShowBook";
            this.ltvShowBook.Size = new System.Drawing.Size(716, 352);
            this.ltvShowBook.TabIndex = 17;
            this.ltvShowBook.UseCompatibleStateImageBehavior = false;
            this.ltvShowBook.View = System.Windows.Forms.View.Details;
            this.ltvShowBook.DoubleClick += new System.EventHandler(this.ltvShowBook_DoubleClick);
            this.ltvShowBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvShowBook_KeyDown);
            // 
            // clhId_Book
            // 
            this.clhId_Book.Text = "ID";
            this.clhId_Book.Width = 70;
            // 
            // clhTitle_Book
            // 
            this.clhTitle_Book.Text = "Titulo";
            this.clhTitle_Book.Width = 300;
            // 
            // clhQuant_Book
            // 
            this.clhQuant_Book.Text = "Qtd";
            this.clhQuant_Book.Width = 80;
            // 
            // clhValue_Book
            // 
            this.clhValue_Book.Text = "Valor(R$)";
            this.clhValue_Book.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCancel.Location = new System.Drawing.Point(11, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 46);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbSearch.Location = new System.Drawing.Point(11, 54);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(578, 38);
            this.txbSearch.TabIndex = 21;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSearch.Location = new System.Drawing.Point(595, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Limpar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.pnlTop);
            this.pnlBack.Controls.Add(this.txbSearch);
            this.pnlBack.Controls.Add(this.ltvShowBook);
            this.pnlBack.Controls.Add(this.btnCancel);
            this.pnlBack.Controls.Add(this.btnSearch);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(737, 522);
            this.pnlBack.TabIndex = 23;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(-1, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(737, 49);
            this.pnlTop.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(280, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Adicionar Livro";
            // 
            // clhCover_Book
            // 
            this.clhCover_Book.Text = "Capa";
            this.clhCover_Book.Width = 110;
            // 
            // FrmAddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 522);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(419, 320);
            this.Name = "FrmAddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProducts";
            this.Load += new System.EventHandler(this.FrmAddBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddBooks_KeyDown);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvShowBook;
        private System.Windows.Forms.ColumnHeader clhId_Book;
        private System.Windows.Forms.ColumnHeader clhTitle_Book;
        private System.Windows.Forms.ColumnHeader clhQuant_Book;
        private System.Windows.Forms.ColumnHeader clhValue_Book;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader clhCover_Book;
    }
}