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
using DevExpress.Utils;

namespace QLDSV.Forms
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        // TODO : Declare Variavble
        private int _position = 0;
        private string flagOption; // true = add ; false = update ; default of boolean = false
        private string oldMaMonHoc = "";
        private string oldTenMonHoc = "";

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void MONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void loadInitializeData()
        {
            // kết nối trước rồi mới fill.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
            this.DIEMTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.DIEMTableAdapter.Fill(this.DS.DIEM);
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO : Load Data
            errorProvider.Clear();
            loadInitializeData();

            MONHOCGridControl.Enabled = true;
            // TODO : Role Action
            if(Program.MGroup == Program.NhomQuyen[0])// PGV
            {
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
                barBtnThem.Enabled
                    = barBtnXoa.Enabled
                    = barBtnSua.Enabled
                    = barBtnUndo.Enabled
                    = barBtnGhi.Enabled
                    = barBtnHuy.Enabled = false;
            }

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;

            // TODO : Turn off input
            groupBoxMonHoc.Enabled = false;
           
        }
        // ============================ EVENT BUTTON ============================ //
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagOption = "ADD";//  Add action

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;

            groupBoxMonHoc.Enabled = true;
            MONHOCGridControl.Enabled = false;

            // TODO : Thao tác chuẩn bị thêm
            bdsMONHOC.AddNew();

        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDiem.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa môn học này vì đang chứa điểm.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsMONHOC.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                    this.bdsMONHOC.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa môn học.\nBạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                }
       

            }


            if (_position > 0)
            {
       
                bdsMONHOC.Position = _position;
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagOption = "UPDATE";//  Update action
            oldMaMonHoc = this.txtMaMonHoc.Text.Trim().ToString();
            oldTenMonHoc = this.txtTenMonHoc.Text.Trim().ToString();

            // TODO: Display To handle
            MONHOCGridControl.Enabled = false;
            groupBoxMonHoc.Enabled = true;

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;

            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
        }

        private void barBtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            bool check = ValidateInfoMONHOC();
            if (check)
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
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

                        MONHOCGridControl.Enabled = true;
                        groupBoxMonHoc.Enabled = false;

                        this.bdsMONHOC.EndEdit();
                        this.bdsMONHOC.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.MONHOCTableAdapter.Update(this.DS.MONHOC);

                    } catch (Exception ex)
                    {
                        bdsMONHOC.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                return;
            }
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();

            frmMonHoc_Load(sender, e);
            if (_position > 0)
            {
                bdsMONHOC.Position = _position;
            }
        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            frmMonHoc_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (this.groupBoxMonHoc.Enabled)
            {
                String notifi = " Dữ liệu Môn Học chưa lưu vào Database. \n Bạn có chắc muốn thoát !";

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
        private bool ValidateInfoMONHOC()
        {
            errorProvider.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtMaMonHoc.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtMaMonHoc, "Mã môn học không được để trống!");
                return false;
            }
            if (txtTenMonHoc.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTenMonHoc, "Tên môn học không được để trống");
                return false;
            }

            
            if (flagOption == "ADD")
            {
                //TODO: Check mã môn học có tồn tại chưa
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txtMaMonHoc.Text + "',@Type = N'MAMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultMa = Utils.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    this.errorProvider.SetError(txtMaMonHoc, "Mã môn học đã tồn tại!");
                    return false;
                }

                // TODO : Check tên môn học có tồn tại chưa
                string query2 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKNAME \n"
                            + "@Name = N'" + txtTenMonHoc.Text + "',@Type = N'TENMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultTen = Utils.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                  XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    this.errorProvider.SetError(txtTenMonHoc, "Tên môn học đã tồn tại!");
                    return false;
                }
            }

            if (flagOption == "UPDATE")
            {
                if ( !this.txtMaMonHoc.Text.Trim().ToString().Equals(oldMaMonHoc))// Nếu mã môn học thay đổi so với ban đầu
                {
                    //TODO: Check mã môn học có tồn tại chưa
                    string query1 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txtMaMonHoc.Text + "',@Type = N'MAMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultMa = Utils.CheckDataHelper(query1);
                    if (resultMa == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        this.errorProvider.SetError(txtMaMonHoc, "Mã môn học đã tồn tại!");
                        return false;
                    }
                }
                if ( !this.txtTenMonHoc.Text.Trim().ToString().Equals(oldTenMonHoc))// Nếu tên môn học thay đổi so với ban đầu
                {
                    // TODO : Check tên môn học có tồn tại chưa
                    string query2 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKNAME \n"
                                + "@Name = N'" + txtTenMonHoc.Text + "',@Type = N'TENMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultTen = Utils.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        this.errorProvider.SetError(txtTenMonHoc, "Tên môn học đã tồn tại!");
                        return false;
                    }
                }
            }
            
            return true;
        }

        private void txtMaMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            txtMaMonHoc.Properties.CharacterCasing = CharacterCasing.Upper;
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsMONHOC.Position > 0)
            {
                _position = bdsMONHOC.Position;
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
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



    }
}