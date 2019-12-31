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
using DevExpress.XtraGrid.Views.Grid;

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
            btnThem.Enabled = btnLamMoi.Enabled = false;
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

     
        private bool KiemTraMaTrung(string maSV, string nienKhoa, string hocKy)
        {
            string query1 = " DECLARE @return_value int "  + 

                            " EXEC    @return_value = [dbo].[SP_CHECKIDHOCPHI] " + 

                            " @masv = N'" + maSV +    "', " +
		                    
                            " @nienkhoa = N'" + nienKhoa  + "', " + 
		                
                            " @hoky =" + hocKy  + 

                            " SELECT  'Return Value' = @return_value ";
            int resultMa = Utils.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultMa == 1)
            {
                // trùng
                return true;
            }

            // ko trùng
            return false;
        }

        // chỗ này cần kiểm tra sinh viên có nghĩ học nữa...
        private bool CanSave()
        {
            

            if (KiemTraMaTrung(cmbSinhVien.Text, txtNienKhoa.Text, spiHocKy.EditValue.ToString()) == true)
            {
                String notifi = "Sinh viên này đã đóng học phí trong học kỳ. Bạn có muốn chỉnh sửa !";

                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


              
                // remove current
                bdsSinhVien.RemoveCurrent();
                bdsSinhVien.Position = bdsHocPhi.Find("MASV", cmbSinhVien.Text.Trim());

                if (dr == DialogResult.No)
                {
                    return false;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.colHOCPHI.OptionsColumn.ReadOnly = true;
                    this.colSOTIENDADONG.OptionsColumn.ReadOnly = true;

                  
                    return true;

                }
               
            }

            return true;
        }


        private bool Save()
        {
            bool isSuccess = true;
            // _position = bdsSinhVien.Position;
            try
            {
                // trường hợp thêm mới ...
                //if (this.colSOTIENDADONG.ReadOnly == true)
                //{
                //    ((DataRowView)bdsHocPhi.Current)["MASV"] = (String)cmbSinhVien.EditValue;
                //    bdsHocPhi.EndEdit();
                //}
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
            try
            {

                // check sinh viên đã nghĩ học
                if (((DataRowView)bdsSinhVien[_position])["NGHIHOC"].ToString() == "True")
                {
                    XtraMessageBox.Show("Sinh Viên này đã nghĩ học !", "", MessageBoxButtons.OK);
                    return;
                }

            }
            catch(Exception)
            {

            }

            // nghiệp vụ
            this.colHOCPHI.OptionsColumn.ReadOnly = false;
            this.colSOTIENDADONG.OptionsColumn.ReadOnly = false;

            _position = bdsSinhVien.Position;
            bdsHocPhi.AddNew();
            EnableEditMode();
            txtNienKhoa.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // check giá trị trước khi add
            float soTienDong = float.Parse(this.spiSoTienDong.Value.ToString());
            float soHocPhi = float.Parse(this.spiHocPhi.Value.ToString());
            
            if (soTienDong > soHocPhi)
            {
                XtraMessageBox.Show("Số tiền đóng không được lớn hơn học phí !", "", MessageBoxButtons.OK);
                bdsHocPhi.RemoveCurrent();
                return;
            }
            if (CanSave())
            {
                if  (Save())
                {
                    XtraMessageBox.Show("Ghi thông tin đóng học phí thành công !", "", MessageBoxButtons.OK);
                }
                else
                {
                    XtraMessageBox.Show("Lỗi  !", "", MessageBoxButtons.OK);
                }
            }
           

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadInitializeData();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // trường hợp đang thêm dữ liệu
            if (btnGhi.Enabled)
            {
                String notifi = " Dữ liệu Học phí chưa lưu vào Database.  Bạn có chắc muốn thoát !";

                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();

                }
            }
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

        private void gvTTHocPhi_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }
    }

   
    
}