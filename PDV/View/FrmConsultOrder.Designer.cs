
namespace PDV.View
{
    partial class FrmConsultOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pDVDataSet = new PDV.PDVDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new PDV.PDVDataSetTableAdapters.OrderTableAdapter();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Adm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.nameClientDataGridViewTextBoxColumn,
            this.CPF_Client,
            this.Name_Adm,
            this.dateOrderDataGridViewTextBoxColumn,
            this.payFormDataGridViewTextBoxColumn,
            this.amountOrderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // orderBindingSource3
            // 
            this.orderBindingSource3.DataMember = "Order";
            this.orderBindingSource3.DataSource = this.pDVDataSet;
            this.orderBindingSource3.CurrentChanged += new System.EventHandler(this.orderBindingSource3_CurrentChanged);
            // 
            // pDVDataSet
            // 
            this.pDVDataSet.DataSetName = "PDVDataSet";
            this.pDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBack.Location = new System.Drawing.Point(12, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnGetReport.Location = new System.Drawing.Point(763, 496);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(179, 40);
            this.btnGetReport.TabIndex = 2;
            this.btnGetReport.Text = "Gerar Relatório";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Visible = false;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(0, -7);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(956, 60);
            this.pnlTop.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(374, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Vendas";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbSearch.Location = new System.Drawing.Point(12, 65);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(795, 38);
            this.txbSearch.TabIndex = 52;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.Location = new System.Drawing.Point(813, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 38);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 548);
            this.panel1.TabIndex = 53;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.pDVDataSet;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.pDVDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataMember = "Order";
            this.orderBindingSource2.DataSource = this.pDVDataSet;
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "Id_Order";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOrderDataGridViewTextBoxColumn.Width = 53;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Visible = false;
            this.idClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameClientDataGridViewTextBoxColumn
            // 
            this.nameClientDataGridViewTextBoxColumn.DataPropertyName = "Name_Client";
            this.nameClientDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameClientDataGridViewTextBoxColumn.Name = "nameClientDataGridViewTextBoxColumn";
            this.nameClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameClientDataGridViewTextBoxColumn.Width = 175;
            // 
            // CPF_Client
            // 
            this.CPF_Client.DataPropertyName = "CPF_Client";
            this.CPF_Client.HeaderText = "CPF";
            this.CPF_Client.Name = "CPF_Client";
            this.CPF_Client.ReadOnly = true;
            this.CPF_Client.Width = 150;
            // 
            // Name_Adm
            // 
            this.Name_Adm.DataPropertyName = "Name_Adm";
            this.Name_Adm.HeaderText = "Funcionário";
            this.Name_Adm.Name = "Name_Adm";
            this.Name_Adm.ReadOnly = true;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "Date_Order";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dateOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payFormDataGridViewTextBoxColumn
            // 
            this.payFormDataGridViewTextBoxColumn.DataPropertyName = "Pay_Form";
            this.payFormDataGridViewTextBoxColumn.HeaderText = "F. Pagamento";
            this.payFormDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payFormDataGridViewTextBoxColumn.Name = "payFormDataGridViewTextBoxColumn";
            this.payFormDataGridViewTextBoxColumn.ReadOnly = true;
            this.payFormDataGridViewTextBoxColumn.Width = 143;
            // 
            // amountOrderDataGridViewTextBoxColumn
            // 
            this.amountOrderDataGridViewTextBoxColumn.DataPropertyName = "Amount_Order";
            this.amountOrderDataGridViewTextBoxColumn.HeaderText = "Valor (R$)";
            this.amountOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountOrderDataGridViewTextBoxColumn.Name = "amountOrderDataGridViewTextBoxColumn";
            this.amountOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountOrderDataGridViewTextBoxColumn.Width = 155;
            // 
            // FrmConsultOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(954, 548);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(602, 285);
            this.Name = "FrmConsultOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Vendas";
            this.Load += new System.EventHandler(this.FrmConsultOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PDVDataSet pDVDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private PDVDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Adm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payFormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOrderDataGridViewTextBoxColumn;
    }
}