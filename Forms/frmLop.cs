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

            //string URL_Connect = "Data Source=DESKTOP-ASUS\\SERVER1;Initial Catalog=QLDSV;User ID=HTKN;Password=123456";//Just for test
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.DS.EnforceConstraints = false;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            // đoạn code liên kết giữa bds với combo box
           // Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            cmbKhoa.DataSource = Program.Bds_Dspm.DataSource;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;

            //Program.Bds_Dspm.RemoveFilter();
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

                this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                this.DS.EnforceConstraints = false;
                this.LOPTableAdapter.Fill(this.DS.LOP);
            }
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}