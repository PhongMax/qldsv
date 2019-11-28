using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

// sử dụng kiểu kết nối với Database là sqlclient
using System.Data.SqlClient;
using System.Data;

namespace QLDSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        // dùng để thực thi lệnh
        public static SqlCommand Sqlcmd = new SqlCommand();

        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection Conn = new SqlConnection();

        // chuỗi kết nối connection string để kết nối với csdl , nó bước đầu tiên để thực hiện kết nối      
        public static String URL_Connect;

        public static SqlDataReader MyReader;

        // những dòng này dùng trong phần tạo connection string ở bên dưới
        public static String ServerName = string.Empty;
        public static String UserName = string.Empty;

        public static String MLogin = string.Empty;
        public static String MPassword = string.Empty;

        // vì tât cả các Database phân tán cùng tên nên để QLDSV cứng luôn, ở dưới RemoteLogin cũng v, Password cũng vậy
        public static String Database = "QLDSV";

        // RemoteLogin này là remote dùng để hỗ trợ kết nối ra ngoài ví dụ trong quá trình đăng nhập nó sẽ rẽ qua server 2
        // để đăng nhập truy vấn dữ liệu thì nó dùng login này để kết nối(hay là tạo link server)
        // vì nó giống nhau trên các phân mảnh là HTKN nối nó sẽ gán cứng vào.
        public static String RemoteLogin = "HTKN";
        public static String RemotePassword = "123456";

        //MLoginDN là mã login đăng nhập và mật khẩu của nó
        public static String MLoginDN = string.Empty;
        public static String PasswordDN = string.Empty;

        // MGroup là mã group
        public static String MGroup = string.Empty;

        // MHoten là mã họ tên. 
        public static String MHoten = string.Empty;

        //MKhoa cho biết hiện tại khoa ta đăng nhập vô là khoa nào.
        //https://youtu.be/z8pgdIbtV3E?t=2595
        public static int MKhoa = 0;

        //biến dùng để chứa danh sách các phân mãnh, mà mình sẽ gọi cái viewDSPM bằng code
        // dùng để khi đi qua form nhân viên muốn hiện 2 chi nhánh lại thì chỉ cần chạy lấy lại dữ liệu và chỉ cần chạy 1 lần 
        public static BindingSource Bds_Dspm = new BindingSource(); //giu DSPM khi dang nhap
        public static frmMain fr_Main;

        public static int KetNoi()
        {
            if (Program.Conn != null && Program.Conn.State == ConnectionState.Open)
                // đóng đối tượng kết nối
                Program.Conn.Close();
            try
            {
                Program.URL_Connect = "Data Source=" + Program.ServerName + ";Initial Catalog=" +
                      Program.Database + ";User ID=" +
                      Program.MLogin + ";Password=" + Program.MPassword;
                Program.Conn.ConnectionString = Program.URL_Connect;

                // mở đối tượng kết nối
                Program.Conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại Username và Password.\n " + e.Message, string.Empty, MessageBoxButtons.OK);
                return 0;
            }
        }


        // ExecSqlDataReader tôc độ tài về nhanh hơn ExecSqlDataTable vì đối tượng nó chỉ quam tân chỉ select
        // chỉ duyệt 1 chiều từ trên xuống
        // vì vậy báo cáo thì dùng datareader
        // https://youtu.be/z8pgdIbtV3E?t=3233
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            //SqlDataReader myReader;// replace by Myreader static of program
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.Conn);

            //xác định kiểu lệnh cho sqlcmd là kiểu text.
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            try
            {
                MyReader = sqlcmd.ExecuteReader(); return MyReader;
            }
            catch (SqlException ex)
            {
                Program.Conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // tải về cho phép xem xóa sửa ==> tốc độ tải chậm hơn cái ở trên
        // duyệt 2 chiều dưới lên
        // form nhập liệu thì dùng datatable. 
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Conn);
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            Application.Run(new frmDangNhap());
            Application.Run(new frmMain());

        }
    }
}
