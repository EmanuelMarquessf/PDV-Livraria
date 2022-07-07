
namespace PDV.View
{
    partial class FrmMain
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
            this.BtnBookMenuItem = new System.Windows.Forms.Button();
            this.btnClientMenuItem = new System.Windows.Forms.Button();
            this.btnAdmMenuItem = new System.Windows.Forms.Button();
            this.btnOrderMenuItem = new System.Windows.Forms.Button();
            this.btnReportMenuItem = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBack.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBookMenuItem
            // 
            this.BtnBookMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBookMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnBookMenuItem.Location = new System.Drawing.Point(263, 77);
            this.BtnBookMenuItem.Name = "BtnBookMenuItem";
            this.BtnBookMenuItem.Size = new System.Drawing.Size(188, 62);
            this.BtnBookMenuItem.TabIndex = 1;
            this.BtnBookMenuItem.Text = "F2 - Livros";
            this.BtnBookMenuItem.UseVisualStyleBackColor = true;
            this.BtnBookMenuItem.Click += new System.EventHandler(this.BtnBookMenuItem_Click);
            // 
            // btnClientMenuItem
            // 
            this.btnClientMenuItem.FlatAppearance.BorderSize = 0;
            this.btnClientMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClientMenuItem.Location = new System.Drawing.Point(39, 77);
            this.btnClientMenuItem.Name = "btnClientMenuItem";
            this.btnClientMenuItem.Size = new System.Drawing.Size(188, 62);
            this.btnClientMenuItem.TabIndex = 2;
            this.btnClientMenuItem.Text = "F1 - Clientes";
            this.btnClientMenuItem.UseVisualStyleBackColor = true;
            this.btnClientMenuItem.Click += new System.EventHandler(this.btnClientMenuItem_Click);
            // 
            // btnAdmMenuItem
            // 
            this.btnAdmMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdmMenuItem.Location = new System.Drawing.Point(39, 168);
            this.btnAdmMenuItem.Name = "btnAdmMenuItem";
            this.btnAdmMenuItem.Size = new System.Drawing.Size(188, 62);
            this.btnAdmMenuItem.TabIndex = 3;
            this.btnAdmMenuItem.Text = "F3 - Funcionários";
            this.btnAdmMenuItem.UseVisualStyleBackColor = true;
            this.btnAdmMenuItem.Click += new System.EventHandler(this.btnAdmMenuItem_Click);
            // 
            // btnOrderMenuItem
            // 
            this.btnOrderMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnOrderMenuItem.Location = new System.Drawing.Point(263, 168);
            this.btnOrderMenuItem.Name = "btnOrderMenuItem";
            this.btnOrderMenuItem.Size = new System.Drawing.Size(188, 62);
            this.btnOrderMenuItem.TabIndex = 4;
            this.btnOrderMenuItem.Text = "F4 - Vendas";
            this.btnOrderMenuItem.UseVisualStyleBackColor = true;
            this.btnOrderMenuItem.Click += new System.EventHandler(this.btnOrderMenuItem_Click);
            // 
            // btnReportMenuItem
            // 
            this.btnReportMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReportMenuItem.Location = new System.Drawing.Point(39, 265);
            this.btnReportMenuItem.Name = "btnReportMenuItem";
            this.btnReportMenuItem.Size = new System.Drawing.Size(412, 62);
            this.btnReportMenuItem.TabIndex = 5;
            this.btnReportMenuItem.Text = "Voltar";
            this.btnReportMenuItem.UseVisualStyleBackColor = true;
            this.btnReportMenuItem.Click += new System.EventHandler(this.btnReportMenuItem_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.LightGray;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.pnlTop);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(479, 339);
            this.pnlBack.TabIndex = 6;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Location = new System.Drawing.Point(-10, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(526, 55);
            this.pnlTop.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(191, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 44);
            this.label1.TabIndex = 29;
            this.label1.Text = "Menu ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 339);
            this.Controls.Add(this.btnReportMenuItem);
            this.Controls.Add(this.btnOrderMenuItem);
            this.Controls.Add(this.btnAdmMenuItem);
            this.Controls.Add(this.btnClientMenuItem);
            this.Controls.Add(this.BtnBookMenuItem);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.pnlBack.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBookMenuItem;
        private System.Windows.Forms.Button btnClientMenuItem;
        private System.Windows.Forms.Button btnAdmMenuItem;
        private System.Windows.Forms.Button btnOrderMenuItem;
        private System.Windows.Forms.Button btnReportMenuItem;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
    }
}