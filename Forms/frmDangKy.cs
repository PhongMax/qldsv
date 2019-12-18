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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmĐangKy_Load(object sender, EventArgs e)
        {
            // khoa chỉ được quyền đăng ký cho khoa
            if (Program.MGroup == Program.NhomQuyen[1])
            {
                rdoKhoa.Checked = true;
                rdoPGV.Enabled = rdoPKeToan.Enabled = false;
            } // học phí chỉ được quyền đăng ký cho học phí
            else if (Program.MGroup == Program.NhomQuyen[2])
            {
                rdoPKeToan.Checked = true;
                rdoPKeToan.Enabled = rdoKhoa.Enabled = false;
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Properties.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }
    }
}