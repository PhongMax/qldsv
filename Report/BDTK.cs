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
    public partial class BDTK : DevExpress.XtraEditors.XtraForm
    {
        public BDTK()
        {
            InitializeComponent();
        }

        private void BDTK_Load(object sender, EventArgs e)
        {

        }

        // ============================= EVENT ============================= //
        private void button_IN_Click(object sender, EventArgs e)
        {
            //// Chưa làm validate MASV có tồn tại không
            //XtraReport_BDTK report = new XtraReport_BDTK("D16CQCN2");

            //report.lblMaLop.Text = "D16CQCN2";

            //ReportPrintTool print = new ReportPrintTool(report);
            //print.ShowPreviewDialog();
        }
    }
}