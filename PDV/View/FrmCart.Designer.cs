
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.llbAddClient = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.txbAddBook = new System.Windows.Forms.TextBox();
            this.nmcQuant = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.txbIdBook = new System.Windows.Forms.TextBox();
            this.btnLogoutPDV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdm = new System.Windows.Forms.Label();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQuant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvShowCart = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnBookClient = new System.Windows.Forms.Button();
            this.pnlValue = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlBack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlValue.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(205, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 42);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "F4 - Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.AutoSize = true;
            this.btnFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFinish.Location = new System.Drawing.Point(1106, 9);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(163, 42);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "F11 - Finalizar Pedido";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblAmount.Location = new System.Drawing.Point(14, 20);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(265, 51);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Valor: R$ 00,00";
            this.lblAmount.TextChanged += new System.EventHandler(this.lblAmount_TextChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenu.AutoSize = true;
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMenu.Location = new System.Drawing.Point(768, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(167, 42);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "F7 - Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // llbAddClient
            // 
            this.llbAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llbAddClient.AutoEllipsis = true;
            this.llbAddClient.AutoSize = true;
            this.llbAddClient.BackColor = System.Drawing.SystemColors.ControlText;
            this.llbAddClient.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.llbAddClient.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbAddClient.LinkColor = System.Drawing.Color.White;
            this.llbAddClient.Location = new System.Drawing.Point(554, 631);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Selecione o  Produto: ";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCart.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.btnAddCart.Image = global::PDV.Properties.Resources._64673;
            this.btnAddCart.Location = new System.Drawing.Point(563, 112);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(62, 57);
            this.btnAddCart.TabIndex = 1;
            this.btnAddCart.Text = "...";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // txbAddBook
            // 
            this.txbAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAddBook.Enabled = false;
            this.txbAddBook.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.txbAddBook.Location = new System.Drawing.Point(80, 112);
            this.txbAddBook.Name = "txbAddBook";
            this.txbAddBook.Size = new System.Drawing.Size(449, 57);
            this.txbAddBook.TabIndex = 30;
            // 
            // nmcQuant
            // 
            this.nmcQuant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmcQuant.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcQuant.Location = new System.Drawing.Point(388, 218);
            this.nmcQuant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcQuant.Name = "nmcQuant";
            this.nmcQuant.Size = new System.Drawing.Size(90, 57);
            this.nmcQuant.TabIndex = 2;
            this.nmcQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcQuant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmcQuant_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(526, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 54);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbPrice.Enabled = false;
            this.txbPrice.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(10, 218);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(354, 57);
            this.txbPrice.TabIndex = 3;
            // 
            // lblAmount2
            // 
            this.lblAmount2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount2.AutoSize = true;
            this.lblAmount2.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblAmount2.Location = new System.Drawing.Point(172, 20);
            this.lblAmount2.Name = "lblAmount2";
            this.lblAmount2.Size = new System.Drawing.Size(110, 51);
            this.lblAmount2.TabIndex = 35;
            this.lblAmount2.Text = "00,00";
            this.lblAmount2.TextChanged += new System.EventHandler(this.lblAmount2_TextChanged);
            // 
            // txbIdBook
            // 
            this.txbIdBook.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.txbIdBook.Location = new System.Drawing.Point(10, 112);
            this.txbIdBook.Name = "txbIdBook";
            this.txbIdBook.Size = new System.Drawing.Size(54, 57);
            this.txbIdBook.TabIndex = 37;
            this.txbIdBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbIdBook_KeyDown);
            // 
            // btnLogoutPDV
            // 
            this.btnLogoutPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogoutPDV.AutoSize = true;
            this.btnLogoutPDV.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogoutPDV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogoutPDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLogoutPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutPDV.Location = new System.Drawing.Point(13, 8);
            this.btnLogoutPDV.Name = "btnLogoutPDV";
            this.btnLogoutPDV.Size = new System.Drawing.Size(163, 42);
            this.btnLogoutPDV.TabIndex = 38;
            this.btnLogoutPDV.Text = "ESC - Logout";
            this.btnLogoutPDV.UseVisualStyleBackColor = false;
            this.btnLogoutPDV.Click += new System.EventHandler(this.btnLogoutPDV_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(383, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Qtd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Preço:";
            // 
            // lblAdm
            // 
            this.lblAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdm.AutoEllipsis = true;
            this.lblAdm.AutoSize = true;
            this.lblAdm.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAdm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdm.Location = new System.Drawing.Point(23, 634);
            this.lblAdm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(114, 25);
            this.lblAdm.TabIndex = 41;
            this.lblAdm.Text = "Funcionário";
            // 
            // clhId
            // 
            this.clhId.Text = "ID";
            this.clhId.Width = 50;
            // 
            // clhDescription
            // 
            this.clhDescription.Text = "Descrição";
            this.clhDescription.Width = 260;
            // 
            // clhQuant
            // 
            this.clhQuant.Text = "Qtd";
            this.clhQuant.Width = 55;
            // 
            // clhPrice
            // 
            this.clhPrice.Text = "Unitário";
            this.clhPrice.Width = 95;
            // 
            // clhAmount
            // 
            this.clhAmount.Text = "Total";
            this.clhAmount.Width = 105;
            // 
            // ltvShowCart
            // 
            this.ltvShowCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvShowCart.BackColor = System.Drawing.Color.Gainsboro;
            this.ltvShowCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhDescription,
            this.clhQuant,
            this.clhPrice,
            this.clhAmount});
            this.ltvShowCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ltvShowCart.FullRowSelect = true;
            this.ltvShowCart.HideSelection = false;
            this.ltvShowCart.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ltvShowCart.Location = new System.Drawing.Point(696, 96);
            this.ltvShowCart.MultiSelect = false;
            this.ltvShowCart.Name = "ltvShowCart";
            this.ltvShowCart.Size = new System.Drawing.Size(572, 429);
            this.ltvShowCart.TabIndex = 26;
            this.ltvShowCart.UseCompatibleStateImageBehavior = false;
            this.ltvShowCart.View = System.Windows.Forms.View.Details;
            this.ltvShowCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvShowCart_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Pressione \"Espaço\" para abrir a lista de produtos";
            // 
            // btnClient
            // 
            this.btnClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClient.AutoSize = true;
            this.btnClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(386, 8);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(167, 42);
            this.btnClient.TabIndex = 43;
            this.btnClient.Text = "F5 - Associar Cliente";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Enabled = false;
            this.lblIdClient.Location = new System.Drawing.Point(490, 384);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(0, 13);
            this.lblIdClient.TabIndex = 34;
            this.lblIdClient.Visible = false;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdd.BackColor = System.Drawing.Color.DimGray;
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.btnAddCart);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.nmcQuant);
            this.pnlAdd.Controls.Add(this.txbPrice);
            this.pnlAdd.Controls.Add(this.txbAddBook);
            this.pnlAdd.Controls.Add(this.txbIdBook);
            this.pnlAdd.Location = new System.Drawing.Point(12, 127);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(652, 294);
            this.pnlAdd.TabIndex = 44;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBottom.Controls.Add(this.btnBookClient);
            this.pnlBottom.Controls.Add(this.btnClient);
            this.pnlBottom.Controls.Add(this.btnMenu);
            this.pnlBottom.Controls.Add(this.btnClear);
            this.pnlBottom.Controls.Add(this.btnLogoutPDV);
            this.pnlBottom.Controls.Add(this.btnFinish);
            this.pnlBottom.Location = new System.Drawing.Point(-1, 665);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1282, 62);
            this.pnlBottom.TabIndex = 45;
            // 
            // btnBookClient
            // 
            this.btnBookClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBookClient.AutoSize = true;
            this.btnBookClient.BackColor = System.Drawing.Color.White;
            this.btnBookClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBookClient.Location = new System.Drawing.Point(575, 8);
            this.btnBookClient.Name = "btnBookClient";
            this.btnBookClient.Size = new System.Drawing.Size(176, 42);
            this.btnBookClient.TabIndex = 44;
            this.btnBookClient.Text = "F6 - Livros Disponiveis";
            this.btnBookClient.UseVisualStyleBackColor = false;
            this.btnBookClient.Click += new System.EventHandler(this.btnBookClient_Click);
            // 
            // pnlValue
            // 
            this.pnlValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlValue.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlValue.Controls.Add(this.lblAmount2);
            this.pnlValue.Controls.Add(this.lblAmount);
            this.pnlValue.Location = new System.Drawing.Point(696, 543);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Size = new System.Drawing.Size(572, 91);
            this.pnlValue.TabIndex = 46;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Location = new System.Drawing.Point(0, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1281, 91);
            this.pnlTop.TabIndex = 47;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(864, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 46);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "data";
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.Controls.Add(this.pnlValue);
            this.pnlBack.Controls.Add(this.lblAdm);
            this.pnlBack.Controls.Add(this.llbAddClient);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1280, 720);
            this.pnlBack.TabIndex = 48;
            // 
            // FrmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblIdClient);
            this.Controls.Add(this.ltvShowCart);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCart_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCart_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlValue.ResumeLayout(false);
            this.pnlValue.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.LinkLabel llbAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.TextBox txbAddBook;
        private System.Windows.Forms.NumericUpDown nmcQuant;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblAmount2;
        private System.Windows.Forms.TextBox txbIdBook;
        private System.Windows.Forms.Button btnLogoutPDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhDescription;
        private System.Windows.Forms.ColumnHeader clhQuant;
        private System.Windows.Forms.ColumnHeader clhPrice;
        private System.Windows.Forms.ColumnHeader clhAmount;
        private System.Windows.Forms.ListView ltvShowCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button btnBookClient;
    }
}