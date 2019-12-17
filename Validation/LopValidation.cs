using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Validation
{
    class LopValidation
    {

        public static Boolean checkDuplicated_MALOP(string MALOP)
        {
            Boolean isDuplicate_MALOP = false;
            DataTable dt = new DataTable();
            BindingSource bds = new BindingSource();

            dt = Program.ExecSqlDataTable("SELECT MALOP FROM LOP");
            bds.DataSource = dt;

            for (int i = 0; i < bds.Count; i++)
            {
                if (MALOP.ToString().Trim().Equals(((DataRowView)bds[i])["MALOP"].ToString().Trim()))
                {
                    isDuplicate_MALOP = true;
                    break;
                }
            }
            return isDuplicate_MALOP;
        }

        public static Boolean checkDuplicated_TENLOP(string TENLOP)
        {
            Boolean isDuplicate_TENLOP = false;
            DataTable dt = new DataTable();
            BindingSource bds = new BindingSource();

            dt = Program.ExecSqlDataTable("SELECT TENLOP FROM LOP");
            bds.DataSource = dt;

            for (int i = 0; i < bds.Count; i++)
            {
                if (TENLOP.ToString().Trim().Equals(((DataRowView)bds[i])["TENLOP"].ToString().Trim()))
                {
                    isDuplicate_TENLOP = true;
                    break;
                }
            }
            return isDuplicate_TENLOP;
        }


        public static int checkDuplicatedFromExtenal(string MALOP, string TENLOP, string MAKHOA)
        {
            int value = 0;
            DataTable dt = new DataTable();
            BindingSource bds = new BindingSource();
            
            if (MAKHOA.ToString().Trim() == "CNTT")
            {
                dt = Program.ExecSqlDataTable("SELECT * FROM LINK1.QLDSV.dbo.LOP");
            }

            if (MAKHOA.ToString().Trim() == "VT")
            {
                dt = Program.ExecSqlDataTable("SELECT * FROM LINK2.QLDSV.dbo.LOP");
            }

            bds.DataSource = dt;

            for (int i = 0; i < bds.Count; i++)
            {
                if (MALOP.ToString().Trim().Equals(((DataRowView)bds[i])["MALOP"].ToString().Trim()))
                {
                    value = 1;return value;
                }
                if (TENLOP.ToString().Trim().Equals(((DataRowView)bds[i])["TENLOP"].ToString().Trim()))
                {
                    value = 2;return value;
                }
            }

            return value;
        }



    }
}
