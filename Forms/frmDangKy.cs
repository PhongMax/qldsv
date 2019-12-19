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

        private Boolean handleEmptyorNull(TextEdit txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                errorProvider.SetError(txt, "Trường dữ liệu không được để trống !");
                return false;
            }
            else
            {
                errorProvider.SetError(txt, null);
                return true;
            }
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


        private bool ValidateChildrens()
        {
            bool isValid = true;
            // xóa hết thông báo ở errorProvider
            errorProvider.Clear();

            //check từng điều kiện 
            foreach(Control c in this.grbDangKy.Controls)
            {
                if (c is TextEdit)
                {
                    Boolean check;
                    check = handleEmptyorNull((TextEdit)c);
                    if (!check)
                    {
                        isValid = false;
                    }
                   
                }
               
            }

            // check khớp mật khẩu
            if (txtConfirm.Text != txtPass.Text)
            {
                this.errorProvider.SetError(txtConfirm, "Mật khẩu không khớp");
                isValid = false;
            }
       
            return isValid;
        }
    }
}
