using DevExpress.XtraEditors;
using System;
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
                rdoPKeToan.Enabled = rdoKhoa.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Properties.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
            txtConfirm.Properties.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool check = this.ValidateChildrens();
            if (check)
            {
                MessageBox.Show("Thao tác đăng ký tài khoản thành công !", "", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                return;
            }
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


        private bool ValidateChildrens()
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
            return isValid;
        }
    }
}
