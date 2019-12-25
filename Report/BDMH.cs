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
    public partial class BDMH : DevExpress.XtraEditors.XtraForm
    {
        public BDMH()
        {
            InitializeComponent();
        }


        // ============================= EVENT ============================= //
        private void button_IN_Click(object sender, EventArgs e)
        {
            XtraReport_BDMH report = new XtraReport_BDMH("D16CQCN2", "CSDL", 1);

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}