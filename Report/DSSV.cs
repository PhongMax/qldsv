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
    public partial class DSSV : DevExpress.XtraEditors.XtraForm
    {
        public DSSV()
        {
            InitializeComponent();
        }

        private void loadInitializeData()
        {
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTableAdapter.Fill(this.dS.LOP);
        }

        private void DSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa,Program.Bds_Dspm.DataSource);

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
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = this.cmbTenLop.SelectedValue.ToString();
            }catch (Exception){ }
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            XtraReport_DSSV_TheoLop report = new XtraReport_DSSV_TheoLop(this.cmbTenLop.SelectedValue.ToString());
            report.lblTenLop.Text = cmbTenLop.Text;
            report.lblAuthor.Text = "Người In Ấn : " + Program.MHoten;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}