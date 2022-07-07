
namespace PDV.View
{
    partial class FrmProduct
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblQuant = new System.Windows.Forms.Label();
            this.nmcQuant = new System.Windows.Forms.NumericUpDown();
            this.LblValue = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Cadastrar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(12, 39);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(339, 23);
            this.txbDescription.TabIndex = 1;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescription.Location = new System.Drawing.Point(30, 16);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(80, 20);
            this.LblDescription.TabIndex = 4;
            this.LblDescription.Text = "Descrição*";
            // 
            // LblQuant
            // 
            this.LblQuant.AutoSize = true;
            this.LblQuant.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuant.Location = new System.Drawing.Point(30, 65);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.Size = new System.Drawing.Size(93, 20);
            this.LblQuant.TabIndex = 5;
            this.LblQuant.Text = "Quantidade*";
            // 
            // nmcQuant
            // 
            this.nmcQuant.Location = new System.Drawing.Point(12, 88);
            this.nmcQuant.Name = "nmcQuant";
            this.nmcQuant.Size = new System.Drawing.Size(138, 23);
            this.nmcQuant.TabIndex = 2;
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblValue.Location = new System.Drawing.Point(182, 65);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(49, 20);
            this.LblValue.TabIndex = 8;
            this.LblValue.Text = "Valor*";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(182, 88);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(169, 23);
            this.txbValue.TabIndex = 9;
            // 
            // FrmCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 176);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.LblValue);
            this.Controls.Add(this.nmcQuant);
            this.Controls.Add(this.LblQuant);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(384, 215);
            this.MinimumSize = new System.Drawing.Size(384, 215);
            this.Name = "FrmCostumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmCostumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblQuant;
        private System.Windows.Forms.NumericUpDown nmcQuant;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbValue;
    }
}