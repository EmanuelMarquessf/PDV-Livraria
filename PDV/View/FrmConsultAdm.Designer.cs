
namespace PDV.View
{
    partial class FrmConsultAdm
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
            System.Windows.Forms.ColumnHeader clhPassword_Adm;
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clhId_Adm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLogin2_Adm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhName_Adm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvShowAdm = new System.Windows.Forms.ListView();
            this.clhOffice_Adm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            clhPassword_Adm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // clhPassword_Adm
            // 
            clhPassword_Adm.Width = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnRegister.Location = new System.Drawing.Point(469, 490);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(179, 40);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "F2 - Novo";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnCancel.Location = new System.Drawing.Point(12, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clhId_Adm
            // 
            this.clhId_Adm.Text = "ID";
            this.clhId_Adm.Width = 80;
            // 
            // clhLogin2_Adm
            // 
            this.clhLogin2_Adm.Text = "Login";
            this.clhLogin2_Adm.Width = 150;
            // 
            // clhName_Adm
            // 
            this.clhName_Adm.Text = "Nome";
            this.clhName_Adm.Width = 232;
            // 
            // ltvShowAdm
            // 
            this.ltvShowAdm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Adm,
            this.clhLogin2_Adm,
            this.clhName_Adm,
            clhPassword_Adm,
            this.clhOffice_Adm});
            this.ltvShowAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ltvShowAdm.FullRowSelect = true;
            this.ltvShowAdm.HideSelection = false;
            this.ltvShowAdm.Location = new System.Drawing.Point(12, 102);
            this.ltvShowAdm.Name = "ltvShowAdm";
            this.ltvShowAdm.Size = new System.Drawing.Size(636, 355);
            this.ltvShowAdm.TabIndex = 16;
            this.ltvShowAdm.UseCompatibleStateImageBehavior = false;
            this.ltvShowAdm.View = System.Windows.Forms.View.Details;
            this.ltvShowAdm.DoubleClick += new System.EventHandler(this.ltvShowAdm_DoubleClick);
            this.ltvShowAdm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvShowAdm_KeyDown);
            // 
            // clhOffice_Adm
            // 
            this.clhOffice_Adm.Text = "Cargo";
            this.clhOffice_Adm.Width = 170;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearch.Location = new System.Drawing.Point(545, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 39);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Limpar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbSearch.Location = new System.Drawing.Point(10, 55);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(529, 38);
            this.txbSearch.TabIndex = 19;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(-2, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(673, 49);
            this.pnlTop.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Funcionários Cadastrados";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatus.Location = new System.Drawing.Point(12, 460);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(125, 24);
            this.ckbStatus.TabIndex = 50;
            this.ckbStatus.Text = "Exibir Inativos";
            this.ckbStatus.UseVisualStyleBackColor = true;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            // 
            // FrmConsultAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 540);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ltvShowAdm);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(468, 419);
            this.Name = "FrmConsultAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Funcionários";
            this.Load += new System.EventHandler(this.FrmConsultAdm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultAdm_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader clhId_Adm;
        private System.Windows.Forms.ColumnHeader clhLogin2_Adm;
        private System.Windows.Forms.ColumnHeader clhName_Adm;
        private System.Windows.Forms.ListView ltvShowAdm;
        private System.Windows.Forms.ColumnHeader clhOffice_Adm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbStatus;
    }
}