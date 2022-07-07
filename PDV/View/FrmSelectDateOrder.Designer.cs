
namespace PDV.View
{
    partial class FrmSelectDateOrder
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
            this.dtpDateOrder1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOrder2 = new System.Windows.Forms.DateTimePicker();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateOrder1
            // 
            this.dtpDateOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpDateOrder1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOrder1.Location = new System.Drawing.Point(12, 71);
            this.dtpDateOrder1.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateOrder1.MaximumSize = new System.Drawing.Size(145, 23);
            this.dtpDateOrder1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateOrder1.MinimumSize = new System.Drawing.Size(145, 23);
            this.dtpDateOrder1.Name = "dtpDateOrder1";
            this.dtpDateOrder1.Size = new System.Drawing.Size(145, 23);
            this.dtpDateOrder1.TabIndex = 0;
            // 
            // dtpDateOrder2
            // 
            this.dtpDateOrder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpDateOrder2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOrder2.Location = new System.Drawing.Point(181, 71);
            this.dtpDateOrder2.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateOrder2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateOrder2.Name = "dtpDateOrder2";
            this.dtpDateOrder2.Size = new System.Drawing.Size(145, 23);
            this.dtpDateOrder2.TabIndex = 1;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDate1.Location = new System.Drawing.Point(8, 48);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(98, 20);
            this.lblDate1.TabIndex = 2;
            this.lblDate1.Text = "Data Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(177, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Final:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTitle.Location = new System.Drawing.Point(57, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Selecione o Periodo:";
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(204, 114);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(115, 34);
            this.btnGetOrder.TabIndex = 6;
            this.btnGetOrder.Text = "Gerar Relatório";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 114);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmSelectDateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 155);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate1);
            this.Controls.Add(this.dtpDateOrder2);
            this.Controls.Add(this.dtpDateOrder1);
            this.MaximumSize = new System.Drawing.Size(354, 194);
            this.MinimumSize = new System.Drawing.Size(354, 194);
            this.Name = "FrmSelectDateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectDateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOrder1;
        private System.Windows.Forms.DateTimePicker dtpDateOrder2;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Button btnBack;
    }
}