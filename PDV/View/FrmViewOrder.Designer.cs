
namespace PDV.View
{
    partial class FrmViewOrder
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
            System.Windows.Forms.ColumnHeader clhvalue_Book;
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFunc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblAuthorText = new System.Windows.Forms.Label();
            this.lblPayForm = new System.Windows.Forms.Label();
            this.ltvShowItemOrder = new System.Windows.Forms.ListView();
            this.clhId_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTitle_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCover_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQtd_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            clhvalue_Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clhvalue_Book
            // 
            clhvalue_Book.Text = "Valor";
            clhvalue_Book.Width = 80;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.lblId);
            this.pnlTop.Controls.Add(this.lblTitleText);
            this.pnlTop.ForeColor = System.Drawing.Color.Black;
            this.pnlTop.Location = new System.Drawing.Point(-1, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(574, 48);
            this.pnlTop.TabIndex = 15;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(381, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 31);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(320, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(94, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 31);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitleText.ForeColor = System.Drawing.Color.White;
            this.lblTitleText.Location = new System.Drawing.Point(3, 13);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(94, 24);
            this.lblTitleText.TabIndex = 0;
            this.lblTitleText.Text = "N Pedido:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblFunc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblClient);
            this.panel2.Controls.Add(this.lblAuthorText);
            this.panel2.Location = new System.Drawing.Point(13, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 43);
            this.panel2.TabIndex = 17;
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblFunc.Location = new System.Drawing.Point(357, 7);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(76, 29);
            this.lblFunc.TabIndex = 5;
            this.lblFunc.Text = "client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(292, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aten:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblClient.Location = new System.Drawing.Point(86, 7);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(76, 29);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "client";
            // 
            // lblAuthorText
            // 
            this.lblAuthorText.AutoSize = true;
            this.lblAuthorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAuthorText.Location = new System.Drawing.Point(3, 10);
            this.lblAuthorText.Name = "lblAuthorText";
            this.lblAuthorText.Size = new System.Drawing.Size(86, 26);
            this.lblAuthorText.TabIndex = 2;
            this.lblAuthorText.Text = "Cliente:";
            // 
            // lblPayForm
            // 
            this.lblPayForm.AutoSize = true;
            this.lblPayForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblPayForm.Location = new System.Drawing.Point(359, 15);
            this.lblPayForm.Name = "lblPayForm";
            this.lblPayForm.Size = new System.Drawing.Size(57, 20);
            this.lblPayForm.TabIndex = 5;
            this.lblPayForm.Text = "forma";
            // 
            // ltvShowItemOrder
            // 
            this.ltvShowItemOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Book,
            this.clhTitle_Book,
            this.clhCover_Book,
            this.clhQtd_Book,
            clhvalue_Book});
            this.ltvShowItemOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ltvShowItemOrder.FullRowSelect = true;
            this.ltvShowItemOrder.HideSelection = false;
            this.ltvShowItemOrder.Location = new System.Drawing.Point(13, 154);
            this.ltvShowItemOrder.Name = "ltvShowItemOrder";
            this.ltvShowItemOrder.Size = new System.Drawing.Size(547, 177);
            this.ltvShowItemOrder.TabIndex = 17;
            this.ltvShowItemOrder.UseCompatibleStateImageBehavior = false;
            this.ltvShowItemOrder.View = System.Windows.Forms.View.Details;
            // 
            // clhId_Book
            // 
            this.clhId_Book.Text = "ID";
            this.clhId_Book.Width = 40;
            // 
            // clhTitle_Book
            // 
            this.clhTitle_Book.Text = "Titulo";
            this.clhTitle_Book.Width = 260;
            // 
            // clhCover_Book
            // 
            this.clhCover_Book.Text = "Capa";
            this.clhCover_Book.Width = 103;
            // 
            // clhQtd_Book
            // 
            this.clhQtd_Book.Text = "Qtd.";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBack.Location = new System.Drawing.Point(13, 402);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 37);
            this.btnBack.TabIndex = 71;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.ltvShowItemOrder);
            this.panel4.Controls.Add(this.pnlTop);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 449);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblCPF);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblPayForm);
            this.panel3.Location = new System.Drawing.Point(13, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 43);
            this.panel3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "CPF:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblCPF.Location = new System.Drawing.Point(60, 15);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(45, 20);
            this.lblCPF.TabIndex = 73;
            this.lblCPF.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.Location = new System.Drawing.Point(255, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Pagamento:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Location = new System.Drawing.Point(13, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 42);
            this.panel1.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(335, 2);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(93, 37);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Valor";
            // 
            // FrmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 449);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViewOrder";
            this.Load += new System.EventHandler(this.FrmViewOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmViewOrder_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblAuthorText;
        private System.Windows.Forms.Label lblPayForm;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ltvShowItemOrder;
        private System.Windows.Forms.ColumnHeader clhId_Book;
        private System.Windows.Forms.ColumnHeader clhTitle_Book;
        private System.Windows.Forms.ColumnHeader clhQtd_Book;
        private System.Windows.Forms.ColumnHeader clhCover_Book;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPF;
    }
}