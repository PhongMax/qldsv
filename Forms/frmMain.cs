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



        private void barButton_Lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmLop));
        }

        private void barButton_MonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmMonHoc));
        }

        private void barButton_GiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmGiangVien));
        }

        private void barButton_SinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmSinhVien));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDiem));
        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangxuat = true;
            Program.frmMain.Close();
            Program.FrmDangNhap.Visible = true;
           
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dangxuat)
            {
                if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Program.FrmDangNhap.Visible = true;
                    Program.FrmDangNhap.Close();
                }
                else e.Cancel = true;
            }
        }


    }
}
