
namespace PDV.View
{
    partial class FrmEditProduct
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
            this.txbValue = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.nmcQuant = new System.Windows.Forms.NumericUpDown();
            this.LblQuant = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.LblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(174, 86);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(180, 23);
            this.txbValue.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nmcQuant
            // 
            this.nmcQuant.Location = new System.Drawing.Point(15, 86);
            this.nmcQuant.Name = "nmcQuant";
            this.nmcQuant.Size = new System.Drawing.Size(138, 23);
            this.nmcQuant.TabIndex = 11;
            // 
            // LblQuant
            // 
            this.LblQuant.AutoSize = true;
            this.LblQuant.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuant.Location = new System.Drawing.Point(33, 63);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.Size = new System.Drawing.Size(93, 20);
            this.LblQuant.TabIndex = 15;
            this.LblQuant.Text = "Quantidade*";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescription.Location = new System.Drawing.Point(33, 14);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(80, 20);
            this.LblDescription.TabIndex = 12;
            this.LblDescription.Text = "Descrição*";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(15, 37);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(339, 23);
            this.txbDescription.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(10, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Editar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Deletar Produto";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblValue.Location = new System.Drawing.Point(174, 63);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(49, 20);
            this.LblValue.TabIndex = 19;
            this.LblValue.Text = "Valor*";
            // 
            // FrmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 207);
            this.Controls.Add(this.LblValue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.nmcQuant);
            this.Controls.Add(this.LblQuant);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(384, 246);
            this.MinimumSize = new System.Drawing.Size(384, 246);
            this.Name = "FrmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditProduct";
            this.Load += new System.EventHandler(this.FrmEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nmcQuant;
        private System.Windows.Forms.Label LblQuant;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label LblValue;
    }
}