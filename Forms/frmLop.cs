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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace QLDSV.Forms
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
       
        private int _positionLop = 0;
        private string _flagOptionLop; // true = add ; false = update ; default of boolean = false
        private string _oldMaLop = "";
        private string _oldTenLop = "";
        private string _oldMaSV;

        private Boolean _flagUpdateSV = false;
        private Boolean _flagSua = false;

        // áp dụng cho sub sinh viên
        private int _positionSV = 0;

        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void loadInitializeData()
        {
            // kết nối trước rồi mới fill.
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.DIEMSVTableAdapter.Connection.ConnectionString = Program.URL_Connect;

            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            this.DIEMSVTableAdapter.Fill(this.DS.DIEM);

        }

        // TODO : Load Method
        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO : Load Data
            loadInitializeData();
            errorProvider.Clear();

            this.conGhi.Enabled = false;

            lOPGridControl.Enabled = true;

            //this.grbLop.Enabled = true;
            // đoạn code liên kết giữa bds với combo box
            // lọc phân mảnh trước
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);

            lOPGridControl.Enabled = true;
            // TODO : Role Action
            if (Program.MGroup == Program.NhomQuyen[0])// PGV
            {
                cmbKhoa.Visible = true;
                cmbKhoa.Enabled = true;

                barBtnThem.Enabled
                   = barBtnXoa.Enabled
                   = barBtnSua.Enabled
                   = barBtnUndo.Enabled
                   = barBtnGhi.Enabled
                   = barBtnHuy.Enabled
                   = barBtnLamMoi.Enabled = true;
            }
            else if (Program.MGroup == Program.NhomQuyen[1]) // KHOA
            {
                cmbKhoa.Visible = false;

                barBtnThem.Enabled
                   = barBtnXoa.Enabled
                   = barBtnSua.Enabled
                   = barBtnUndo.Enabled
                   = barBtnGhi.Enabled
                   = barBtnHuy.Enabled
                   = barBtnLamMoi.Enabled = false;

                lblTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();

                //sub
                this.contextSinhVien.Enabled = false;
            }

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;

            // TODO : Turn off input
            pnControlLeft.Enabled = false;

            // testing
            getMaSinhVien();

        }


        private void getMaSinhVien()
        {
            string result = "";
            string lenh = string.Format("SELECT HO+' '+TEN AS HOTEN FROM dbo.SINHVIEN WHERE MASV = 'N16DCCN076'");
            using (SqlConnection connection = new SqlConnection(Program.URL_Connect))
            {
                connection.Open();
                SqlCommand sqlcmt = new SqlCommand(lenh, connection);
                sqlcmt.CommandType = CommandType.Text;
                try
                {
                    result = (String)sqlcmt.ExecuteScalar();

                }
                catch { }
            }
            Console.WriteLine("Ho Ten Sinh Vien : " + result);
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadInitializeData();
                this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
            }
        }



        // ============================ EVENT BUTTON ============================ //
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
      
            _flagOptionLop = "ADD";//  Add action

            // bật groupbox nhập lớp
            pnControlLeft.Enabled = true;

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnXoa.Enabled = barBtnThem.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;


            cmbKhoa.Enabled = false;

            lOPGridControl.Enabled = false;
            // thao tác chuẩn bị thêm
            bdsLOP.AddNew();
            this.txtMaKhoa.EditValue = Utils.GetMaKhoa();

        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì Lớp đã có sinh viên.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    bdsLOP.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.LOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.DS.LOP);
                    return;

                }
            }
            if (bdsLOP.Count == 0) barBtnXoa.Enabled = false;


            barBtnLamMoi.Enabled = true;

            if (_positionLop > 0)
            {
                bdsLOP.Position = _positionLop;
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            _flagOptionLop = "UPDATE";//  Update action
            _oldMaLop = this.txtMaLop.Text.Trim().ToString();
            _oldTenLop = this.txtTenLop.Text.Trim().ToString();

            // TODO: Display To handle
            lOPGridControl.Enabled = false;
            pnControlLeft.Enabled = true;

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;

            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
            cmbKhoa.Enabled = false;

            
        }

        private void barBtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            bool check = this.ValidateInfoLOP();
            if (check)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        barBtnThem.Enabled
                        = barBtnXoa.Enabled
                        = barBtnSua.Enabled
                        = barBtnUndo.Enabled
                        = barBtnLamMoi.Enabled = true;

                        lOPGridControl.Enabled = true;
                        pnControlLeft.Enabled = false;

                        this.bdsLOP.EndEdit();
                        this.bdsLOP.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.LOPTableAdapter.Update(this.DS.LOP);
                    }
                    catch (Exception ex)
                    {
                        bdsLOP.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
  
            }
            else
            {
                // lỗi thì return thôi.
                return;
            }

            //chỉ riêng 1 lệnh  dành cho subform
            loadInitializeData();

            cmbKhoa.Visible = true;
            cmbKhoa.Enabled = true;

            if (_positionLop > 0)
            {
                bdsLOP.Position = _positionLop;
            }
         
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();

            // load lại cả form...
            frmLop_Load(sender, e);

            if (_positionLop > 0)
            {
                bdsLOP.Position = _positionLop;
            }
        }

        private void barBtnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmLop_Load(sender, e);
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);


        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pnControlLeft.Enabled || _flagUpdateSV )
            {
                String notifi=" ";
                String notifiLop = " Dữ liệu LỚP chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                String notifiSV = "Dữ liệu SINH VIÊN chưa lưu vào Database. \n Bạn có chắc muốn thoát ! ";
                if (pnControlLeft.Enabled)
                {
                    notifi = notifiLop;
                }else if (_flagUpdateSV)
                {
                    notifi = notifiSV;
                }

            
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
            else
            {
                this.Close();
                return;
            }


        }


        // ====================== SUPPORT VALIDATION ====================== //
        private bool ValidateInfoLOP()
        {
            errorProvider.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtMaLop.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtMaLop, "Mã lớp không được để trống !");
                return false;
            }
            if (txtTenLop.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTenLop, "Tên lớp không được để trống !");
                return false;
            }

            if (_flagOptionLop == "ADD")
            {
                //TODO: Check mã lớp có tồn tại chưa
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC  @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txtMaLop.Text + "',@Type = N'MALOP' \n"
                            + "SELECT  'Return Value' = @return_value ";

                int resultMa = Utils.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa hiên tại !");
                    return false;
                }
                if (resultMa == 2)
                {
                    this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa khác !");
                    return false;
                }

                // TODO : Check tên lớp có tồn tại chưa
                string query2 = "DECLARE @return_value int \n"
                               + "EXEC @return_value = SP_CHECKNAME \n"
                               + "@Name = N'" + txtTenLop.Text + "', @Type = N'TENLOP' \n"
                               + "SELECT 'Return Value' = @return_value ";
                int resultTen = Utils.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    MessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    this.errorProvider.SetError(txtTenLop, "Tên lớp đã có rồi !");
                    return false;
                }
                if (resultTen == 2)
                {
                    this.errorProvider.SetError(txtTenLop, "Tên lớp đã tồn tại ở Khoa khác !");
                    return false;
                }
            }

            if (_flagOptionLop == "UPDATE")
            {
                if (!this.txtMaLop.Text.Trim().ToString().Equals(_oldMaLop))// Nếu mã lớp thay đổi so với ban đầu
                {
                    //TODO: Check mã lớp có tồn tại chưa
                    string query1 = "DECLARE  @return_value int \n"
                                + "EXEC  @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txtMaLop.Text + "',@Type = N'MALOP' \n"
                                + "SELECT  'Return Value' = @return_value ";

                    int resultMa = Utils.CheckDataHelper(query1);
                    if (resultMa == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa hiên tại !");
                        return false;
                    }
                    if (resultMa == 2)
                    {
                        this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa khác !");
                        return false;
                    }
                }
                if (!this.txtTenLop.Text.Trim().ToString().Equals(_oldTenLop))
                {
                    // TODO : Check tên lớp có tồn tại chưa
                    string query2 = "DECLARE @return_value int \n"
                                   + "EXEC @return_value = SP_CHECKNAME \n"
                                   + "@Name = N'" + txtTenLop.Text + "', @Type = N'TENLOP' \n"
                                   + "SELECT 'Return Value' = @return_value ";
                    int resultTen = Utils.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        this.errorProvider.SetError(txtTenLop, "Tên lớp đã có rồi !");
                        return false;
                    }
                    if (resultTen == 2)
                    {
                        this.errorProvider.SetError(txtTenLop, "Tên lớp đã tồn tại ở Khoa khác !");
                        return false;
                    }
                }
            }

            return true;

        }

        private void txtMaLop_EditValueChanged(object sender, EventArgs e)
        {
            // thường thành hoa
            txtMaLop.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsLOP.Position > 0)
            {
                _positionLop = bdsLOP.Position;
            }
        }

    

        //---------------------------- Phân subform -----------------------------------------------

        private void conThem_Click(object sender, EventArgs e)
        {
            this.conThem.Enabled =
            this.conSua.Enabled = this.conXoa.Enabled = false;
            this.conGhi.Enabled = true;

            this.lOPGridControl.Enabled = false;
            this.barBtnGhi.Enabled = this.barBtnHuy.Enabled = this.barBtnSua.Enabled = this.barBtnXoa.Enabled = 
                this.barBtnThem.Enabled = this.barBtnUndo.Enabled = this.barBtnLamMoi.Enabled = false;

            this.cmbKhoa.Enabled = false;

            _flagUpdateSV = true;
            // TODO : Thao tác chuẩn bị thêm
            bdsSV.AddNew();


        }

        private void conSua_Click(object sender, EventArgs e)
        {
            this.conSua.Enabled = this.conXoa.Enabled = this.conThem.Enabled = false;
            this.conGhi.Enabled = true;


            this.lOPGridControl.Enabled = false;
            this.barBtnGhi.Enabled = this.barBtnHuy.Enabled = this.barBtnSua.Enabled = this.barBtnXoa.Enabled =
                this.barBtnThem.Enabled = this.barBtnUndo.Enabled = this.barBtnLamMoi.Enabled = false;

            this.cmbKhoa.Enabled = false;



            _flagUpdateSV = true;
            _flagSua = true;

            
        }

        private void conXoa_Click(object sender, EventArgs e)
        {
            if (bdsDiemSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa Sinh Viên này..từ từ tính tiếp.  .", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Sinh Viên này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsSV.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                    this.bdsSV.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Sinh Viên.\nBạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                }


            }


            if (_positionSV > 0)
            {

                bdsSV.Position = _positionSV;
            }
        }

        private void conGhi_Click(object sender, EventArgs e)
        {
            bool check = true;
            int indexLastRow = bdsSV.Count - 1;
            if (!_flagSua)
            {
                check = ValidateInfoSinhVien(indexLastRow);

            }
            if (check)
            {
                try
                {
                    this.conThem.Enabled 
                    = this.conGhi.Enabled
                    = this.conXoa.Enabled
                    = this.conSua.Enabled
                    = true;

                    this.lOPGridControl.Enabled = true;

                    this.bdsSV.EndEdit();
                    this.bdsSV.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                    this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);

                    this.cmbKhoa.Enabled = true;
                    MessageBox.Show("Ghi dữ liệu thành công !","Thành Công", MessageBoxButtons.OK);


                    _flagUpdateSV = false;
                    _flagSua = false;

                    // set lại vị trí
                   bdsSV.Position = bdsSV.Count - 1;
                }
                catch (Exception ex)
                {
                    this.bdsSV.RemoveCurrent();
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                // focuse lại vị trí bị trùng để sửa
                this.gridViewSinhVien.FocusedRowHandle = indexLastRow;
                this.gridViewSinhVien.FocusedColumn = this.colMASV;

                // phân quyền nút
                this.conSua.Enabled = this.conXoa.Enabled = true;
                return;
            }

            if (_positionSV > 0)
            {
                bdsSV.Position = _positionSV;
            }
        }


        private void conLamMoi_Click(object sender, EventArgs e)
        {
            this.conThem.Enabled= this.conSua.Enabled = this.conXoa.Enabled = true;

            this.lOPGridControl.Enabled = true;

            this.barBtnGhi.Enabled = this.barBtnHuy.Enabled = this.barBtnSua.Enabled = this.barBtnXoa.Enabled =
                this.barBtnThem.Enabled = this.barBtnUndo.Enabled = this.barBtnLamMoi.Enabled = true;

            this.cmbKhoa.Enabled = true;

            _flagSua = _flagUpdateSV = false;


         
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.DIEMSVTableAdapter.Connection.ConnectionString = Program.URL_Connect;

       
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            this.DIEMSVTableAdapter.Fill(this.DS.DIEM);

            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);

            if (_positionSV > 0)
            {
                bdsSV.Position = _positionSV;
            }
        }
     

        private bool ValidateInfoSinhVien(int position)
        {
            string maSV = this.gridViewSinhVien.GetRowCellValue(position, "MASV").ToString();
           
            if (maSV == _oldMaSV)
            {
                return true;
            }
            if(string.IsNullOrEmpty(maSV))
            {
                XtraMessageBox.Show("Mã Sinh Viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
                //TODO: Check mã sinh viên có tồn tại chưa
            string query1 = " DECLARE @return_value INT " + 

                            " EXEC @return_value = [dbo].[SP_CHECKID] " + 

                            " @Code = N'" + maSV +  "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

                int resultMa = Utils.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn chon mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                }
            if (resultMa == 2)
            {
                XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void gridViewSinhVien_ShowingEditor(object sender, CancelEventArgs e)
        {
            // phân quyền cho phòng giáo vụ


            if (_flagSua)
            {
                _positionSV = this.gridViewSinhVien.FocusedRowHandle;
                _oldMaSV = ((DataRowView)bdsSV[this.gridViewSinhVien.FocusedRowHandle])["MASV"].ToString();
                return;
            }


            if (!this.gridViewSinhVien.IsNewItemRow(this.gridViewSinhVien.FocusedRowHandle))
            {
                e.Cancel = true;

            }
            int indexLastRow = bdsSV.Count - 1;

            if (_positionSV > 0  &&  indexLastRow == this.gridViewSinhVien.FocusedRowHandle   && _flagUpdateSV)
            {
                    e.Cancel = false;
            }


          
        }

        private void gridViewSinhVien_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (_flagSua) {
                GridView view = sender as GridView;
                bool check = ValidateInfoSinhVien(view.FocusedRowHandle);
                if (!check)
                {
                    e.Valid = false;
                    view.SetColumnError(this.colMASV, "Mã SINH VIÊN bị trùng !");
                }
              

            }
         
        }

        private void gridViewSinhVien_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewSinhVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsSV.Position > 0)
            {
                //_positionSV = bdsSV.Count - 1;
                _positionSV = this.bdsSV.Position;
            }
        }

        private void gridViewSinhVien_InitNewRow(object sender, InitNewRowEventArgs e)
        {

            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["NGHIHOC"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["PHAI"], 1);
        }

        private void gridView1_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Danh sách sinh viên";
        }

        private void repositoryItemTextEditMaSV_EditValueChanged(object sender, EventArgs e)
        {
            // thường thành hoa
            repositoryItemTextEditMaSV.CharacterCasing = CharacterCasing.Upper;
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridViewSinhVien_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridViewSinhVien_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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