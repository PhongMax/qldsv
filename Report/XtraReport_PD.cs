using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReport_PD : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_PD(string MASV)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_PDTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sP_REPORT_PDTableAdapter.Fill(ds1.SP_REPORT_PD, MASV);
        }

    }
}
