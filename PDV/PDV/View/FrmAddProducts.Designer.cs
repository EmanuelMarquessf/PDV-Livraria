
namespace PDV.View
{
    partial class FrmAddProducts
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
            this.ltvShowProduct = new System.Windows.Forms.ListView();
            this.clhId_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDescription_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQuant_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhValue_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ltvShowProduct
            // 
            this.ltvShowProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Product,
            this.clhDescription_Product,
            this.clhQuant_Product,
            this.clhValue_Product});
            this.ltvShowProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvShowProduct.FullRowSelect = true;
            this.ltvShowProduct.HideSelection = false;
            this.ltvShowProduct.Location = new System.Drawing.Point(0, 0);
            this.ltvShowProduct.Name = "ltvShowProduct";
            this.ltvShowProduct.Size = new System.Drawing.Size(419, 292);
            this.ltvShowProduct.TabIndex = 17;
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
            this.clhValue_Product.Width = 100;
            // 
            // FrmAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 292);
            this.Controls.Add(this.ltvShowProduct);
            this.MinimumSize = new System.Drawing.Size(408, 331);
            this.Name = "FrmAddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProducts";
            this.Load += new System.EventHandler(this.FrmAddProducts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvShowProduct;
        private System.Windows.Forms.ColumnHeader clhId_Product;
        private System.Windows.Forms.ColumnHeader clhDescription_Product;
        private System.Windows.Forms.ColumnHeader clhQuant_Product;
        private System.Windows.Forms.ColumnHeader clhValue_Product;
    }
}