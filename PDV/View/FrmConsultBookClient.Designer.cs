
namespace PDV.View
{
    partial class FrmConsultBookClient
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ltvShowBook = new System.Windows.Forms.ListView();
            this.clhId_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDescription_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAuthor_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGender_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhReleaseDate_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCapa_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhValue_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbSearch.Location = new System.Drawing.Point(12, 67);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(1190, 38);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearch.Location = new System.Drawing.Point(1208, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Limpar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ltvShowBook
            // 
            this.ltvShowBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvShowBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltvShowBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Book,
            this.clhDescription_Product,
            this.clhAuthor_Book,
            this.clhGender_Book,
            this.clhReleaseDate_Book,
            this.clhCapa_Book,
            this.clhValue_Product});
            this.ltvShowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvShowBook.FullRowSelect = true;
            this.ltvShowBook.HideSelection = false;
            this.ltvShowBook.Location = new System.Drawing.Point(12, 129);
            this.ltvShowBook.Name = "ltvShowBook";
            this.ltvShowBook.Size = new System.Drawing.Size(1319, 666);
            this.ltvShowBook.TabIndex = 3;
            this.ltvShowBook.UseCompatibleStateImageBehavior = false;
            this.ltvShowBook.View = System.Windows.Forms.View.Details;
            this.ltvShowBook.DoubleClick += new System.EventHandler(this.ltvShowBook_DoubleClick);
            this.ltvShowBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvShowBook_KeyDown);
            // 
            // clhId_Book
            // 
            this.clhId_Book.Text = "ID";
            this.clhId_Book.Width = 0;
            // 
            // clhDescription_Product
            // 
            this.clhDescription_Product.Text = "Titulo";
            this.clhDescription_Product.Width = 450;
            // 
            // clhAuthor_Book
            // 
            this.clhAuthor_Book.Text = "Autor";
            this.clhAuthor_Book.Width = 220;
            // 
            // clhGender_Book
            // 
            this.clhGender_Book.Text = "Gênero";
            this.clhGender_Book.Width = 170;
            // 
            // clhReleaseDate_Book
            // 
            this.clhReleaseDate_Book.Text = "Ano";
            this.clhReleaseDate_Book.Width = 100;
            // 
            // clhCapa_Book
            // 
            this.clhCapa_Book.Text = "Capa";
            this.clhCapa_Book.Width = 200;
            // 
            // clhValue_Product
            // 
            this.clhValue_Product.Text = "Valor(R$)";
            this.clhValue_Product.Width = 175;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(-5, -3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1350, 52);
            this.pnlTop.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(557, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "Livros disponiveis";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 50);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(567, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livros Disponíveis";
            // 
            // FrmConsultBookClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 807);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ltvShowBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmConsultBookClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultBookClient";
            this.Load += new System.EventHandler(this.FrmConsultBookClient_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultBookClient_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView ltvShowBook;
        private System.Windows.Forms.ColumnHeader clhDescription_Product;
        private System.Windows.Forms.ColumnHeader clhAuthor_Book;
        private System.Windows.Forms.ColumnHeader clhGender_Book;
        private System.Windows.Forms.ColumnHeader clhReleaseDate_Book;
        private System.Windows.Forms.ColumnHeader clhValue_Product;
        private System.Windows.Forms.ColumnHeader clhId_Book;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader clhCapa_Book;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}