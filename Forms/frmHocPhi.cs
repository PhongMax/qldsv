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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace QLDSV.Forms
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private int _position ;
        private Boolean _flagEdit = false;
        public frmHocPhi()
        {
            InitializeComponent();
        }


        private void EnableEditMode()
        {
            btnThem.Enabled =  false;
            btnGhi.Enabled = gbTTHocPhi.Enabled = true;
            cmbSinhVien.ReadOnly = true;
        }

        private void DisableEditMode()
        {
            btnThoat.Enabled = true;
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

        private bool CanSave()
        {
            // trường hợp đặc biệt nếu như sửa học phí thì sẽ cho save --> true
            if (_flagEdit)
                return true;


            if (KiemTraMaTrung(cmbSinhVien.Text, txtNienKhoa.Text, spiHocKy.EditValue.ToString()) == true  )
            {
                String notifi = "Sinh viên này đã đóng học phí trong học kỳ. Bạn có muốn chỉnh sửa !";

                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);



                // cancel edit dòng hiện tại.
              
                if (this.gvTTHocPhi.IsNewItemRow(this.gvTTHocPhi.FocusedRowHandle))
                {
                    bdsHocPhi.CancelEdit();
       
                }
               
                if (dr == DialogResult.No)
                {
                    DisableEditMode();
                    return false;
                }
                else if (dr == DialogResult.Yes)
                {
                    _flagEdit = true;

                    XtraMessageBox.Show("Bạn hãy chỉnh sửa ở lưới này ", "", MessageBoxButtons.OK);

                    return false;

                }
               
            }

            return true;
        }


        private bool Save()
        {
            bool isSuccess = true;
          
            try
            {
               


                // phục vụ cho việc ghi mới dữ liệu nếu _flagEdit = false
                if(!_flagEdit)
                {
                    ((DataRowView)bdsHocPhi.Current)["MASV"] = (String)cmbSinhVien.EditValue;
                   
                }

                // cập nhật dữ liệu.
                bdsHocPhi.EndEdit();
                this.bdsHocPhi.ResetCurrentItem();
                this.HOCPHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.HOCPHITableAdapter.Update(this.DS.HOCPHI);

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
            this.btnThem.Enabled = true;
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

            try
            {
                if (CanSave())
                {
                    if (Save())
                    {
                        XtraMessageBox.Show("Ghi thông tin đóng học phí thành công !", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Lỗi  !", "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    return;
                }


            }
            catch (Exception)
            {

            }

            //nghiệp vụ
            _flagEdit = false;

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
            btnThem.Enabled = false;
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

        private void gvTTHocPhi_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (_flagEdit)
            {
                this.colHOCPHI.OptionsColumn.AllowEdit = true;
                this.colHOCPHI.OptionsColumn.ReadOnly = false;
                this.colSOTIENDADONG.OptionsColumn.AllowEdit = true;
                this.colSOTIENDADONG.OptionsColumn.ReadOnly = false;
            }
            else
            {
                this.colHOCPHI.OptionsColumn.AllowEdit = false;
                this.colSOTIENDADONG.OptionsColumn.AllowEdit = false;
            }

        }

        private void gvTTHocPhi_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn colHocPhi = view.Columns["HOCPHI"];
            GridColumn colTienDaDong = view.Columns["SOTIENDADONG"];

            double soHocPhi = double.Parse(view.GetRowCellValue(e.RowHandle, colHocPhi).ToString());
            double soDaDong = double.Parse(view.GetRowCellValue(e.RowHandle, colTienDaDong).ToString());

            //Validity criterion 
            if (soHocPhi < soDaDong)
            {
                e.Valid = false;
                view.SetColumnError(colHocPhi, "Số tiền học phí phải lớn hơn hoặc bằng số tiền đã đóng");
                view.SetColumnError(colTienDaDong, "Số tiền đã đóng phải nhỏ hơn hoặc bằng số tiền học phí");
            }
        }

        private void gvTTHocPhi_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {

            e.ExceptionMode = ExceptionMode.NoAction;
        }

    }

   
    
}