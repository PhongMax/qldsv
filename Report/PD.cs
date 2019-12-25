using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class PD : DevExpress.XtraEditors.XtraForm
    {
        public PD()
        {
            InitializeComponent();
        }

        private void PD_Load(object sender, EventArgs e)
        {

        }

        // ============================= EVENT ============================= //
        private void button_IN_Click(object sender, EventArgs e)
        {
            XtraReport_PD report = new XtraReport_PD("N15DCCN002");
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}