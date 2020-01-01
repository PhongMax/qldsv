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
    public partial class DSTHM : DevExpress.XtraEditors.XtraForm
    {

        public DSTHM()
        {
            InitializeComponent();
        }

        private void loadInitializeData()
        {
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
        }

        private void DSTHM_Load(object sender, EventArgs e)
        {
            //this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
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
            this.txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            this.txtMaMonHoc.Text = this.cmbTenMonHoc.SelectedValue.ToString();
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
            this.txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            } catch (Exception) { }
        }

        private void cmbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaMonHoc.Text = this.cmbTenMonHoc.SelectedValue.ToString();
            }
            catch { }
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            XtraReport_DSTHM report = new XtraReport_DSTHM(this.cmbTenLop.SelectedValue.ToString());

            report.lblTenLop.Text = this.cmbTenLop.Text;
            report.lblTenMonHoc.Text = this.cmbTenMonHoc.Text;
            report.lblThoiGianThi.Text = this.dateTimePicker.Value.ToString("dd-MM-yyyy");
            report.lblAuthor.Text = "Người In Ấn : " + Program.MHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}