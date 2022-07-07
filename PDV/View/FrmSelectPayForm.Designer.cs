
namespace PDV.View
{
    partial class FrmSelectPayForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPagament = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTotalValue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbReceivedValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbValueChange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBack.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // cbbPagament
            // 
            this.cbbPagament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPagament.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbbPagament.FormattingEnabled = true;
            this.cbbPagament.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartao de Credito",
            "Cartao de Debito",
            "Pix"});
            this.cbbPagament.Location = new System.Drawing.Point(12, 75);
            this.cbbPagament.Name = "cbbPagament";
            this.cbbPagament.Size = new System.Drawing.Size(489, 39);
            this.cbbPagament.TabIndex = 33;
            this.cbbPagament.SelectedIndexChanged += new System.EventHandler(this.cbbPagament_SelectedIndexChanged_1);
            this.cbbPagament.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbPagament_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(162, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Finalizar Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "Valor Total:";
            // 
            // txbTotalValue
            // 
            this.txbTotalValue.BackColor = System.Drawing.SystemColors.Window;
            this.txbTotalValue.Enabled = false;
            this.txbTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbTotalValue.Location = new System.Drawing.Point(12, 152);
            this.txbTotalValue.Margin = new System.Windows.Forms.Padding(2);
            this.txbTotalValue.Name = "txbTotalValue";
            this.txbTotalValue.Size = new System.Drawing.Size(490, 38);
            this.txbTotalValue.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSave.Location = new System.Drawing.Point(326, 274);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 37);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Finalizar Venda";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // txbReceivedValue
            // 
            this.txbReceivedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbReceivedValue.Location = new System.Drawing.Point(17, 220);
            this.txbReceivedValue.Margin = new System.Windows.Forms.Padding(2);
            this.txbReceivedValue.Name = "txbReceivedValue";
            this.txbReceivedValue.Size = new System.Drawing.Size(244, 38);
            this.txbReceivedValue.TabIndex = 40;
            this.txbReceivedValue.TextChanged += new System.EventHandler(this.txbReceivedValue_TextChanged);
            this.txbReceivedValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbReceivedValue_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Valor Recebido:";
            // 
            // txbValueChange
            // 
            this.txbValueChange.Enabled = false;
            this.txbValueChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbValueChange.Location = new System.Drawing.Point(274, 220);
            this.txbValueChange.Margin = new System.Windows.Forms.Padding(2);
            this.txbValueChange.Name = "txbValueChange";
            this.txbValueChange.Size = new System.Drawing.Size(228, 38);
            this.txbValueChange.TabIndex = 42;
            this.txbValueChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbValueChange_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(269, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "Troco:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(17, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 37);
            this.button1.TabIndex = 43;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.cbbPagament);
            this.pnlBack.Controls.Add(this.txbTotalValue);
            this.pnlBack.Controls.Add(this.txbValueChange);
            this.pnlBack.Controls.Add(this.button1);
            this.pnlBack.Controls.Add(this.txbReceivedValue);
            this.pnlBack.Controls.Add(this.btnSave);
            this.pnlBack.Controls.Add(this.label2);
            this.pnlBack.Controls.Add(this.label5);
            this.pnlBack.Controls.Add(this.label3);
            this.pnlBack.Controls.Add(this.label4);
            this.pnlBack.Controls.Add(this.pnlTop);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(513, 322);
            this.pnlBack.TabIndex = 44;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Location = new System.Drawing.Point(0, -8);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(513, 51);
            this.pnlTop.TabIndex = 44;
            // 
            // FrmSelectPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 322);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSelectPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectPayForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelectPayForm_KeyDown);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPagament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTotalValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbReceivedValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbValueChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlTop;
    }
}