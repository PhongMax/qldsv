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
    public partial class BDTK : DevExpress.XtraEditors.XtraForm
    {
        private string MALOP;
        public BDTK()
        {
            InitializeComponent();
        }

        private void loadInitializeData()
        {
            this.DS.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTableAdapter.Fill(this.DS.LOP);
        }

        private void BDTK_Load(object sender, EventArgs e)
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
                labelKhoa.Visible = true;
                labelKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();
            }

            this.MALOP = cmbLop.SelectedValue.ToString();
            Console.WriteLine("MALOP : " + this.MALOP);
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
            this.MALOP = cmbLop.SelectedValue.ToString();
            Console.WriteLine("MALOP : " + this.MALOP);
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.MALOP = this.cmbLop.SelectedValue.ToString();
                Console.WriteLine("MALOP : " + this.MALOP);
            } catch { }
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            XtraReport_BDTK report = new XtraReport_BDTK(this.MALOP);
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}