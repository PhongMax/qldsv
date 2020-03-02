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


        // xử lý 6 trường hợp có thể có trong nghiệp vụ nhập điểm
        //Nếu lan thi = 1
        //    + Danh sách lớp chưa có điểm thi lần 1 thì hiện ra bảng sau:
        //        MASV            Họ Tên                 Điểm
        //    + Danh sách lớp đã có điểm môn học lần thi 1 thì hiện bảng như trên , nhưng cột điểm sẽ có giá trị ta nhập lần trước
        //    ==> cho  phép người dùng hiệu chỉnh điểm 
        //    + Trường hợp nếu đã có điểm môn học ở lần thi 2 thì hiện thông tin điểm như trên nhưng ko cho phép người dùng hiệu chỉnh điểm trong csdl
        //Nếu lan thi = 2
        //    + Danh sách lớp chưa nhập điểm cho lần 1 thì báo lỗi
        //    + Nếu đã nhập lần thì 1 và lần thi 2 chưa nhập : hiện bản như sau:
        //        MASV             Họ Tên                Điểm
        //    Trong đó, họ và tên là của sinh viên có điểm môn học lần thi 1 nhỏ hơn 5 hoặc vắng, còn cột điểm trống để cho người dùng nhập
        //    + Nếu đã nhập lần thì 2 thì hiện ra bảng như trên và dữ liệu điểm là của lần thi 2 cho người dùng hiệu chỉnh
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


            //   ==> TRƯỜNG HỢP HIỆU CHỈNH ĐIỂM
            if (this.bdsBangDiem_Sua.Count > 0)
            {
                 if (lanthi == 1)
                {  
                    // check lần 2 có điểm chưa
                    string temp = "  EXEC[dbo].[SP_BDMH] " +
                        " @malop = N'" + lop + "'," +
                        " @mamh = N'" + monhoc + "'," +
                           "@lan =" + 2;
                    DataTable dataTableCheck = Program.ExecSqlDataTable(temp);
                    if (dataTableCheck.Rows.Count > 0)
                    {
                        errorProvider.SetError(this.btnNhap, "Lần thi 2 đã có điểm nên  điểm ở lần thi 1 không được phép hiệu chỉnh ! ");
                        this.btnLuu.Enabled = false;
                    }

                }

                 // display thông tin trên lưới
                this.gridControlDiem.DataSource = this.bdsBangDiem_Sua;
            }
            else  //  ==> TRƯỜNG HỢP NHẬP ĐIỂM
            {
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
                        // nếu lần 1 đã có điểm thì thực hiện nhập điểm cho lần 2 với điều kiện là chỉ những sinh viên có điểm < 5.

                        for(int i = dataTableCheck.Rows.Count - 1; i >= 0; i--)
{
                            DataRow dr = dataTableCheck.Rows[i];
                            float checkDiem = float.Parse(dr["DIEM"] as string);
                            if (checkDiem > 5)
                                dr.Delete();
                            else
                            {
                                dr["DIEM"] = "";
                            }
                        }
                        dataTableCheck.AcceptChanges();
                        this.bdsBangDiem_Nhap.DataSource = dataTableCheck;
                        this.gridControlDiem.DataSource = this.bdsBangDiem_Nhap;
                        return;
                    }
                }

                //trường hợp nhập điểm cho lần thi thứ nhất.
                this.gridControlDiem.DataSource = this.bdsBangDiem_Nhap;
            }

        }
    

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrEmpty(monhoc) || string.IsNullOrEmpty(lop))
            {
                this.btnNhap.Enabled = true;
                this.btnLuu.Enabled = false;

                errorProvider.SetError(this.btnNhap, "Các trường thông tin nhập điểm không được để trống !");
                return;
            }


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
                BindingSource bdsTemp = (BindingSource)this.gridControlDiem.DataSource;
             
                // kết thúc việc cập nhật dữ liệu
                this.Validate();
                bdsTemp.EndEdit();


                // bắt đầu ghi dữ liệu
                SqlConnection conn = new SqlConnection(Program.URL_Connect);
                // bắt đầu transaction
                SqlTransaction tran;

                conn.Open();
                tran = conn.BeginTransaction();

                try
                {

                   
                    for (int i = 0; i < bdsTemp.Count ; i++)
                    {

                        SqlCommand cmd = new SqlCommand("SP_INSERT_DIEM", conn);
                        cmd.Connection = conn;
                        cmd.Transaction = tran;



                        cmd.CommandType = CommandType.StoredProcedure;
                        string masv = ((DataRowView)bdsTemp[i])["MASV"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MASV", masv));
                        cmd.Parameters.Add(new SqlParameter("@MAMH", monhoc));
                        cmd.Parameters.Add(new SqlParameter("@LAN", lanthi));

                        float diem = float.Parse(((DataRowView)bdsTemp[i])["DIEM"].ToString());
                        cmd.Parameters.Add(new SqlParameter("@DIEM", diem));

                         cmd.ExecuteNonQuery();
                  

                    }


                    tran.Commit();
                }
                catch (SqlException sqlex)
                {
                    try
                    {

                        tran.Rollback();
                        XtraMessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    conn.Close();
                    return;
                }
                finally
                {
                    conn.Close();
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
            BindingSource bdsTemp = (BindingSource)this.gridControlDiem.DataSource;
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
            // get binding source từ gridcontrol
            BindingSource bdsTemp = (BindingSource)this.gridControlDiem.DataSource;
            if (bdsTemp != null)
            {
                bdsTemp.CancelEdit();
                bdsTemp.ResetBindings(true);
            }
          
            // gọi lại form load.
            frmDiem_Load(sender, e);
        }
    }
}