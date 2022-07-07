
namespace PDV.View
{
    partial class FrmConsultProduct
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.ltvShowProduct = new System.Windows.Forms.ListView();
            this.clhId_Product = new System.Windows.Forms.ColumnHeader();
            this.clhDescription_Product = new System.Windows.Forms.ColumnHeader();
            this.clhQuant_Product = new System.Windows.Forms.ColumnHeader();
            this.clhValue_Product = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(317, 369);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 53);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Novo Produto";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ltvShowProduct
            // 
            this.ltvShowProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Product,
            this.clhDescription_Product,
            this.clhQuant_Product,
            this.clhValue_Product});
            this.ltvShowProduct.FullRowSelect = true;
            this.ltvShowProduct.HideSelection = false;
            this.ltvShowProduct.Location = new System.Drawing.Point(12, 19);
            this.ltvShowProduct.Name = "ltvShowProduct";
            this.ltvShowProduct.Size = new System.Drawing.Size(439, 320);
            this.ltvShowProduct.TabIndex = 16;
            this.ltvShowProduct.UseCompatibleStateImageBehavior = false;
            this.ltvShowProduct.View = System.Windows.Forms.View.Details;
            this.ltvShowProduct.DoubleClick += new System.EventHandler(this.ltvShowProduct_DoubleClick);
            // 
            // clhId_Product
            // 
            this.clhId_Product.Text = "ID";
            this.clhId_Product.Width = 35;
            // 
            // clhDescription_Product
            // 
            this.clhDescription_Product.Text = "Descricao";
            this.clhDescription_Product.Width = 200;
            // 
            // clhQuant_Product
            // 
            this.clhQuant_Product.Text = "Quantidade";
            this.clhQuant_Product.Width = 80;
            // 
            // clhValue_Product
            // 
            this.clhValue_Product.Text = "Valor(R$)";
            this.clhValue_Product.Width = 120;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 53);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmConsultProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 441);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ltvShowProduct);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmConsultProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultProduct";
            this.Load += new System.EventHandler(this.FrmConsultProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListView ltvShowProduct;
        private System.Windows.Forms.ColumnHeader clhId_Product;
        private System.Windows.Forms.ColumnHeader clhDescription_Product;
        private System.Windows.Forms.ColumnHeader clhQuant_Product;
        private System.Windows.Forms.ColumnHeader clhValue_Product;
        private System.Windows.Forms.Button btnCancel;
    }
}