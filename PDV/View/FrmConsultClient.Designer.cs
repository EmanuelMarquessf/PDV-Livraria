
namespace PDV.View
{
    partial class FrmConsultClient
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.ltvShowClient = new System.Windows.Forms.ListView();
            this.clhId_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhName_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCpf_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEmail_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFone_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ltvShowClient
            // 
            this.ltvShowClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Client,
            this.clhName_Client,
            this.clhCpf_Client,
            this.clhEmail_Client,
            this.clhFone_Client});
            this.ltvShowClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ltvShowClient.FullRowSelect = true;
            this.ltvShowClient.HideSelection = false;
            this.ltvShowClient.Location = new System.Drawing.Point(12, 100);
            this.ltvShowClient.Name = "ltvShowClient";
            this.ltvShowClient.Size = new System.Drawing.Size(682, 391);
            this.ltvShowClient.TabIndex = 13;
            this.ltvShowClient.UseCompatibleStateImageBehavior = false;
            this.ltvShowClient.View = System.Windows.Forms.View.Details;
            this.ltvShowClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvShowClient_KeyDown);
            this.ltvShowClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvShowClient_MouseDoubleClick);
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
            this.clhCpf_Client.Width = 150;
            // 
            // clhEmail_Client
            // 
            this.clhEmail_Client.Text = "E-Mail";
            this.clhEmail_Client.Width = 140;
            // 
            // clhFone_Client
            // 
            this.clhFone_Client.Text = "Telefone";
            this.clhFone_Client.Width = 130;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRegister.Location = new System.Drawing.Point(515, 528);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(179, 40);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "F2 - Novo";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGetReport.Location = new System.Drawing.Point(256, 528);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(196, 40);
            this.btnGetReport.TabIndex = 15;
            this.btnGetReport.Text = "F1 - Gerar Relatório";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Visible = false;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbSearch.Location = new System.Drawing.Point(10, 55);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(574, 38);
            this.txbSearch.TabIndex = 21;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearch.Location = new System.Drawing.Point(590, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Limpar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(-5, -2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(746, 52);
            this.pnlTop.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(213, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Clientes Cadastrados";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBack.Location = new System.Drawing.Point(10, 528);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 40);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "ESC - Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatus.Location = new System.Drawing.Point(12, 498);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(125, 24);
            this.ckbStatus.TabIndex = 51;
            this.ckbStatus.Text = "Exibir Inativos";
            this.ckbStatus.UseVisualStyleBackColor = true;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            // 
            // FrmConsultClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 574);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ltvShowClient);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(468, 419);
            this.Name = "FrmConsultClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.FrmClient_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultClient_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView ltvShowClient;
        private System.Windows.Forms.ColumnHeader clhId_Client;
        private System.Windows.Forms.ColumnHeader clhName_Client;
        private System.Windows.Forms.ColumnHeader clhCpf_Client;
        private System.Windows.Forms.ColumnHeader clhEmail_Client;
        private System.Windows.Forms.ColumnHeader clhFone_Client;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox ckbStatus;
    }
}