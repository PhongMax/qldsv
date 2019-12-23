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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        // TODO : Declare Variavble
        private int _vitri;


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
            loadInitializeData();

            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);
            
            // TODO : Role Action
            if(Program.MGroup == Program.NhomQuyen[0])// PGV
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
                lblTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();

                barBtnThem.Enabled
                    = barBtnXoa.Enabled
                    = barBtnSua.Enabled
                    = barBtnUndo.Enabled
                    = barBtnGhi.Enabled
                    = barBtnHuy.Enabled = false;
            }

            barBtnHuy.Enabled = barBtnGhi.Enabled = false;

            // TODO : Turn on input
            groupBoxMonHoc.Enabled = false;
        }


        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ComboboxHelper(this.cmbKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadInitializeData();
            }
        }





        // ============================ EVENT BUTTON ============================ //
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _vitri = bdsMONHOC.Position;

            
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
                MessageBox.Show("Không thể xóa môn học này vì đang chứa điểm.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                    MessageBox.Show("Lỗi xóa môn học.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                }
                frmMonHoc_Load(sender, e);
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _vitri = bdsMONHOC.Position;
            MONHOCGridControl.Enabled = true;
            groupBoxMonHoc.Enabled = true;
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
            bool check = ValidateInfoMONHOC();
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

                        groupBoxMonHoc.Enabled = false;
                        MONHOCGridControl.Enabled = true;

                        this.bdsMONHOC.EndEdit();
                        this.bdsMONHOC.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.MONHOCTableAdapter.Update(this.DS.MONHOC);

                    } catch (Exception ex)
                    {
                        bdsMONHOC.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                frmMonHoc_Load(sender, e);
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
        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc_Load(sender, e);
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

            //TODO: Check mã môn học có tồn tại chưa
            string query1 = "DECLARE  @return_value int \n"
                        + "EXEC @return_value = SP_CHECKID \n"
                        + "@Code = N'" + txtMaMonHoc.Text + "',@Type = N'MAMONHOC' \n"
                        + "SELECT 'Return Value' = @return_value";

            int resultMa = Utils.CheckDataHelper(query1);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại","", MessageBoxButtons.OK);
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
                MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultTen == 1)
            {
                this.errorProvider.SetError(txtTenMonHoc, "Tên môn học đã tồn tại!");
                return false;
            }
            return true;
        }



    }
}