
namespace PDV.View
{
    partial class FrmReportOrder
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProduct = new PDV.DataSetProduct();
            this.orderClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOrder = new PDV.DataSetOrder();
            this.orderClientTableAdapter = new PDV.DataSetOrderTableAdapters.OrderClientTableAdapter();
            this.productTableAdapter = new PDV.DataSetProductTableAdapters.ProductTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dataSetProduct;
            // 
            // dataSetProduct
            // 
            this.dataSetProduct.DataSetName = "DataSetProduct";
            this.dataSetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderClientBindingSource
            // 
            this.orderClientBindingSource.DataMember = "OrderClient";
            this.orderClientBindingSource.DataSource = this.dataSetOrder;
            // 
            // dataSetOrder
            // 
            this.dataSetOrder.DataSetName = "DataSetOrder";
            this.dataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderClientTableAdapter
            // 
            this.orderClientTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtsProduct";
            reportDataSource1.Value = this.productBindingSource;
            reportDataSource2.Name = "dtsOrder";
            reportDataSource2.Value = this.orderClientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PDV.Relatorios.Order.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(673, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmReportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(693, 489);
            this.MinimumSize = new System.Drawing.Size(693, 489);
            this.Name = "FrmReportOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportOrder";
            this.Load += new System.EventHandler(this.FrmReportOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetOrder dataSetOrder;
        private System.Windows.Forms.BindingSource orderClientBindingSource;
        private DataSetOrderTableAdapters.OrderClientTableAdapter orderClientTableAdapter;
        private DataSetProduct dataSetProduct;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DataSetProductTableAdapters.ProductTableAdapter productTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}