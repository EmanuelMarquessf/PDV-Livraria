
namespace PDV.View
{
    partial class FrmEditAdm
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFunc = new System.Windows.Forms.Label();
            this.cbbOffice = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnChangePassword.Location = new System.Drawing.Point(185, 227);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(135, 40);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "F1 - Alterar senha";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbbStatus.Location = new System.Drawing.Point(251, 154);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(238, 39);
            this.cbbStatus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(246, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 65;
            this.label2.Text = "Status*";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(-14, -8);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(525, 53);
            this.pnlTop.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(169, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Editar Funcionário";
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFunc.Location = new System.Drawing.Point(5, 125);
            this.lblFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(71, 26);
            this.lblFunc.TabIndex = 76;
            this.lblFunc.Text = "Cargo";
            // 
            // cbbOffice
            // 
            this.cbbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbbOffice.FormattingEnabled = true;
            this.cbbOffice.Items.AddRange(new object[] {
            "Administrador",
            "Estoquista",
            "Atendente"});
            this.cbbOffice.Location = new System.Drawing.Point(10, 154);
            this.cbbOffice.Name = "cbbOffice";
            this.cbbOffice.Size = new System.Drawing.Size(237, 39);
            this.cbbOffice.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(5, 57);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 26);
            this.lblName.TabIndex = 74;
            this.lblName.Text = "Nome*";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(10, 85);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(237, 38);
            this.txbName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnCancel.Location = new System.Drawing.Point(10, 227);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(246, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 72;
            this.label4.Text = "Login*";
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.Color.LightCyan;
            this.txbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbLogin.Location = new System.Drawing.Point(251, 85);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(238, 38);
            this.txbLogin.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSave.Location = new System.Drawing.Point(354, 227);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Editar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmEditAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 276);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.cbbOffice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(296, 180);
            this.Name = "FrmEditAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar funcionário";
            this.Load += new System.EventHandler(this.FrmEditAdm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEditAdm_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.ComboBox cbbOffice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button btnSave;
    }
}