using DevExpress.XtraEditors;
using QLDSV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // TODO: flag dangxuat giúp giải việc sự nhọc nhằng giữa sự kiện form closing với dòng lệnh Program.frmMain.Close();

        Boolean dangxuat = false;

        public frmMain()
        {
            InitializeComponent();
        }

        // TODO : HANDLE CONTROL CHILDREN
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        // ============================ BUTTON EVENT ============================ //

        private void barButton_Lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(Program.MGroup == Program.NhomQuyen[2]))
            {
                ShowMdiChildren(typeof(frmLop));
            }
        }
        private void barButton_MonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(Program.MGroup == Program.NhomQuyen[2]))
            {
                ShowMdiChildren(typeof(frmMonHoc));
            }
        }
        private void barButton_SinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmSinhVien));
        }
        private void barButton_Diem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDiem));
        }


        // TODO : Close Event
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dangxuat)
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            




            }
        }

        private void barButton_Register_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDangKy));
        }

        private void barButton_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangxuat = true;
            Program.frmMain.Close();
            Program.FrmDangNhap.Visible = true;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
