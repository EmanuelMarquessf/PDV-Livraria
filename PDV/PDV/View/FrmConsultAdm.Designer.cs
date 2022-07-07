
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clhId_Adm = new System.Windows.Forms.ColumnHeader();
            this.clhLogin2_Adm = new System.Windows.Forms.ColumnHeader();
            this.clhName_Adm = new System.Windows.Forms.ColumnHeader();
            this.ltvShowAdm = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(212, 333);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 53);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Novo Administrador";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 53);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clhId_Adm
            // 
            this.clhId_Adm.Text = "ID";
            this.clhId_Adm.Width = 30;
            // 
            // clhLogin2_Adm
            // 
            this.clhLogin2_Adm.Text = "Login";
            this.clhLogin2_Adm.Width = 150;
            // 
            // clhName_Adm
            // 
            this.clhName_Adm.Text = "Nome";
            this.clhName_Adm.Width = 150;
            // 
            // ltvShowAdm
            // 
            this.ltvShowAdm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Adm,
            this.clhLogin2_Adm,
            this.clhName_Adm});
            this.ltvShowAdm.FullRowSelect = true;
            this.ltvShowAdm.HideSelection = false;
            this.ltvShowAdm.Location = new System.Drawing.Point(12, 12);
            this.ltvShowAdm.Name = "ltvShowAdm";
            this.ltvShowAdm.Size = new System.Drawing.Size(334, 293);
            this.ltvShowAdm.TabIndex = 16;
            this.ltvShowAdm.UseCompatibleStateImageBehavior = false;
            this.ltvShowAdm.View = System.Windows.Forms.View.Details;
            this.ltvShowAdm.DoubleClick += new System.EventHandler(this.ltvShowAdm_DoubleClick);
            // 
            // FrmConsultAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 398);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ltvShowAdm);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmConsultAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultAdm";
            this.Load += new System.EventHandler(this.FrmConsultAdm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader clhId_Adm;
        private System.Windows.Forms.ColumnHeader clhLogin2_Adm;
        private System.Windows.Forms.ColumnHeader clhName_Adm;
        private System.Windows.Forms.ListView ltvShowAdm;
    }
}