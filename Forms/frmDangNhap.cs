using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=DESKTOP-ASUS;Initial Catalog=" + Program.Database + ";Integrated Security=True";

            Program.Conn.ConnectionString = chuoiketnoi;


            DataTable dt = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSPM");

            // cất dt vào biến toàn cục Bds_Dspm
            Program.Bds_Dspm.DataSource = dt;

            // đoạn code liên kết giữa bds với combo box
            cmbKhoa.DataSource = dt;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // gán server đã chọn vào biến toàn cục.
                Program.ServerName = cmbKhoa.SelectedValue.ToString();
 
            }
            catch (Exception) { };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);

               // trỏ con trỏ chuột về ô user...
               txtLogin.Focus();
                return;
            }

            Program.MLogin = txtLogin.Text;
            Program.Password = txtPass.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }

           
            Program.MKhoa = cmbKhoa.SelectedIndex;

            Program.MLoginDN = Program.MLogin;
            Program.PasswordDN = Program.Password;

          
            String strLenh = "exec SP_DANGNHAP '" + Program.MLogin + "'";
            Program.MyReader = Program.ExecSqlDataReader(strLenh);
            if (Program.MyReader == null)
            {
                return;
            }
  
            Program.MyReader.Read();


            Program.UserName = Program.MyReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.UserName))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.MHoten = Program.MyReader.GetString(1);
            Program.MGroup = Program.MyReader.GetString(2);

            Program.MyReader.Close();
            Program.Conn.Close();
            MessageBox.Show("UserName : "+ Program.UserName + "   Họ tên :" + Program.MHoten + " Group: " + Program.MGroup, "", MessageBoxButtons.OK);

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }
    }
}
