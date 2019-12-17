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
using System.Collections;
using QLDSV.Validation;

namespace QLDSV.Forms
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        private static String[] actionType = new String[8]
            {   "ADD",//0
                "DELETE",//1
                "UPDATE",//2
                "UNDO",//3
                "SAVE",//4
                "CANCEL",//5
                "REFESH",//6
                "EXIST" };//7
        private int _vitri;
        private string _makhoa = "";
        private List<String> actionButton = new List<String>();

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
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.DS.EnforceConstraints = false;

            // kết nối trước rồi mới fill.
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;

            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

        }

        private void actionButtonControl()
        {
            if (actionButton.Count == 0)
            {
                barBtnUndo.Enabled = barBtnGhi.Enabled = barBtnHuy.Enabled  = false;
                return;
            }
            else
            {
                if (actionButton.Contains("SAVE"))
                {
                    barBtnUndo.Enabled = false;// cho nay chua duoc - chua hieu tai sao

                    actionButton.Remove("ADD");
                    actionButton.Remove("DELETE");
                    actionButton.Remove("UPDATE");
                    // need delete add delete update
                    return;
                }

                else if (actionButton.Contains("ADD") || actionButton.Contains("DELETE") || actionButton.Contains("UPDATE"))
                {
                    barBtnGhi.Enabled = true;
                    barBtnUndo.Enabled = true;
                    return;
                }

            }
        }
        // TODO : LOAD EVENT
        private void frmLop_Load(object sender, EventArgs e)
        {

            // TODO : Load Data
            loadInitializeData();

            _makhoa = Utils.GetMaKhoa();
            Console.WriteLine("Ma Khoa : " + _makhoa);
            this.txtMaKhoa.EditValue = _makhoa;
            this.txtMaKhoa.Enabled = false;

            //this.grbLop.Enabled = true;
            // đoạn code liên kết giữa bds với combo box
            // lọc phân mảnh trước
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);

            // TODO : Role Action
            //if (Program.MGroup != "PGV")
            //{
            //    cmbKhoa.Enabled = false;
            //}
            Utils.authorizationAction(cmbKhoa);
            
            actionButtonControl();

        }

        // COMBOBOX EVENT
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            // gán server đã chọn vào biến toàn cục.
            Program.ServerName = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.MKhoa) {
                Program.MLogin = Program.RemoteLogin;
                Program.MPassword = Program.RemotePassword;
            }
            else {
                Program.MLogin = Program.MLoginDN;
                Program.MPassword = Program.PasswordDN;
            }

            if (Program.KetNoi() == 0) {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else {

                this.DS.EnforceConstraints = false;

                this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;

                this.LOPTableAdapter.Fill(this.DS.LOP);
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

                this.txtMaKhoa.EditValue = Utils.GetMaKhoa();
            }
        }

        // ADD EVENT
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _vitri = bdsLOP.Position;

            lOPGridControl.Enabled = false;
            grbLop.Visible = true;

            bdsLOP.AddNew();
            txtMaKhoa.EditValue = _makhoa;

            actionButton.Add(actionType[0]);
            actionButtonControl();
        }

        // DELETE EVENT
        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("DELETE Clicked");
            actionButton.Add(actionType[1]);
            actionButtonControl();
        }

        // UPDATE EVENT
        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("UPDATE Clicked");
            actionButton.Add(actionType[2]);
            actionButtonControl();

        }

        // UNDO EVENT
        private void barBtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("UNDO Clicked");
            actionButton.Add(actionType[3]);
            actionButtonControl();
        }

        // SAVE EVENT
        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("Save Clicked");
            _vitri = bdsLOP.Position;

            
            if (this.txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được trống", "Warning", MessageBoxButtons.OK);
                this.txtMaLop.Focus();
                return;
            }
            if (this.txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được trống", "Warning", MessageBoxButtons.OK);
                this.txtTenLop.Focus();
                return;
            }

            if (LopValidation.checkDuplicated_MALOP(this.txtMaLop.Text) == true)
            {
                MessageBox.Show("Mã lớp không được trùng", "Warning", MessageBoxButtons.OK);
                this.txtMaLop.Focus();
                return;
            }

            if (LopValidation.checkDuplicated_TENLOP(this.txtTenLop.Text) == true)
            {
                MessageBox.Show("Tên lớp không được trùng", "Warning", MessageBoxButtons.OK);
                this.txtTenLop.Focus();
                return;
            }

            if (LopValidation.checkDuplicatedFromExtenal(this.txtMaLop.Text, this.txtTenLop.Text, this.txtMaKhoa.Text) == 1)
            {
                MessageBox.Show("Mã lớp bị trùng ở site khác", "Warning", MessageBoxButtons.OK);
                this.txtMaLop.Focus();
            }
            if (LopValidation.checkDuplicatedFromExtenal(this.txtMaLop.Text, this.txtTenLop.Text, this.txtMaKhoa.Text) == 2)
            {
                MessageBox.Show("Tên lớp bị trùng ở site khác", "Warning", MessageBoxButtons.OK);
                this.txtTenLop.Focus();
            }


            // TODO : Check Mã lớp trùng ở site khác
            //try
            //{
            //    bdsLOP.EndEdit();// Ghi toàn bộ thông tin trên giao diện của form vào DataTable
            //    bdsLOP.ResetCurrentItem();// Đồng bộ dữ liệu từ dưới form lên lưới của DataTable
            //    this.LOPTableAdapter.Update(this.DS.LOP);// Đẩy data vừa ghi tạm về CSDL
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Lỗi ghi dữ liệu ", "Warning", MessageBoxButtons.OK);
            //}

            actionButton.Add(actionType[4]);
            actionButtonControl();
        }

        // CANCEL EVENT
        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("CANCEL Clicked");
            actionButton.Add(actionType[5]);
            actionButtonControl();

            bdsLOP.CancelEdit();
        }

        private void barBtnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("REFESH Clicked");
            actionButton.Add(actionType[6]);
            actionButtonControl();

            // TODO : Load Data
            loadInitializeData();
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        // EXIST EVENT
        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionButton.Add(actionType[7]);
            actionButtonControl();
            Close();
        }


    }
}