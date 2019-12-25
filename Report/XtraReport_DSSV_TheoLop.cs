using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReport_DSSV_TheoLop : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSSV_TheoLop(string MALOP)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_DSSVTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sP_REPORT_DSSVTableAdapter.Fill(ds1.SP_REPORT_DSSV, MALOP);
        }

    }
}
