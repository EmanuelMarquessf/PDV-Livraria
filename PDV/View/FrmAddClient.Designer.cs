
namespace PDV.View
{
    partial class FrmAddClient
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
            this.ltvShowClient = new System.Windows.Forms.ListView();
            this.clhId_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhName_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCpf_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEmail_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNothing = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBack.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRegister.Location = new System.Drawing.Point(518, 450);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 46);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "F2 - Novo";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ltvShowClient
            // 
            this.ltvShowClient.BackColor = System.Drawing.Color.Gainsboro;
            this.ltvShowClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltvShowClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Client,
            this.clhName_Client,
            this.clhCpf_Client,
            this.clhEmail_Client});
            this.ltvShowClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.ltvShowClient.FullRowSelect = true;
            this.ltvShowClient.HideSelection = false;
            this.ltvShowClient.Location = new System.Drawing.Point(9, 110);
            this.ltvShowClient.MultiSelect = false;
            this.ltvShowClient.Name = "ltvShowClient";
            this.ltvShowClient.Size = new System.Drawing.Size(659, 318);
            this.ltvShowClient.TabIndex = 1;
            this.ltvShowClient.UseCompatibleStateImageBehavior = false;
            this.ltvShowClient.View = System.Windows.Forms.View.Details;
            this.ltvShowClient.DoubleClick += new System.EventHandler(this.ltvShowClient_DoubleClick);
            this.ltvShowClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvShowClient_KeyDown);
            // 
            // clhId_Client
            // 
            this.clhId_Client.Text = "ID";
            this.clhId_Client.Width = 50;
            // 
            // clhName_Client
            // 
            this.clhName_Client.Text = "Nome";
            this.clhName_Client.Width = 200;
            // 
            // clhCpf_Client
            // 
            this.clhCpf_Client.Text = "CPF";
            this.clhCpf_Client.Width = 220;
            // 
            // clhEmail_Client
            // 
            this.clhEmail_Client.Text = "Email";
            this.clhEmail_Client.Width = 160;
            // 
            // btnNothing
            // 
            this.btnNothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnNothing.Location = new System.Drawing.Point(11, 450);
            this.btnNothing.Name = "btnNothing";
            this.btnNothing.Size = new System.Drawing.Size(150, 46);
            this.btnNothing.TabIndex = 3;
            this.btnNothing.Text = "F1 - Nenhum";
            this.btnNothing.UseVisualStyleBackColor = true;
            this.btnNothing.Click += new System.EventHandler(this.btnNothing_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbSearch.Location = new System.Drawing.Point(10, 56);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(522, 38);
            this.txbSearch.TabIndex = 21;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSearch.Location = new System.Drawing.Point(537, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Limpar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.ltvShowClient);
            this.pnlBack.Controls.Add(this.btnSearch);
            this.pnlBack.Controls.Add(this.btnRegister);
            this.pnlBack.Controls.Add(this.btnNothing);
            this.pnlBack.Controls.Add(this.pnlTop);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(681, 509);
            this.pnlBack.TabIndex = 22;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(-1, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(681, 51);
            this.pnlTop.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(233, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Associar Cliente";
            // 
            // FrmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 509);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(464, 412);
            this.Name = "FrmAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar cliente a venda";
            this.Load += new System.EventHandler(this.FrmAddClient_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddClient_KeyDown);
            this.pnlBack.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListView ltvShowClient;
        private System.Windows.Forms.ColumnHeader clhId_Client;
        private System.Windows.Forms.ColumnHeader clhName_Client;
        private System.Windows.Forms.ColumnHeader clhCpf_Client;
        private System.Windows.Forms.ColumnHeader clhEmail_Client;
        private System.Windows.Forms.Button btnNothing;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
    }
}