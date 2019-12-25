using DevExpress.XtraEditors;
using System;
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

            if (Program.MLogin == "HTKN")
            {
                MessageBox.Show("Bạn hãy quay về Khoa ban đầu trước khi thực hiên tạo tài khoản !", "", MessageBoxButtons.OK);
                return;
            }
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

            String strLenh = " DECLARE @return_value int " +

                            " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' " +

                            " SELECT  'Return Value' = @return_value ";
            int resultCheckLogin = Utils.CheckDataHelper(strLenh);

            if (resultCheckLogin == -1 )
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
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
                MessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin ==0)
            {
                MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);
                
            }
           

            return;
        }

        // true: ko empty, false : empty
        private Boolean isEmptyorNullTextEdits()
        {
            Boolean check = true;
            //check từng textedit
            foreach (Control c in this.grbDangKy.Controls)
            {
                if (c is TextEdit)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        errorProvider.SetError(c, "Trường dữ liệu không được để trống !");
                        check = false;
                    }
                    else
                    {
                        errorProvider.SetError(c, null);
                    }
                }
            }
            return check;
        }

        // true :đã chọn, false : ko chọn
        private Boolean checkRadioButton(RadioButton rd)
        {
            return rd.Checked;
        }

        // true: ko empty, false : empty
        private Boolean isEmptyorNullRadioButtons()
        {
            //check từng radiobutton
            foreach (Control c in this.grbDangKy.Controls)
            {
                if (c is RadioButton)
                {

                    if (checkRadioButton((RadioButton)c))
                    {
                        errorProvider.SetError(c, null);
                        return true;
                    }
                   
                }

            }

            errorProvider.SetError(this.lblTrangThai, "Bạn chưa chọn nhóm quyền !");

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
            DialogResult dr=   MessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
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
