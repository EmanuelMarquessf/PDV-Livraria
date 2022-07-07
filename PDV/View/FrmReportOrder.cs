using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.View
{
    public partial class FrmReportOrder : Form
    {
        public DateTime PropStar { get; set; }
        public DateTime PropFinish{ get; set; }
        public FrmReportOrder(DateTime dateOrder_Start, DateTime dateOrder_Finish)
        {
            PropStar = dateOrder_Start;
            PropFinish = dateOrder_Finish;
            InitializeComponent();
        }

        private void FrmReportOrder_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetProduct.Product'. Você pode movê-la ou removê-la conforme necessário.
            this.productTableAdapter.Fill(this.dataSetProduct.Product);
            // TODO: esta linha de código carrega dados na tabela 'dataSetOrder.OrderClient'. Você pode movê-la ou removê-la conforme necessário.
            //this.orderClientTableAdapter.GetData(PropStar.ToString(), PropFinish.ToString());
            this.orderClientTableAdapter.FillByDate(this.dataSetOrder.OrderClient, PropStar.ToString(), PropFinish.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
