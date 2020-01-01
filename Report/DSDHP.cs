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
    public partial class DSDHP : DevExpress.XtraEditors.XtraForm
    {
        public DSDHP()
        {
            InitializeComponent();
        }

        private void DSDHP_Load(object sender, EventArgs e)
        {

        }


        // ============================= EVENT ============================= //
        private void button_IN_Click(object sender, EventArgs e)
        {
            XtraReport_DSDHP report = new XtraReport_DSDHP(this.txtMaLop.Text.Trim().ToString(), this.txtNienKhoa.Text.Trim().ToString(), Int32.Parse(this.txtHocKi.Text.Trim().ToString()));
            report.lblTenLop.Text = this.txtMaLop.Text.Trim().ToString();
            report.lblNienKhoa.Text = this.txtNienKhoa.Text.Trim().ToString();
            report.lblHocKi.Text = this.txtHocKi.Text.Trim().ToString();
            report.lblAuthor.Text = "Người In Ấn : " + Program.MHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}