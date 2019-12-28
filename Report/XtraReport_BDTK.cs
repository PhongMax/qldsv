using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XtraReport_BDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_BDTK(string MALOP)
        {
            InitializeComponent();

            ds1.EnforceConstraints = false;
            this.sP_REPORT_BDTKTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sP_REPORT_BDTKTableAdapter.Fill(ds1.SP_REPORT_BDTK, MALOP);
        }

    }
}
