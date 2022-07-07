
namespace PDV.View
{
    partial class FrmConsultBook
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
            this.clhDescription_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQtd_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhValue_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvShowBook
            // 
            this.ltvShowBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Book,
            this.clhDescription_Product,
            this.clhQtd_Book,
            this.clhValue_Product});
            this.ltvShowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ltvShowBook.FullRowSelect = true;
            this.ltvShowBook.HideSelection = false;
            this.ltvShowBook.Location = new System.Drawing.Point(10, 105);
            this.ltvShowBook.Name = "ltvShowBook";
            this.ltvShowBook.Size = new System.Drawing.Size(699, 389);
            this.ltvShowBook.TabIndex = 16;
            this.ltvShowBook.UseCompatibleStateImageBehavior = false;
            this.ltvShowBook.View = System.Windows.Forms.View.Details;
            this.ltvShowBook.DoubleClick += new System.EventHandler(this.ltvShowBook_DoubleClick);
            this.ltvShowBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvShowBook_KeyDown);
            // 
            // clhId_Book
            // 
            this.clhId_Book.Text = "ID";
            this.clhId_Book.Width = 50;
            // 
            // clhDescription_Product
            // 
            this.clhDescription_Product.Text = "Titulo";
            this.clhDescription_Product.Width = 385;
            // 
            // clhQtd_Book
            // 
            this.clhQtd_Book.Text = "Qtd";
            this.clhQtd_Book.Width = 140;
            // 
            // clhValue_Product
            // 
            this.clhValue_Product.Text = "Valor(R$)";
            this.clhValue_Product.Width = 120;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancel.Location = new System.Drawing.Point(12, 538);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbSearch.Location = new System.Drawing.Point(10, 55);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(600, 38);
            this.txbSearch.TabIndex = 21;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearch.Location = new System.Drawing.Point(616, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Limpar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRegister.Location = new System.Drawing.Point(531, 537);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(179, 40);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "F2 - Novo";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGetReport.Location = new System.Drawing.Point(273, 538);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(185, 40);
            this.btnGetReport.TabIndex = 18;
            this.btnGetReport.Text = "F1 - Gerar Relatório";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Visible = false;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(737, 49);
            this.pnlTop.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(233, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Livros cadastrados";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatus.Location = new System.Drawing.Point(12, 500);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(125, 24);
            this.ckbStatus.TabIndex = 49;
            this.ckbStatus.Text = "Exibir Inativos";
            this.ckbStatus.UseVisualStyleBackColor = true;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            // 
            // FrmConsultBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 586);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ltvShowBook);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(468, 419);
            this.Name = "FrmConsultBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Produtos";
            this.Load += new System.EventHandler(this.FrmConsultBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultBook_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ltvShowBook;
        private System.Windows.Forms.ColumnHeader clhDescription_Product;
        private System.Windows.Forms.ColumnHeader clhValue_Product;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader clhQtd_Book;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.ColumnHeader clhId_Book;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbStatus;
    }
}