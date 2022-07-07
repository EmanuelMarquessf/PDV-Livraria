
namespace PDV.View
{
    partial class FrmCart
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.ltvShowCart = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQuant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.llbAddClient = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.txbAddProduct = new System.Windows.Forms.TextBox();
            this.nmcQuant = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.cbbPagament = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.txbIdProduct = new System.Windows.Forms.TextBox();
            this.lblIdClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(236, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(420, 333);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(95, 33);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finalizar Pedido";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblAmount.Location = new System.Drawing.Point(8, 271);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(195, 37);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Valor: R$ 00,00";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ltvShowCart
            // 
            this.ltvShowCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhDescription,
            this.clhQuant,
            this.clhPrice,
            this.clhAmount});
            this.ltvShowCart.FullRowSelect = true;
            this.ltvShowCart.HideSelection = false;
            this.ltvShowCart.Location = new System.Drawing.Point(10, 73);
            this.ltvShowCart.Name = "ltvShowCart";
            this.ltvShowCart.Size = new System.Drawing.Size(505, 188);
            this.ltvShowCart.TabIndex = 26;
            this.ltvShowCart.UseCompatibleStateImageBehavior = false;
            this.ltvShowCart.View = System.Windows.Forms.View.Details;
            // 
            // clhId
            // 
            this.clhId.Text = "ID";
            this.clhId.Width = 50;
            // 
            // clhDescription
            // 
            this.clhDescription.Text = "Descricao";
            this.clhDescription.Width = 150;
            // 
            // clhQuant
            // 
            this.clhQuant.Text = "Quantidade";
            this.clhQuant.Width = 80;
            // 
            // clhPrice
            // 
            this.clhPrice.Text = "Valor Unitário(R$)";
            this.clhPrice.Width = 120;
            // 
            // clhAmount
            // 
            this.clhAmount.Text = "Valor Total (R$)";
            this.clhAmount.Width = 100;
            // 
            // llbAddClient
            // 
            this.llbAddClient.AutoSize = true;
            this.llbAddClient.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.llbAddClient.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbAddClient.LinkColor = System.Drawing.Color.Black;
            this.llbAddClient.Location = new System.Drawing.Point(10, 369);
            this.llbAddClient.Name = "llbAddClient";
            this.llbAddClient.Size = new System.Drawing.Size(81, 28);
            this.llbAddClient.TabIndex = 27;
            this.llbAddClient.TabStop = true;
            this.llbAddClient.Text = "Cliente: ";
            this.llbAddClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAddClient_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Selecionar Protuto: ";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnAddCart.Location = new System.Drawing.Point(261, 26);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(39, 35);
            this.btnAddCart.TabIndex = 1;
            this.btnAddCart.Text = "...";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // txbAddProduct
            // 
            this.txbAddProduct.Enabled = false;
            this.txbAddProduct.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txbAddProduct.Location = new System.Drawing.Point(49, 26);
            this.txbAddProduct.Name = "txbAddProduct";
            this.txbAddProduct.Size = new System.Drawing.Size(208, 34);
            this.txbAddProduct.TabIndex = 30;
            // 
            // nmcQuant
            // 
            this.nmcQuant.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.nmcQuant.Location = new System.Drawing.Point(305, 27);
            this.nmcQuant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcQuant.Name = "nmcQuant";
            this.nmcQuant.Size = new System.Drawing.Size(52, 34);
            this.nmcQuant.TabIndex = 2;
            this.nmcQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnAdd.Location = new System.Drawing.Point(454, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txbPrice.Location = new System.Drawing.Point(363, 25);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(85, 34);
            this.txbPrice.TabIndex = 3;
            // 
            // cbbPagament
            // 
            this.cbbPagament.FormattingEnabled = true;
            this.cbbPagament.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartao de Credito",
            "Cartao de Debito"});
            this.cbbPagament.Location = new System.Drawing.Point(398, 286);
            this.cbbPagament.Name = "cbbPagament";
            this.cbbPagament.Size = new System.Drawing.Size(117, 21);
            this.cbbPagament.TabIndex = 31;
            this.cbbPagament.SelectedIndexChanged += new System.EventHandler(this.cbbPagament_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // lblAmount2
            // 
            this.lblAmount2.AutoSize = true;
            this.lblAmount2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblAmount2.Location = new System.Drawing.Point(120, 271);
            this.lblAmount2.Name = "lblAmount2";
            this.lblAmount2.Size = new System.Drawing.Size(83, 37);
            this.lblAmount2.TabIndex = 35;
            this.lblAmount2.Text = "00,00";
            // 
            // txbIdProduct
            // 
            this.txbIdProduct.Enabled = false;
            this.txbIdProduct.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txbIdProduct.Location = new System.Drawing.Point(11, 27);
            this.txbIdProduct.Name = "txbIdProduct";
            this.txbIdProduct.Size = new System.Drawing.Size(33, 34);
            this.txbIdProduct.TabIndex = 37;
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Enabled = false;
            this.lblIdClient.Location = new System.Drawing.Point(162, 381);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(0, 13);
            this.lblIdClient.TabIndex = 34;
            this.lblIdClient.Visible = false;
            // 
            // FrmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 400);
            this.Controls.Add(this.txbIdProduct);
            this.Controls.Add(this.lblAmount2);
            this.Controls.Add(this.lblIdClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbPagament);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nmcQuant);
            this.Controls.Add(this.txbAddProduct);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbAddClient);
            this.Controls.Add(this.ltvShowCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnClear);
            this.MinimumSize = new System.Drawing.Size(506, 439);
            this.Name = "FrmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCart_FormClosed);
            this.Load += new System.EventHandler(this.FrmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView ltvShowCart;
        private System.Windows.Forms.ColumnHeader clhDescription;
        private System.Windows.Forms.ColumnHeader clhQuant;
        private System.Windows.Forms.ColumnHeader clhPrice;
        private System.Windows.Forms.LinkLabel llbAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.TextBox txbAddProduct;
        private System.Windows.Forms.NumericUpDown nmcQuant;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.ColumnHeader clhAmount;
        private System.Windows.Forms.ComboBox cbbPagament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.Label lblAmount2;
        private System.Windows.Forms.TextBox txbIdProduct;
        private System.Windows.Forms.Label lblIdClient;
    }
}