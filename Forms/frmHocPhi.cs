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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using DevExpress.Utils;

namespace QLDSV.Forms
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private int _position ;
        public frmHocPhi()
        {
            InitializeComponent();
        }


        private void EnableEditMode()
        {
            btnThem.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = gbTTHocPhi.Enabled = true;
            cmbSinhVien.ReadOnly = true;
        }

        private void DisableEditMode()
        {
            btnThem.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = gbTTHocPhi.Enabled = false;
            cmbSinhVien.ReadOnly = false;
        }

        private void loadInitializeData()
        {
            // kết nối trước rồi mới fill.
           
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.HOCPHITableAdapter.Fill(this.DS.HOCPHI);

        }

        /// <summary>
        /// Dùng sp kiểm tra trong database sinh viên đã đóng học phí cho học kỳ chưa
        /// </summary>
        /// <param name="maSV">Mã sinh viên</param>
        /// <param name="nienKhoa">Niên khóa</param>
        /// <param name="hocKy">Học kỳ</param>
        /// <returns>true nếu sv đã đóng học phí</returns>
        private bool KiemTraMaTrung(string maSV, string nienKhoa, string hocKy)
        {
            bool exist = true;

            using (var connection = new SqlConnection(Program.URL_Connect))
            {
                connection.Open();
                using (var sqlcmd = new SqlCommand("sp_TIMMONHOCBYID", connection))
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@masv", maSV);
                    sqlcmd.Parameters.AddWithValue("@nienkhoa", nienKhoa);
                    sqlcmd.Parameters.AddWithValue("@hocky", hocKy);
                    try
                    {
                        sqlcmd.ExecuteNonQuery();
                    }
                    // lỗi từ sqlserver => mã tồn tại
                    catch (SqlException)
                    {
                        exist = false;
                    }
                    // lỗi không biết
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString());
                    }
                }
            }
            return exist;
        }

        // chỗ này cần kiểm tra sinh viên có nghĩ học nữa...
        private bool CanSave()
        {
            bool isSave = true;

            if (KiemTraMaTrung(cmbSinhVien.Text, txtNienKhoa.Text, spiHocKy.EditValue.ToString()) == true)
            {
                XtraMessageBox.Show("Sinh viên đã đóng học phí kỳ này.","", MessageBoxButtons.OK);
                txtNienKhoa.SelectAll();
                isSave = false;
            }

            return isSave;
        }


        private bool Save()
        {
            bool isSuccess = true;
            // _position = bdsSinhVien.Position;
            try
            {
                ((DataRowView)bdsHocPhi.Current)["MASV"] = (String)cmbSinhVien.EditValue;
                bdsHocPhi.EndEdit();

                this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.HOCPHITableAdapter.Update(this.DS.HOCPHI);

                this.bdsHocPhi.ResetCurrentItem();
                DisableEditMode();

                //this.bdsHocPhi.Position = _position;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                isSuccess = false;
            }
            return isSuccess;
        }

        private void lkeSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSV = cmbSinhVien.GetSelectedDataRow() as DataRowView;

            txtTenSV.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtMaLop.Text = selectedSV.Row["MALOP"].ToString();
            _position = this.bdsSinhVien.Find("MASV", selectedSV.Row["MASV"].ToString());
    

            loadInitializeData();
            this.bdsSinhVien.Position = _position;

        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _position = bdsSinhVien.Position;
            bdsHocPhi.AddNew();
            EnableEditMode();
            txtNienKhoa.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CanSave())
            {
                Save();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadInitializeData();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

       

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            DisableEditMode();
        }

   
        private void spiHocPhi_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (!(e.Value is DBNull))
            {
                decimal price = Convert.ToDecimal(e.Value);
                CultureInfo CiVNI = new CultureInfo("vi-VN", false);
                 e.DisplayText = string.Format(CiVNI, "{0:c0}", price);
            }
        }

        private void gvTTHocPhi_CustomColumnDisplayText_1(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if ((e.Column.FieldName == "HOCPHI" || e.Column.FieldName == "SOTIENDADONG") && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (!(e.Value is DBNull))
                {
                    decimal price = Convert.ToDecimal(e.Value);
                    CultureInfo CiVNI = new CultureInfo("vi-VN", false);
                    e.DisplayText = string.Format(CiVNI, "{0:c0}", price);
                }
            }
        }

        private void gvTTHocPhi_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Handled = true;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0xC6, 0x64, 0xFF));
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height));
            Size size = ImageCollection.GetImageListSize(e.Info.ImageCollection);
            Rectangle r = e.Bounds;
            ImageCollection.DrawImageListImage(e.Cache, e.Info.ImageCollection, e.Info.ImageIndex,
                    new Rectangle(r.X + (r.Width - size.Width) / 2, r.Y + (r.Height - size.Height) / 2, size.Width, size.Height));
            brush.Dispose();
        }
    }

   
    
}