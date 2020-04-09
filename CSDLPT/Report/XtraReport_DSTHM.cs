using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReport_DSTHM : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSTHM(string MALOP)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_DSTHMTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sP_REPORT_DSTHMTableAdapter.Fill(ds1.SP_REPORT_DSTHM, MALOP);
        }

    }
}
