
namespace PDV.View
{
    partial class FrmEditPasswordAdm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txbActualPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNewPassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(11, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 26);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Senha Atual*";
            // 
            // txbActualPassword
            // 
            this.txbActualPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txbActualPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbActualPassword.Location = new System.Drawing.Point(10, 84);
            this.txbActualPassword.Name = "txbActualPassword";
            this.txbActualPassword.PasswordChar = '*';
            this.txbActualPassword.Size = new System.Drawing.Size(497, 38);
            this.txbActualPassword.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(11, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nova senha*";
            // 
            // txbNewPassword1
            // 
            this.txbNewPassword1.BackColor = System.Drawing.Color.LightCyan;
            this.txbNewPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbNewPassword1.Location = new System.Drawing.Point(10, 154);
            this.txbNewPassword1.Name = "txbNewPassword1";
            this.txbNewPassword1.PasswordChar = '*';
            this.txbNewPassword1.Size = new System.Drawing.Size(254, 38);
            this.txbNewPassword1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(265, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Confirmar senha*";
            // 
            // txbNewPassword2
            // 
            this.txbNewPassword2.BackColor = System.Drawing.Color.LightCyan;
            this.txbNewPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbNewPassword2.Location = new System.Drawing.Point(270, 154);
            this.txbNewPassword2.Name = "txbNewPassword2";
            this.txbNewPassword2.PasswordChar = '*';
            this.txbNewPassword2.Size = new System.Drawing.Size(237, 38);
            this.txbNewPassword2.TabIndex = 28;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnCancel.Location = new System.Drawing.Point(10, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSave.Location = new System.Drawing.Point(372, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 40);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Editar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Location = new System.Drawing.Point(-5, -6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(525, 53);
            this.pnlTop.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(199, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Alterar senha";
            // 
            // FrmEditPasswordAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(520, 268);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNewPassword2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNewPassword1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbActualPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEditPasswordAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditPasswordAdm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbActualPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNewPassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNewPassword2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label5;
    }
}