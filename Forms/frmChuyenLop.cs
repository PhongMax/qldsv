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
using System.Data.SqlClient;


namespace QLDSV.Forms
{
    public partial class frmChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenLop()
        {
            InitializeComponent();
        }


        private void frmChuyenLop_Load(object sender, EventArgs e)
        {

        }

        // ============================ EVENT BUTTON ============================ //
        private void buttonOK_Click(object sender, EventArgs e)
        {

            // D16CQCN3 là mã lớp cần chuyển đến cùng khoa
            // D16CQVT1 là mã lớp cần chuyển đến khác khoa

            string maSVTextBox = this.txtMaSV.Text.Trim().ToString();
            string maLopChuyenDenTextBox = this.txtMaLopChuyenDen.Text.Trim().ToString();

            string QUERY = "";

            string MASV = "";
            string MALOP = "";

            SqlCommand command;
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();

            using (SqlConnection connection = new SqlConnection(Program.URL_Connect))
            {
                // OPEN CONNECTION
                connection.Open();

                QUERY = string.Format("SELECT MASV FROM dbo.SINHVIEN WHERE MASV = 'N16DCCN076'");
                command = new SqlCommand(QUERY, connection);
                command.CommandType = CommandType.Text;

                try
                {
                    MASV = (String)command.ExecuteScalar();
                }
                catch { }
                if (MASV == null)
                {
                    MessageBox.Show("Mã Sinh Viên Không Tồn Tại");
                    this.txtMaSV.Focus();
                    return;
                }
                else // MÃ SINH VIÊN HỢP LỆ
                { 
                    Console.WriteLine("Ma Sinh Vien : " + MASV);

                    // TODO : Đưa dữ liệu sinh viên vào đối tượng tạm - lát sau sửa lại MASV vs MALOP
                    QUERY = string.Format("SELECT MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC FROM dbo.SINHVIEN WHERE MASV = 'N16DCCN076'");
                    command = new SqlCommand(QUERY, connection);
                    dataReader = command.ExecuteReader();
                    SinhVien sinhvien = new SinhVien();
                    while (dataReader.Read())
                    {
                        sinhvien.setMASV(dataReader.GetValue(0).ToString());
                        sinhvien.setHO(dataReader.GetValue(1).ToString());
                        sinhvien.setTEN(dataReader.GetValue(2).ToString());
                        sinhvien.setMALOP(dataReader.GetValue(3).ToString());
                        sinhvien.setPHAI(dataReader.GetValue(4).ToString());
                        sinhvien.setNGAYSINH(dataReader.GetValue(5).ToString());
                        sinhvien.setNOISINH(dataReader.GetValue(6).ToString());
                        sinhvien.setDIACHI(dataReader.GetValue(7).ToString());
                        sinhvien.setGHICHU(dataReader.GetValue(8).ToString());
                        sinhvien.setNGHIHOC(dataReader.GetValue(9).ToString());
                        
                    } MessageBox.Show(sinhvien.ToStringSinhVien());
                    // TODO : Must Close dataReader
                    dataReader.Close();

                    // TODO: Now Check MALOP IS EXIST ON SITE NOW
                    //QUERY = string.Format("SELECT MALOP FROM dbo.LOP WHERE MALOP = 'D16CQCN3'");// MALOP chuyen den cùng khoa
                    QUERY = string.Format("SELECT MALOP FROM dbo.LOP WHERE MALOP = 'D16CQVT1'");// MALOP chuyen den khac khoa
                    command = new SqlCommand(QUERY, connection);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        MALOP = (String)command.ExecuteScalar();
                    }
                    catch { }

                    if (MALOP != null) // TODO : Chuyển Lớp Cùng Khoa
                    {
                        MessageBox.Show("LỚP TỒN TẠI Ở SITE HIỆN TẠI");
                        // TODO : Cập nhập mã lớp cho sinh viên ở chính site hiện tại
                        QUERY = "Update SINHVIEN SET MALOP='D16CQCN3' WHERE MASV='N16DCCN076'";
                        command = new SqlCommand(QUERY, connection);
                        adapter.UpdateCommand = new SqlCommand(QUERY, connection);
                        adapter.UpdateCommand.ExecuteNonQuery();
                        XtraMessageBox.Show("Chuyển Sinh Viên Thành Công", "Info", MessageBoxButtons.OK);
                        return;
                    }
                    else // TODO : Lên Site ROOT tìm mã lớp
                    {
                        QUERY = "SELECT MALOP FROM LINK0.QLDSV.dbo.LOP WHERE MALOP = 'D16CQVT1'";// giả sử D16CQVT1 là mã lớp chuyển tới
                        command = new SqlCommand(QUERY, connection);
                        command.CommandType = CommandType.Text;
                        try
                        {
                            MALOP = (String)command.ExecuteScalar();
                        }
                        catch { }

                        if (MALOP == null) // INFO : Mã lớp không tồn tại trong Cơ Sở Dữ Liệu
                        {
                            XtraMessageBox.Show("Mã Lớp Này Không Tồn Tại Trong Cơ Sở Dữ Liệu", "INFO", MessageBoxButtons.OK);
                        }
                        if (MALOP != null) // TODO : MALOP tồn tại - Cập nhập Mã Sinh Viên mới và thay đổi mã lớp cho sinh viên sắp chuyển lớp
                        {
                            QUERY = "SELECT TOP 1 MASV FROM dbo.SINHVIEN WHERE MALOP = 'D16CQVT1' ORDER BY MASV DESC";// giả sử D16CQCVT1 là mã lớp chuyển tới
                            command = new SqlCommand(QUERY, connection);
                            command.CommandType = CommandType.Text;
                            try
                            {
                                MASV = (String)command.ExecuteScalar();
                            }
                            catch { }

                            if (MASV == null)// INFO : Lớp chưa tồn tại sinh viên
                            {
                                // TODO : Cấp mã mới
                                //string major = this.txtMaLopChuyenDen.Text.ToString().Substring(6, 2);
                                //string nienkhoa = MALOP.Substring(1, 2);
                                //string numcode = "001";
                                sinhvien.setMASV("N16DCVT001");
                                sinhvien.setMALOP(MALOP);
                                Console.WriteLine("MA SINH VIEN DUOC CAP MOI : " + sinhvien.getMASV());

                                // TODO : Cập nhập trạng thái học của sinh viên đó tại khoa ban đầu thành nghỉ học
                                QUERY = "Update SINHVIEN SET NGHIHOC=1 WHERE MASV='N16DCCN076'";
                                command = new SqlCommand(QUERY, connection);
                                adapter.UpdateCommand = new SqlCommand(QUERY, connection);
                                adapter.UpdateCommand.ExecuteNonQuery();

                                // TODO : Đưa thông tin sinh viên qua khoa mới và tạo (Sử dụng LINK0 để về site chủ làm việc)
                                QUERY = "INSERT INTO LINK0.QLDSV.dbo.SINHVIEN (MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC) \n"
                                    + "VALUES  ('" + sinhvien.getMASV() + "',N'" + sinhvien.getHO() + "',N'" + sinhvien.getTEN() + "','" + sinhvien.getMALOP() + "','" + sinhvien.getPHAI() + "','" + sinhvien.getNGAYSINH() + "',N'" + sinhvien.getNOISINH() + "',N'" + sinhvien.getDIACHI() + "',NULL, 0)";

                                command = new SqlCommand(QUERY, connection);
                                adapter.InsertCommand = new SqlCommand(QUERY, connection);
                                adapter.InsertCommand.ExecuteNonQuery();

                                XtraMessageBox.Show("Chuyển Sinh Viên Qua Khoa Khác Thành Công", "INFO", MessageBoxButtons.OK);

                                command.Dispose();
                                connection.Close();
                            }
                            else // INFO : Lớp đã chứa sinh viên
                            {
                                string major = this.txtMaLopChuyenDen.Text.ToString().Substring(6, 2);
                                string nienkhoa = MALOP.Substring(1, 2);

                                sinhvien.setMASV("N16DCVT099");
                                sinhvien.setMALOP(MALOP);
                                Console.WriteLine("MA SINH VIEN DUOC CAP MOI : " + sinhvien.getMASV());

                                // TODO : Cập nhập trạng thái học của sinh viên đó tại khoa ban đầu thành nghỉ học
                                QUERY = "Update SINHVIEN SET NGHIHOC=1 WHERE MASV='N16DCCN076'";
                                command = new SqlCommand(QUERY, connection);
                                adapter.UpdateCommand = new SqlCommand(QUERY, connection);
                                adapter.UpdateCommand.ExecuteNonQuery();

                                // TODO : Đưa thông tin sinh viên qua khoa mới và tạo (Sử dụng LINK0 để về site chủ làm việc)
                                QUERY = "INSERT INTO LINK0.QLDSV.dbo.SINHVIEN (MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC) \n"
                                    + "VALUES  ('" + sinhvien.getMASV() + "',N'" + sinhvien.getHO() + "',N'" + sinhvien.getTEN() + "','" + sinhvien.getMALOP() + "','" + sinhvien.getPHAI() + "','" + sinhvien.getNGAYSINH() + "',N'" + sinhvien.getNOISINH() + "',N'" + sinhvien.getDIACHI() + "',NULL, 0)";

                                command = new SqlCommand(QUERY, connection);
                                adapter.InsertCommand = new SqlCommand(QUERY, connection);
                                adapter.InsertCommand.ExecuteNonQuery();

                                XtraMessageBox.Show("Chuyển Sinh Viên Qua Khoa Khác Thành Công", "INFO", MessageBoxButtons.OK);

                                command.Dispose();
                                connection.Close();

                            }

                        }

                    }


                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                }
            }// END USING


        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================ FUNCTION ============================ //
        private void ChuyenLop()
        {

        }

