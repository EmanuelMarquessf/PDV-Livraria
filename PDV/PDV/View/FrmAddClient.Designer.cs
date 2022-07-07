
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
            this.clhFone_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNothing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(309, 334);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 46);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Novo Cliente";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ltvShowClient
            // 
            this.ltvShowClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Client,
            this.clhName_Client,
            this.clhCpf_Client,
            this.clhEmail_Client,
            this.clhFone_Client});
            this.ltvShowClient.FullRowSelect = true;
            this.ltvShowClient.HideSelection = false;
            this.ltvShowClient.Location = new System.Drawing.Point(10, 55);
            this.ltvShowClient.Name = "ltvShowClient";
            this.ltvShowClient.Size = new System.Drawing.Size(414, 253);
            this.ltvShowClient.TabIndex = 16;
            this.ltvShowClient.UseCompatibleStateImageBehavior = false;
            this.ltvShowClient.View = System.Windows.Forms.View.Details;
            this.ltvShowClient.DoubleClick += new System.EventHandler(this.ltvShowClient_DoubleClick);
            // 
            // clhId_Client
            // 
            this.clhId_Client.Text = "ID";
            this.clhId_Client.Width = 23;
            // 
            // clhName_Client
            // 
            this.clhName_Client.Text = "Nome";
            this.clhName_Client.Width = 100;
            // 
            // clhCpf_Client
            // 
            this.clhCpf_Client.Text = "CPF";
            this.clhCpf_Client.Width = 75;
            // 
            // clhEmail_Client
            // 
            this.clhEmail_Client.Text = "E-Mail";
            this.clhEmail_Client.Width = 110;
            // 
            // clhFone_Client
            // 
            this.clhFone_Client.Text = "Telefone";
            this.clhFone_Client.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Associar Cliente";
            // 
            // btnNothing
            // 
            this.btnNothing.Location = new System.Drawing.Point(10, 334);
            this.btnNothing.Name = "btnNothing";
            this.btnNothing.Size = new System.Drawing.Size(115, 46);
            this.btnNothing.TabIndex = 19;
            this.btnNothing.Text = "Nenhum";
            this.btnNothing.UseVisualStyleBackColor = true;
            this.btnNothing.Click += new System.EventHandler(this.btnNothing_Click);
            // 
            // FrmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 429);
            this.Controls.Add(this.btnNothing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ltvShowClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(437, 429);
            this.Name = "FrmAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddClient";
            this.Load += new System.EventHandler(this.FrmAddClient_Load);
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
        private System.Windows.Forms.ColumnHeader clhFone_Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNothing;
    }
}