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
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace QLDSV.Report
{
    public partial class PD : DevExpress.XtraEditors.XtraForm
    {
        public PD()
        {
            InitializeComponent();
        }

        private void loadInitializeData()
        {
            this.DS.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
        }

        private void PD_Load(object sender, EventArgs e)
        {

            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);

            loadInitializeData();

            if (Program.MGroup == Program.NhomQuyen[0])// PGV
            {
                cmbKhoa.Visible = true;
                cmbKhoa.Enabled = true;
                labelKhoa.Visible = false;
            }
            if (Program.MGroup == Program.NhomQuyen[1])// KHOA
            {
                cmbKhoa.Visible = false;
                cmbKhoa.Enabled = false;
                label_Khoa.Visible = false;

                labelKhoa.Visible = true;
                labelKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();
            }
        }

        // ============================= EVENT ============================= //
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            loadInitializeData();

            this.txtMaSV.Text = "";
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            this.txtMaSV.Text = "";
        }



        private void lookUpEditMaSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaSV.Text = (string)this.lookUpEditMaSinhVien.EditValue;
            }
            catch (Exception) { }
        }


        private void button_IN_Click(object sender, EventArgs e)
        {
            string TenSinhVien = "";
            SqlCommand command;

            using (SqlConnection connection = new SqlConnection(Program.URL_Connect))
            {
                // OPEN CONNECTION
                connection.Open();
                string QUERY = string.Format("SELECT HO+' '+TEN AS HOTEN FROM dbo.SINHVIEN WHERE MASV = '" + this.txtMaSV.Text.Trim().ToString() + "'");
                command = new SqlCommand(QUERY, connection);
                command.CommandType = CommandType.Text;
                try
                {
                    TenSinhVien = (String)command.ExecuteScalar();
                }
                catch { }
                command.Dispose();
                connection.Close();
            }

            if (TenSinhVien == null)
            {
                XtraMessageBox.Show("Mã Sinh Viên Không Tồn Tại,vui lòng kiểm tra lại!");
                txtMaSV.Focus();
                return;
            }
            else
            {
                XtraReport_PD report = new XtraReport_PD(this.txtMaSV.Text.Trim().ToString());

                report.lblHoVaTen.Text = TenSinhVien;
                report.lblTenLop.Text = this.cmbTenLop.Text;
                report.lblAuthor.Text = "Người In Ấn : " + Program.MHoten;

                ReportPrintTool print = new ReportPrintTool(report);
                print.ShowPreviewDialog();
            }
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}