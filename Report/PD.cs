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

            if (this.cmbTenSinhVien.SelectedValue != null)
            {
                this.txtMaSV.Text = this.cmbTenSinhVien.SelectedValue.ToString();
            }
            else
            {
                this.txtMaSV.Text = "Lớp Chưa Có Sinh Viên";
            }
            this.cmbTenSinhVien.Visible = false;

        }

        // ============================= EVENT ============================= //
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbKhoa);
            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì thoát.
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            loadInitializeData();
            if (this.cmbTenSinhVien.SelectedValue != null)
            {
                this.txtMaSV.Text = this.cmbTenSinhVien.SelectedValue.ToString();
            }
            else
            {
                this.txtMaSV.Text = "Lớp Chưa Có Sinh Viên";
            }
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            if (this.cmbTenSinhVien.SelectedValue != null)
            {
                this.txtMaSV.Text = this.cmbTenSinhVien.SelectedValue.ToString();
            }
            else
            {
                this.txtMaSV.Text = "Lớp Chưa Có Sinh Viên";
            }
        }

        private void btnSelectSinhVien_Click(object sender, EventArgs e)
        {
            this.txtMaSV.Text = "";
            this.txtMaSV.Visible = false;
            if (this.cmbTenSinhVien.Visible == false)
            {
                this.cmbTenSinhVien.Visible = true;
            } else
            {
                this.cmbTenSinhVien.Visible = false;
            }
            
        }

        private void cmbTenSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtMaSV.Visible = true;
            if (this.cmbTenSinhVien.SelectedValue != null)
            {
                this.txtMaSV.Text = this.cmbTenSinhVien.SelectedValue.ToString();
            }
            else
            {
                this.txtMaSV.Text = "Lớp Chưa Có Sinh Viên";
            }
        }



        private void button_IN_Click(object sender, EventArgs e)
        {
            // Chưa làm validate MASV có tồn tại không
            XtraReport_PD report = new XtraReport_PD(this.txtMaSV.Text.Trim().ToString());

            report.lblTenLop.Text = this.cmbTenLop.Text;
            report.lblHoVaTen.Text = this.cmbTenSinhVien.Text;

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}