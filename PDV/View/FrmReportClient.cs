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
    public partial class FrmReportClient : Form
    {
        public FrmReportClient()
        {
            InitializeComponent();
        }

        private void FrmReportClient_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetClient.Client'. Você pode movê-la ou removê-la conforme necessário.
            this.clientTableAdapter.Fill(this.dataSetClient.Client);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
