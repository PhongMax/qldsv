using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    class Utils
    {
        // biding data từ datable vào combobox chi nhánh
        public static void BindingDataToComBo(ComboBox cmbKhoa, Object data)
        {
            cmbKhoa.DataSource = data;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combobox chạy đúng.
            cmbKhoa.SelectedIndex = 1;

            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            // chỗ này chưa xong, bị lỗi nếu như login vào với server học phí...
            cmbKhoa.SelectedIndex = Program.MKhoa;
        }

        public static string GetMaKhoa()
        {
            DataTable dt = new DataTable();
            BindingSource bds = new BindingSource();

            dt = Program.ExecSqlDataTable("SELECT MAKH FROM KHOA");
            bds.DataSource = dt;
            
            return ((DataRowView)bds[0])["MAKH"].ToString();
        }

        public static void authorizationAction(ComboBox cmbKhoa)
        {
            if (Program.MGroup != "PGV")
            {
                cmbKhoa.Enabled = false;
            }
        }
    }
}
