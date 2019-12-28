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

namespace QLDSV.Forms
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bdsSpDSSV_Diem = new BindingSource();
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
               loadInitializeData();
            }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

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
            // TODO: load data
            loadInitializeData();
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

        
          if(string.IsNullOrEmpty(monhoc) || string.IsNullOrEmpty(lop))
            {
                errorProvider.SetError(this.btnNhap , "Các trường thông tin nhập điểm không được để trống !" );
                return;
            }


            this.SP_BDMHTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.SP_BDMHTableAdapter.Fill(this.DS.SP_BDMH, lop, monhoc, lanthi);

            


            if (bdsSP_BDMH.Count > 0)
          {   // sửa
              // this.gridControlSua.Visible = true;
              // this.gridControlSua.();
              //  visible và invisible.
              //for (int i = 0; i < this.gridViewSua.Columns.Count; i++)
              //{
              //    this.gridViewSua.Columns[i].Visible = false;

                //}

               this.gridControlSua.BringToFront();

            }
            else
            {
                this.gridControlNhap.BringToFront();

                string cmd = "EXEC	[dbo].[SP_DSSV_MH] @malop = N'" + lop + "'";
                DataTable tblDiem = Program.ExecSqlDataTable(cmd);
                this.bdsSpDSSV_Diem.DataSource = tblDiem;
                this.gridControlNhap.DataSource = this.bdsSpDSSV_Diem;

            }
          

           
  


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (checkEmptyRow())
            {
                errorProvider.SetError(this.btnLuu, "Bạn chưa nhập hết bản điểm cho sinh viên !");
                return;
            }
            else
            {
                // cập nhật con trỏ chuột...
                bdsSpDSSV_Diem.EndEdit();
                bdsSpDSSV_Diem.MoveFirst();

                for (int i = 0; i < bdsSpDSSV_Diem.Count; i++)
                {
                    using (SqlConnection conn = new SqlConnection(Program.URL_Connect))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SP_INSERT_DIEM", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        string masv = ((DataRowView)bdsSpDSSV_Diem[i])["MASV"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MASV", masv));
                        cmd.Parameters.Add(new SqlParameter("@MAMH", monhoc));
                        cmd.Parameters.Add(new SqlParameter("@LAN", lanthi));



                        // chỗ này sửa cho bds update kia nữa.
                        float diem = float.Parse(((DataRowView)bdsSpDSSV_Diem[i])["DIEM"].ToString());
                        cmd.Parameters.Add(new SqlParameter("@DIEM", diem));

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi điểm vào Database. Bạn hãy xem lại ! " + ex.Message, "", MessageBoxButtons.OK);
                            conn.Close();
                            return;

                        }
                        conn.Close();
                    }
                }

                MessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
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
            int slg = bdsSpDSSV_Diem.Count;
            for (int i = 0; i < slg; i++)
            {
                if (((DataRowView)bdsSpDSSV_Diem[i])["DIEM"].ToString() == "")
                {
                   
                    bdsSpDSSV_Diem.Position = i;
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

        private void gridViewSua_HiddenEditor(object sender, EventArgs e)
        {

            GridView View = sender as GridView;
            if (View.FocusedRowHandle == GridControl.NewItemRowHandle) return;
            if (View.FocusedRowHandle == View.RowCount - 1)
                View.FocusedRowHandle = 0;
            else
                View.FocusedRowHandle++;
            View.ShowEditor();
        }

        private void gridViewSua_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "DIEM")
            {

                double price = 0;
                price = double.Parse(e.Value as string);

                if ( price < 0 || price > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm phải lớn hơn không và nhỏ hơn 10";
                }
                //try
                //{
                //    diem = float.Parse(e.Value as String);

                //}
                //catch (Exception)
                //{
                //    return;
                // }
                //if (e.Value < 0 || diem > 10)
                //{
                //    e.Valid = false;
                //    e.ErrorText = "Điểm phải lớn hơn không và nhỏ hơn 10";
                //}
            }
        }

        private void gridViewSua_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }
    }
}