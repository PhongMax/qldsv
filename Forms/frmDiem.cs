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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Data.SqlClient;
using DevExpress.Utils;

namespace QLDSV.Forms
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource bdsBangDiem_Nhap = new BindingSource();
        private BindingSource bdsBangDiem_Sua = new BindingSource();

        private String lop = "";
        private String monhoc = "";
        private short lanthi;
        public frmDiem()
        {
            InitializeComponent();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            // TODO : Chuyển Bộ Phận
            Utils.ComboboxHelper(this.cmbKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadInitializeData();
            }
        }



        private void loadInitializeData()
        {
            // kết nối trước rồi mới fill.
            this.LOPTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;

            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);



        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            errorProvider.Clear();

            // TODO: load data
            loadInitializeData();

            this.btnNhap.Enabled = true;
            this.btnLuu.Enabled = false;
            this.groupControlNhapDiem.Enabled = true;


            // đoạn code liên kết giữa bds với combo box
            // lọc phân mảnh trước
            Program.Bds_Dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Utils.BindingDataToComBo(cmbKhoa, Program.Bds_Dspm.DataSource);

            // TODO : Role Action
            if (Program.MGroup == Program.NhomQuyen[0])// PGV
            {
                cmbKhoa.Visible = true;
                cmbKhoa.Enabled = true;
            }
            else if (Program.MGroup == Program.NhomQuyen[1]) // KHOA
            {
                cmbKhoa.Visible = false;
                lblTenKhoa.Text = ((DataRowView)Program.Bds_Dspm[Program.MKhoa])["TENKHOA"].ToString();
            }
        }

        private void lookUpEditMalop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtTenlop.Text = (string)this.lookUpEditMalop.EditValue;
            }
            catch (Exception) { }
        }


        private void lookUpEditMaMon_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtTenMon.Text = (string)this.lookUpEditMaMon.EditValue;
            }
            catch (Exception) { }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
           
            errorProvider.Clear();

            monhoc = (String)lookUpEditMaMon.EditValue;
            lanthi = numericLanThi.Value == 1 ? (short)1 : (short)2;
            lop = (String)lookUpEditMalop.EditValue;


            if (string.IsNullOrEmpty(monhoc) || string.IsNullOrEmpty(lop))
            {
                this.btnNhap.Enabled = true;
                this.btnLuu.Enabled = false;

                errorProvider.SetError(this.btnNhap, "Các trường thông tin nhập điểm không được để trống !");
                return;
            }

            this.btnNhap.Enabled = false;
            this.btnLuu.Enabled = true;
            this.groupControlNhapDiem.Enabled = false;

            // list ra bảng điểm danh sách sinh viên để sửa
            string cmd = "  EXEC[dbo].[SP_BDMH] " +
                         " @malop = N'" + lop + "'," +
                         " @mamh = N'" + monhoc + "'," +
                         "@lan =" + lanthi;
            DataTable tblDiem_Sua = Program.ExecSqlDataTable(cmd);
            this.bdsBangDiem_Sua.DataSource = tblDiem_Sua;


            // list ra bảng điểm danh sách sinh viên để nhập
            string cmd1 = "EXEC	[dbo].[SP_DSSV_MH] @malop = N'" + lop + "'";
            DataTable tblDiem_Nhap = Program.ExecSqlDataTable(cmd1);
            this.bdsBangDiem_Nhap.DataSource = tblDiem_Nhap;

            if (this.bdsBangDiem_Sua.Count > 0)
            {
                // trường hợp sửa điểm
                this.btnHuy.DataSource = this.bdsBangDiem_Sua;
            }
            else
            {
                // trường hợp nhập điểm cho lần thi thứ 2...

                // lần 2 được nhập điểm nếu lần 1 đã nhập điểm
                if (lanthi == 2)
                {
                    // check lần 1 có điểm hay chưa
                    string temp = "  EXEC[dbo].[SP_BDMH] " +
                         " @malop = N'" + lop + "'," +
                         " @mamh = N'" + monhoc + "'," +
                            "@lan =" + 1;
                    DataTable dataTableCheck = Program.ExecSqlDataTable(temp);
                    

                    if (dataTableCheck.Rows.Count <= 0)
                    {
                        errorProvider.SetError(this.btnNhap, "Bạn chưa nhập điểm thi cho lần 1 ");
                        return;
                    }
                    else
                    {
                        // nếu lần 1 đã có điểm thì thực hiện nhập điểm cho lần 2 với điều kiện là chỉ những sinh viên có điểm < 4.

                        for(int i = dataTableCheck.Rows.Count - 1; i >= 0; i--)
{
                            DataRow dr = dataTableCheck.Rows[i];
                            float checkDiem = float.Parse(dr["DIEM"] as string);
                            if (checkDiem > 4)
                                dr.Delete();
                            else
                            {
                                dr["DIEM"] = "";
                            }
                        }
                        dataTableCheck.AcceptChanges();
                        this.bdsBangDiem_Nhap.DataSource = dataTableCheck;
                        
                    }
                }


                //trường hợp nhập điểm cho lần thi thứ nhất.
                this.btnHuy.DataSource = this.bdsBangDiem_Nhap;
            }

        }
    

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (checkEmptyRow())
            {
                this.btnNhap.Enabled = false;
                this.btnLuu.Enabled = true;
                errorProvider.SetError(this.btnLuu, "Bạn chưa nhập hết bản điểm cho sinh viên !");
                return;
            }
            else
            {
                //get binding source từ gridcontrol
                BindingSource bdsTemp = (BindingSource)this.btnHuy.DataSource;
             
                // kết thúc việc cập nhật dữ liệu
                this.Validate();
                bdsTemp.EndEdit();



                for (int i = 0; i < bdsBangDiem_Nhap.Count; i++)
                {
                    using (SqlConnection conn = new SqlConnection(Program.URL_Connect))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SP_INSERT_DIEM", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        string masv = ((DataRowView)bdsTemp[i])["MASV"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MASV", masv));
                        cmd.Parameters.Add(new SqlParameter("@MAMH", monhoc));
                        cmd.Parameters.Add(new SqlParameter("@LAN", lanthi));

                        float diem = float.Parse(((DataRowView)bdsTemp[i])["DIEM"].ToString());
                        cmd.Parameters.Add(new SqlParameter("@DIEM", diem));

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi ghi điểm vào Database. Bạn hãy xem lại ! " + ex.Message, "", MessageBoxButtons.OK);
                            conn.Close();
                            return;

                        }
                        conn.Close();
                    }
                }

                XtraMessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
                this.btnNhap.Enabled = true;
                this.btnLuu.Enabled = false;
                this.groupControlNhapDiem.Enabled = true;
                return;
            }
        }

        // sự kiện enter xuống dòng mới.
        private void gridViewnNhap_HiddenEditor(object sender, EventArgs e)
        {
            GridView View = sender as GridView;
            if (View.FocusedRowHandle == GridControl.NewItemRowHandle) return;
            if (View.FocusedRowHandle == View.RowCount - 1)
                View.FocusedRowHandle = 0;
            else
                View.FocusedRowHandle++;
            View.ShowEditor();
        }

      
        private void gridViewnNhap_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "DIEM")
            {
                float diem = 0;
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                diem = float.Parse(e.Value as String);
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm phải lớn hơn không và nhỏ hơn 10";
                }
            }
        }


        private bool  checkEmptyRow()
        {
            // get binding source từ gridcontrol
            BindingSource bdsTemp = (BindingSource)this.btnHuy.DataSource;
            int slg = bdsTemp.Count;
            for (int i = 0; i < slg; i++)
            {
                if (((DataRowView)bdsTemp[i])["DIEM"].ToString() == "")
                {
                    bdsTemp.Position = i;
                    return true;
                }
               
            }

            return false;
        }

        private void gridViewnNhap_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridViewDiem_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
             e.Handled = true;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0xC6, 0x64, 0xFF));
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height));
            Size size = ImageCollection.GetImageListSize(e.Info.ImageCollection);
            Rectangle r = e.Bounds;
            ImageCollection.DrawImageListImage(e.Cache, e.Info.ImageCollection, e.Info.ImageIndex,
                    new Rectangle(r.X + (r.Width - size.Width) / 2, r.Y + (r.Height - size.Height) / 2, size.Width, size.Height));
            brush.Dispose();
        }

      

        private void btnHuyy_Click(object sender, EventArgs e)
        {
            // gọi lại form load.
            frmDiem_Load(sender, e);
        }
    }
}