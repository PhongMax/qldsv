using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    class Utils
    {
        // biding data từ datable vào combobox chi nhánh
        public static void BindingDataToComBo(ComboBox combo, Object data)
        {
            combo.DataSource = data;
            combo.DisplayMember = "TENKHOA";
            combo.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            combo.SelectedIndex = 1;

            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            // chỗ này chưa xong, bị lỗi nếu như login vào với server học phí...
            combo.SelectedIndex = Program.MKhoa;
        }

        public static string GetMaKhoa()
        {
            DataTable dt = new DataTable();
            BindingSource bds = new BindingSource();

            dt = Program.ExecSqlDataTable("SELECT MAKH FROM KHOA");
            bds.DataSource = dt;
            
            return ((DataRowView)bds[0])["MAKH"].ToString();
        }

        // hỗ trợ trong combobox chọn chi nhánh, được tách ra dùng cho các form khác...
        public static void ComboboxHelper(ComboBox cmb)
        {
            // bắt lỗi khi giá trị của selectedvalue = "sysem.data.datarowview"
            if (cmb.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            // gán server đã chọn vào biến toàn cục.
            Program.ServerName = cmb.SelectedValue.ToString();


            // đoạn code hỗ trợ chuyển chi nhánh
            // ở chi nhánh A qua B thì dùng RemoteLogin,
            if (cmb.SelectedIndex != Program.MKhoa)
            {
                Program.MLogin = Program.RemoteLogin;
                Program.MPassword = Program.RemotePassword;
            }
            else
            { // ở B về lại A dùng login ban đầu
                Program.MLogin = Program.MLoginDN;
                Program.MPassword = Program.PasswordDN;
            }
        }


        public static int CheckDataHelper(String query)
        {

            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn
            if (dataReader == null)
            {
               
                return -1;
            }

            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
    }
}
