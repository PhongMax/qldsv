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
    public partial class BDMH : DevExpress.XtraEditors.XtraForm
    {
        public BDMH()
        {
            InitializeComponent();
        }

        private void loadInitializeData()
        {
            this.DS.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
        }

        private void BDMH_Load(object sender, EventArgs e)
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

            this.cmbLan.Items.Add(1);
            this.cmbLan.Items.Add(2);
            this.cmbLan.SelectedIndex = 0;
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            loadInitializeData();
            this.txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            this.txtMaMonHoc.Text = this.cmbTenMonHoc.SelectedValue.ToString();
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            } catch { }
        }

        private void cmbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaMonHoc.Text = this.cmbTenMonHoc.SelectedValue.ToString();
            } catch { }
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Value : " + this.cmbLan.SelectedItem.ToString());
            XtraReport_BDMH report = new XtraReport_BDMH(this.cmbTenLop.SelectedValue.ToString(), this.cmbTenMonHoc.SelectedValue.ToString(), Int32.Parse(this.cmbLan.SelectedItem.ToString()));
            report.lblTenLop.Text = this.cmbTenLop.Text;
            report.lblTenMonHoc.Text = this.cmbTenMonHoc.Text;
            report.lblLanThi.Text = this.cmbLan.SelectedItem.ToString();
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}