using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReport_BDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_BDMH(string MALOP, string MAMONHOC, int LAN)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_BDMHTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sP_REPORT_BDMHTableAdapter.Fill(ds1.SP_REPORT_BDMH, MALOP, MAMONHOC, LAN);
        }

    }
}
