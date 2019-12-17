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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        // Declare Variable
        private int _vitri = 0;
        private String _makhoa = "";

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

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.DS.EnforceConstraints = false;

            // kết nối trước rồi mới fill.
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;

            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            

            this.grbLop.Enabled = false;
            // đoạn code liên kết giữa bds với combobox
            // lọc phân mảnh trước
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";

            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);
           
        }

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

                // kết nối trước rồi mới fill.
                this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;

                this.LOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

                this._makhoa = ((DataRowView)bdsLOP[0])["MAKH"].ToString();
                Console.WriteLine("Ma Khoa La : ", _makhoa);
            }
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _vitri = bdsLOP.Position;

            grbLop.Enabled = true;
            txtMaKhoa.Text = ((DataRowView)bdsLOP[0])["MAKH"].ToString();


            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnGhi.Enabled
                = barBtnHuy.Enabled
                = barBtnLammoi.Enabled = false;
            //bdsLOP.AddNew();
            
        }
    }
}