        class SinhVien
        {
            private string MASV;
            private string HO;
            private string TEN;
            private string MALOP;
            private string PHAI;
            private string NGAYSINH;
            private string NOISINH;
            private string DIACHI;
            private string GHICHU;
            private string NGHIHOC;

            public SinhVien()
            {

            }

            public void setMASV(string MASV)
            {
                this.MASV = MASV;
            }
            public void setHO(string HO)
            {
                this.HO = HO;
            }
            public void setTEN(string TEN)
            {
                this.TEN = TEN;
            }
            public void setMALOP(string MALOP)
            {
                this.MALOP = MALOP;
            }
            public void setPHAI(string PHAI)
            {
                this.PHAI = PHAI;
            }
            public void setNGAYSINH(string NGAYSINH)
            {
                this.NGAYSINH = NGAYSINH;
            }
            public void setNOISINH(string NOISINH)
            {
                this.NOISINH = NOISINH;
            }
            public void setDIACHI(string DIACHI)
            {
                this.DIACHI = DIACHI;
            }
            public void setGHICHU(string GHICHU)
            {
                this.GHICHU = GHICHU;
            }
            public void setNGHIHOC(string NGHIHOC)
            {
                this.NGHIHOC = NGHIHOC;
            }

            public string getMASV()
            {
                return MASV;
            }
            public string getHO()
            {
                return HO;
            }
            public string getTEN()
            {
                return TEN;
            }
            public string getMALOP()
            {
                return MALOP;
            }
            public string getPHAI()
            {
                return PHAI;
            }
            public string getNGAYSINH()
            {
                return NGAYSINH;
            }
            public string getNOISINH()
            {
                return NOISINH;
            }
            public string getDIACHI()
            {
                return DIACHI;
            }
            public string getGHICHU()
            {
                return GHICHU;
            }
            public string getNGHIHOC()
            {
                return NGHIHOC;
            }


            public string ToStringSinhVien()
            {
                return MASV + "-" + HO + "-" + TEN + "-" + MALOP + "-" + PHAI + "-" + NGAYSINH + "-" + NOISINH + "-" + DIACHI + "-" + GHICHU + "-" + NGHIHOC;
            }

        }


    }
}