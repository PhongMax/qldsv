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

namespace QLDSV.Forms
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        // dùng cho chức năng undo...
        private int _vitri;

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

            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
        }

        // TODO : Load Method
        private void frmLop_Load(object sender, EventArgs e)
        {

            // TODO : Load Data
            loadInitializeData();

            //this.grbLop.Enabled = true;
            // đoạn code liên kết giữa bds với combo box
            // lọc phân mảnh trước
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);

            // TODO : Role Action
            if (Program.MGroup == Program.NhomQuyen[0])
            {
                cmbKhoa.Visible = true;

            }
            else if (Program.MGroup == Program.NhomQuyen[1])
            {
                cmbKhoa.Visible = false;
                lblTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();
                barBtnThem.Enabled = barBtnSua.Enabled = barBtnXoa.Enabled
                    = barBtnUndo.Enabled = false;
            }

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;
            // bật groupbox nhập lớp
            pnControlLeft.Enabled = false;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            // chuyển chi nhánh .....
            Utils.ComboboxHelper(this.cmbKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0) {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else {
                loadInitializeData();
            }
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _vitri = bdsLOP.Position;

            // bật groupbox nhập lớp
            pnControlLeft.Enabled = true;

            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnXoa.Enabled=barBtnThem.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLammoi.Enabled = false;

            lOPGridControl.Enabled = false;
            // thao tác chuẩn bị thêm
            this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
            Console.WriteLine("Inside Khoa : " + this.txtMaKhoa.Text.ToString());
            bdsLOP.AddNew();

        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOPGridControl.Enabled = true;
            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnLammoi.Enabled
                = barBtnSua.Enabled = false;

            barBtnHuy.Enabled = barBtnGhi.Enabled = true;
            lOPGridControl.Enabled = false;
            pnControlLeft.Enabled = true;

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
                        barBtnXoa.Enabled
                          = barBtnSua.Enabled
                          = barBtnUndo.Enabled = barBtnThem.Enabled
                          = barBtnLammoi.Enabled = true;

                        cmbKhoa.Enabled = true;

                        lOPGridControl.Enabled = true;
                        // bật groupbox nhập lớp
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
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            barBtnThem.Enabled = barBtnXoa.Enabled = barBtnSua.Enabled = barBtnLammoi.Enabled
                = barBtnUndo.Enabled = true;
            lOPGridControl.Enabled = true;

            cmbKhoa.Enabled = true;
            // load lại cả form...
            frmLop_Load(sender, e);
        }

        private void barBtnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                
               frmLop_Load(sender, e);
                MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pnControlLeft.Enabled)
            {
                DialogResult dr = MessageBox.Show(" Dữ liệu Lớp chưa lưu vào Database. \n Bạn có chắc muốn thoát !", "Thông báo", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }else
            {
                this.Close();
                return;
            }
        }

        private bool ValidateInfoLOP()
        {
            bool isValid = true;

            // xóa hết thông báo ở errorProvider
            errorProvider.Clear();


            // check khoảng trống ở textedit
            if (txtMaLop.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtMaLop, "Mã lớp không được để trống !");
                isValid = false;
            }
            if (txtTenLop.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTenLop, "Tên lớp không được để trống !");
                isValid = false;
            }


            // check mã có tồn tại ở database hay ko ?
            string strLenh = " DECLARE  @return_value int " +
                            " EXEC    @return_value = [dbo].[SP_CHECKID] " +
                            " @Code = N'" + txtMaLop.Text + "'," +
                            " @Type = N'MALOP' " +
                            " SELECT  'Return Value' = @return_value ";

            int resultMa = Utils.CheckDataHelper(strLenh);

            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);

                this.Close();
            }
            if (resultMa == 1)
            {
                this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa hiên tại !");
                isValid = false;
            }
            if (resultMa == 2)
            {
                this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa khác !");
                isValid = false;
            }

            // check tên có tồn tại ở database hay ko ?

            string strLenh1 = " DECLARE @return_value int " +

                                " EXEC    @return_value = [dbo].[SP_CHECKNAME] " +

                                " @Name = N'" + txtTenLop.Text + "', " +
                                
                                " @Type = N'TENLOP' " +

                                " SELECT  'Return Value' = @return_value ";
            int resultTen = Utils.CheckDataHelper(strLenh1);
            if (resultTen == -1)
            {
                MessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultTen == 1)
            {
                this.errorProvider.SetError(txtTenLop, "Tên lớp đã có rồi !");
                isValid = false;
            }
            if (resultTen == 2)
            {
                this.errorProvider.SetError(txtTenLop, "Tên lớp đã tồn tại ở Khoa khác !");
                isValid = false;
            }
             
            return isValid;
        }

        private void gridView1_MasterRowGetRelationDisplayCaption(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
             e.RelationName = "DANH SÁCH SINH VIÊN ";

        }

        private void txtMaLop_EditValueChanged(object sender, EventArgs e)
        {
            // thường thành hoa
            txtMaLop.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        private void frmLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close(); 
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


            barBtnLammoi.Enabled = true;
        }
    }
}