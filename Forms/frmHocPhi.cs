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

namespace QLDSV.Forms
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            DataTable tblDiem = Program.ExecSqlDataTable("EXEC	[dbo].[SP_DSSV_MH] @malop = N'd16cqc1'");

            this.gridControl1.DataSource = tblDiem;


        }
    }
}