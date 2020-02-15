using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReport_DSDHP : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSDHP(string MALOP, string NIENKHOA, int HOCKI)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;

            sP_REPORT_DSDHPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            sP_REPORT_DSDHPTableAdapter.Fill(ds1.SP_REPORT_DSDHP, MALOP, NIENKHOA, HOCKI);
        }

    }
}
