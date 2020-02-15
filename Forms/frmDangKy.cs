﻿using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV.Forms
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmĐangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.

          this.DSGVTableAdapter.Connection.ConnectionString = Program.URL_Connect;
          this.DSGVTableAdapter.Fill(this.dS.GETDSGV);


            // khoa chỉ được quyền đăng ký cho khoa
            if (Program.MGroup == Program.NhomQuyen[1])
            {
                rdoKhoa.Checked = true;
                rdoPGV.Enabled = rdoPKeToan.Enabled = false;
            } // học phí chỉ được quyền đăng ký cho học phí
            else if (Program.MGroup == Program.NhomQuyen[2])
            {
                rdoPKeToan.Checked = true;
                rdoPGV.Enabled = rdoKhoa.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Properties.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
            txtConfirm.Properties.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {

           
            bool check = this.ValidateInfo();
            if (check)
            {
                createTaiKhoan();
           
            }
            else
            {
                return;
            }
        }

      
        // 1: trùng, 0 : not trùng
        private void createTaiKhoan()
        {
            
            String login = txtLogin.Text;
            String pass = txtPass.Text;
            String user = (String)lookUpUser.EditValue;
            String role = rdoKhoa.Checked ? Program.NhomQuyen[1] : (rdoPGV.Checked ? Program.NhomQuyen[0] : Program.NhomQuyen[2]);

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";

         
            // trường hợp tạo tài khoản cho pketoan thì phải dùng LINK1,LINK2 để link tới Site 3 tạo tài khoản cho pKeToan
            if (role == (Program.NhomQuyen[2]) && Program.ServerName == ((DataRowView)Program.Bds_Dspm[0])["TENSERVER"].ToString())
            {
                // site 1 ---> sử dụng LINK2
                subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";
            } else if (role == (Program.NhomQuyen[2]) && Program.ServerName == ((DataRowView)Program.Bds_Dspm[1])["TENSERVER"].ToString())

            {
                subLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                           " @LGNAME = N'" + login + "', " +
                           " @PASS = N'" + pass + "', " +
                           " @USERNAME = N'" + user + "', " +
                           " @ROLE = N'" + role + "' ";
            }

            // trường hợp tạo tài khoản cho chỉ khoa và pgv

            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = Utils.CheckDataHelper(strLenh);

            if (resultCheckLogin == -1 )
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                errorProvider.SetError(this.txtLogin, "Login bị trùng . Mời bạn nhập login khác !");
            }else if(resultCheckLogin == 2)
            {
                errorProvider.SetError(this.lookUpUser, "Giảng viên đã có tài khoản rồi !");

            }else if(resultCheckLogin == 3)
            {
                XtraMessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin ==0)
            {
                XtraMessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);
                
            }

            return;
        }

        // true: ko empty, false : empty
        private Boolean isEmptyorNullTextEdits()
        {
            Boolean check = true;


            //check từng textedit

            if (string.IsNullOrEmpty(this.txtLogin.Text))
                    {
                        errorProvider.SetError(this.txtLogin, "Trường dữ liệu không được để trống !");
                        check = false;
                    }
                    if (string.IsNullOrEmpty(this.txtPass.Text))
                    {
                        errorProvider.SetError(this.txtPass, "Trường dữ liệu không được để trống !");
                        check = false;
                    }

                    if (string.IsNullOrEmpty(this.txtConfirm.Text))
                    {
                       errorProvider.SetError(this.txtConfirm, "Trường dữ liệu không được để trống !");
                        check = false;
                     }


            return check;
        }

      
        // true: ko empty, false : empty
        private Boolean isEmptyorNullRadioButtons()
        {
            //check từng radiobutton
          
                    if (this.rdoKhoa.Checked || this.rdoPGV.Checked || this.rdoPKeToan.Checked)
                    {
                        return true;
                    }

            errorProvider.SetError(this.pnRole, "Bạn chưa chọn nhóm quyền !");

            return false;

        }


        private bool ValidateInfo()
        {
            bool isValid = true;

            // xóa hết thông báo ở errorProvider
            errorProvider.Clear();

     
            // check khoảng trống ở textedit
            if (!isEmptyorNullTextEdits())
            {
                isValid = false;
            }


            // check khớp mật khẩu
            if (txtConfirm.Text != txtPass.Text)
            {
                this.errorProvider.SetError(txtConfirm, "Mật khẩu không khớp");
                isValid = false;
            }

            // check khoảng trống ở radiobutton
            if (!isEmptyorNullRadioButtons())
            {
                isValid = false;
            }

            // login không được chứa khoảng trống
            if (txtLogin.Text.Contains(" "))
            {
                this.errorProvider.SetError(txtLogin, "Tên login không được chứa khoảng trăng !");
                isValid = false;
            }

           
            return isValid;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

    }
}
