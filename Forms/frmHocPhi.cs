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
using QLDSV.Utility;
using DevExpress.XtraGrid.Views.Base;

namespace QLDSV.Forms
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private int dongHienTai;
        public frmHocPhi()
        {
            InitializeComponent();
        }


        private void EnableEditMode()
        {
            btnThem.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;

            btnGhi.Enabled = gbTTHocPhi.Enabled = true;

            lkeSinhVien.ReadOnly = true;
        }

        private void DisableEditMode()
        {
            btnThem.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;

            btnGhi.Enabled = gbTTHocPhi.Enabled = false;

            lkeSinhVien.ReadOnly = false;
        }

        private void loadInitializeData()
        {
            // kết nối trước rồi mới fill.
            this.DS.EnforceConstraints = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            // TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
            this.THONGTINHOCPHICUASINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.THONGTINHOCPHICUASINHVIENTableAdapter.Fill(this.DS.THONGTINHOCPHICUASINHVIEN, lkeSinhVien.Text);
         
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
                        MyHelper.ShowError(ex);
                    }
                }
            }
            return exist;
        }


        private bool CanSave()
        {
            bool isSave = true;

            if (KiemTraMaTrung(lkeSinhVien.Text, txtNienKhoa.Text, spiHocKy.EditValue.ToString()) == true)
            {
                MyHelper.ShowErrorMsgBox("Sinh viên đã đóng học phí kỳ này.", MessageBoxButtons.OK);
                txtNienKhoa.SelectAll();
                isSave = false;
            }

            return isSave;
        }


        private bool Save()
        {
            bool isSuccess = true;
            dongHienTai = bdsTHONGTINHOCPHICUASINHVIEN.Position;
            try
            {
                ((DataRowView)bdsTHONGTINHOCPHICUASINHVIEN.Current)["MASV"] = lkeSinhVien.Text;
                bdsTHONGTINHOCPHICUASINHVIEN.EndEdit();

                this.THONGTINHOCPHICUASINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.THONGTINHOCPHICUASINHVIENTableAdapter.Update(lkeSinhVien.Text);

                bdsTHONGTINHOCPHICUASINHVIEN.ResetCurrentItem();
                DisableEditMode();
                bdsTHONGTINHOCPHICUASINHVIEN.Position = dongHienTai;
            }
            catch (Exception ex)
            {
                MyHelper.ShowError(ex);
                isSuccess = false;
            }
            return isSuccess;
        }

        private void lkeSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSV = lkeSinhVien.GetSelectedDataRow() as DataRowView;

            txtTenSV.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtMaLop.Text = selectedSV.Row["MALOP"].ToString();

            this.THONGTINHOCPHICUASINHVIENTableAdapter.Fill(this.DS.THONGTINHOCPHICUASINHVIEN, lkeSinhVien.Text);
        }

        private void gvTTHocPhi_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if ((e.Column.FieldName == "HOCPHI" || e.Column.FieldName == "SOTIENDADONG") && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (!(e.Value is DBNull))
                {
                    decimal price = Convert.ToDecimal(e.Value);
                    e.DisplayText = string.Format(MyHelper.CiVNI, "{0:c0}", price);
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongHienTai = bdsTHONGTINHOCPHICUASINHVIEN.Position;
            bdsTHONGTINHOCPHICUASINHVIEN.AddNew();
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
          

            loadInitializeData();
            DisableEditMode();
        }

   
        private void spiHocPhi_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (!(e.Value is DBNull))
            {
                decimal price = Convert.ToDecimal(e.Value);
                e.DisplayText = string.Format(MyHelper.CiVNI, "{0:c0}", price);
            }
        }

        private void gcTTHocPhi_Click(object sender, EventArgs e)
        {

        }
    }

   
    
}