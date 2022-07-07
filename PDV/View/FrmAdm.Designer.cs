
namespace PDV.View
{
    partial class FrmAdm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbbOffice = new System.Windows.Forms.ComboBox();
            this.lblFunc = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSave.Location = new System.Drawing.Point(366, 296);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.Color.LightCyan;
            this.txbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbLogin.Location = new System.Drawing.Point(263, 97);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(238, 38);
            this.txbLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(258, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login*";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbPassword.Location = new System.Drawing.Point(8, 165);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(251, 38);
            this.txbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.button1.Location = new System.Drawing.Point(8, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.LightCyan;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(8, 97);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(251, 38);
            this.txbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(11, 69);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 26);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Nome*";
            // 
            // cbbOffice
            // 
            this.cbbOffice.BackColor = System.Drawing.Color.LightCyan;
            this.cbbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbbOffice.FormattingEnabled = true;
            this.cbbOffice.Items.AddRange(new object[] {
            "Administrador",
            "Estoquista",
            "Atendente"});
            this.cbbOffice.Location = new System.Drawing.Point(8, 234);
            this.cbbOffice.Name = "cbbOffice";
            this.cbbOffice.Size = new System.Drawing.Size(493, 39);
            this.cbbOffice.TabIndex = 5;
            this.cbbOffice.SelectedIndexChanged += new System.EventHandler(this.cbbOffice_SelectedIndexChanged);
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFunc.Location = new System.Drawing.Point(13, 205);
            this.lblFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(80, 26);
            this.lblFunc.TabIndex = 33;
            this.lblFunc.Text = "Cargo*";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(-2, -2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(525, 53);
            this.pnlTop.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(121, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cadastro de Funcionário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(258, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "Confirmar senha*";
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbConfirmPassword.Location = new System.Drawing.Point(263, 165);
            this.txbConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.PasswordChar = '*';
            this.txbConfirmPassword.Size = new System.Drawing.Size(238, 38);
            this.txbConfirmPassword.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.btnClear.Location = new System.Drawing.Point(188, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 40);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "F1 - Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.cbbOffice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(297, 180);
            this.Name = "FrmAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAdm_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbbOffice;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.Button btnClear;
    }
}