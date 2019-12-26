namespace QLDSV.Report
{
    partial class XtraReport_DSDHP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport_DSDHP));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblTongTienHocPhi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTongTien = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTongSinhVien = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTongSV = new DevExpress.XtraReports.UI.XRLabel();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblHocKi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNienKhoa = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenLop = new DevExpress.XtraReports.UI.XRLabel();
            this.lblHK = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNK = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLop = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellHoTen = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellHocPhi = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellSoTienDaDong = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cell0 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ds1 = new QLDSV.DS();
            this.sP_REPORT_DSDHPTableAdapter = new QLDSV.DSTableAdapters.SP_REPORT_DSDHPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV.Properties.Settings.QLDSVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_REPORT_DSDHP";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D16CQCN2";
            queryParameter2.Name = "@NIENKHOA";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "2016";
            queryParameter3.Name = "@HOCKI";
            queryParameter3.Type = typeof(int);
            queryParameter3.ValueInfo = "1";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.StoredProcName = "SP_REPORT_DSDHP";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(148)))), ((int)(((byte)(130)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTongTienHocPhi,
            this.lblTongTien,
            this.lblTongSinhVien,
            this.lblTongSV,
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 141.1667F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // lblTongTienHocPhi
            // 
            this.lblTongTienHocPhi.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sum([HOCPHI])")});
            this.lblTongTienHocPhi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHocPhi.LocationFloat = new DevExpress.Utils.PointFloat(198.9583F, 72.45836F);
            this.lblTongTienHocPhi.Multiline = true;
            this.lblTongTienHocPhi.Name = "lblTongTienHocPhi";
            this.lblTongTienHocPhi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTongTienHocPhi.SizeF = new System.Drawing.SizeF(196.2727F, 23F);
            this.lblTongTienHocPhi.StylePriority.UseFont = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.lblTongTienHocPhi.Summary = xrSummary1;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.LocationFloat = new DevExpress.Utils.PointFloat(25F, 72.45836F);
            this.lblTongTien.Multiline = true;
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTongTien.SizeF = new System.Drawing.SizeF(173.9583F, 23F);
            this.lblTongTien.StylePriority.UseFont = false;
            this.lblTongTien.Text = "Tổng Tiền :";
            // 
            // lblTongSinhVien
            // 
            this.lblTongSinhVien.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", ""),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount()")});
            this.lblTongSinhVien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSinhVien.LocationFloat = new DevExpress.Utils.PointFloat(198.9583F, 49.45834F);
            this.lblTongSinhVien.Multiline = true;
            this.lblTongSinhVien.Name = "lblTongSinhVien";
            this.lblTongSinhVien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTongSinhVien.SizeF = new System.Drawing.SizeF(196.2727F, 23F);
            this.lblTongSinhVien.StylePriority.UseFont = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.lblTongSinhVien.Summary = xrSummary2;
            // 
            // lblTongSV
            // 
            this.lblTongSV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSV.LocationFloat = new DevExpress.Utils.PointFloat(25F, 49.45834F);
            this.lblTongSV.Multiline = true;
            this.lblTongSV.Name = "lblTongSV";
            this.lblTongSV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTongSV.SizeF = new System.Drawing.SizeF(173.9583F, 23F);
            this.lblTongSV.StylePriority.UseFont = false;
            this.lblTongSV.Text = "Tổng Sinh Viên :";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblHocKi,
            this.lblNienKhoa,
            this.lblTenLop,
            this.lblHK,
            this.lblNK,
            this.lblLop,
            this.label1});
            this.ReportHeader.HeightF = 122.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblHocKi
            // 
            this.lblHocKi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKi.LocationFloat = new DevExpress.Utils.PointFloat(150F, 94.91663F);
            this.lblHocKi.Multiline = true;
            this.lblHocKi.Name = "lblHocKi";
            this.lblHocKi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblHocKi.SizeF = new System.Drawing.SizeF(400F, 23F);
            this.lblHocKi.StylePriority.UseFont = false;
            this.lblHocKi.Text = "lblHocKi";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNienKhoa.LocationFloat = new DevExpress.Utils.PointFloat(150F, 71.91664F);
            this.lblNienKhoa.Multiline = true;
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNienKhoa.SizeF = new System.Drawing.SizeF(400F, 23F);
            this.lblNienKhoa.StylePriority.UseFont = false;
            this.lblNienKhoa.Text = "lblNienKhoa";
            // 
            // lblTenLop
            // 
            this.lblTenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLop.LocationFloat = new DevExpress.Utils.PointFloat(150F, 48.91666F);
            this.lblTenLop.Multiline = true;
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenLop.SizeF = new System.Drawing.SizeF(400F, 23F);
            this.lblTenLop.StylePriority.UseFont = false;
            this.lblTenLop.Text = "lblTenLop";
            // 
            // lblHK
            // 
            this.lblHK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHK.LocationFloat = new DevExpress.Utils.PointFloat(50F, 94.91663F);
            this.lblHK.Multiline = true;
            this.lblHK.Name = "lblHK";
            this.lblHK.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblHK.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblHK.StylePriority.UseFont = false;
            this.lblHK.Text = "Học Kì:";
            // 
            // lblNK
            // 
            this.lblNK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNK.LocationFloat = new DevExpress.Utils.PointFloat(50F, 71.91664F);
            this.lblNK.Multiline = true;
            this.lblNK.Name = "lblNK";
            this.lblNK.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNK.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblNK.StylePriority.UseFont = false;
            this.lblNK.Text = "Niên Khóa:";
            // 
            // lblLop
            // 
            this.lblLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.LocationFloat = new DevExpress.Utils.PointFloat(50F, 48.91666F);
            this.lblLop.Multiline = true;
            this.lblLop.Name = "lblLop";
            this.lblLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLop.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblLop.StylePriority.UseFont = false;
            this.lblLop.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(198.7084F, 10.00001F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(251.5416F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "DANH SÁCH ĐÓNG HỌC PHÍ";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(650F, 28F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellSTT,
            this.cellHoTen,
            this.cellHocPhi,
            this.cellSoTienDaDong});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // cellSTT
            // 
            this.cellSTT.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cellSTT.Multiline = true;
            this.cellSTT.Name = "cellSTT";
            this.cellSTT.StyleName = "DetailCaption1";
            this.cellSTT.StylePriority.UseBorders = false;
            this.cellSTT.StylePriority.UseTextAlignment = false;
            this.cellSTT.Text = "STT";
            this.cellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellSTT.Weight = 0.24575096717247597D;
            // 
            // cellHoTen
            // 
            this.cellHoTen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cellHoTen.Name = "cellHoTen";
            this.cellHoTen.StyleName = "DetailCaption1";
            this.cellHoTen.StylePriority.UseBorders = false;
            this.cellHoTen.StylePriority.UseTextAlignment = false;
            this.cellHoTen.Text = "HỌ VÀ TÊN";
            this.cellHoTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellHoTen.Weight = 0.24575096717247597D;
            // 
            // cellHocPhi
            // 
            this.cellHocPhi.Name = "cellHocPhi";
            this.cellHocPhi.StyleName = "DetailCaption1";
            this.cellHocPhi.StylePriority.UseTextAlignment = false;
            this.cellHocPhi.Text = "HỌC PHÍ";
            this.cellHocPhi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellHocPhi.Weight = 0.26597400371844954D;
            // 
            // cellSoTienDaDong
            // 
            this.cellSoTienDaDong.Name = "cellSoTienDaDong";
            this.cellSoTienDaDong.StyleName = "DetailCaption1";
            this.cellSoTienDaDong.StylePriority.UseTextAlignment = false;
            this.cellSoTienDaDong.Text = "SỐ TIỀN ĐÃ ĐÓNG";
            this.cellSoTienDaDong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellSoTienDaDong.Weight = 0.48827505258413462D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.OddStyleName = "DetailData3_Odd";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cell0,
            this.cell1,
            this.cell2,
            this.cell3});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // cell0
            // 
            this.cell0.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cell0.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
            this.cell0.Multiline = true;
            this.cell0.Name = "cell0";
            this.cell0.StyleName = "DetailData1";
            this.cell0.StylePriority.UseBorders = false;
            this.cell0.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cell0.Summary = xrSummary3;
            this.cell0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell0.Weight = 0.24575096717247597D;
            // 
            // cell1
            // 
            this.cell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HOTEN]")});
            this.cell1.Name = "cell1";
            this.cell1.StyleName = "DetailData1";
            this.cell1.StylePriority.UseBorders = false;
            this.cell1.StylePriority.UseTextAlignment = false;
            this.cell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell1.Weight = 0.24575096717247597D;
            // 
            // cell2
            // 
            this.cell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HOCPHI]")});
            this.cell2.Name = "cell2";
            this.cell2.StyleName = "DetailData1";
            this.cell2.StylePriority.UseTextAlignment = false;
            this.cell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell2.Weight = 0.26597400371844954D;
            // 
            // cell3
            // 
            this.cell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SOTIENDADONG]")});
            this.cell3.Name = "cell3";
            this.cell3.StyleName = "DetailData1";
            this.cell3.StylePriority.UseTextAlignment = false;
            this.cell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell3.Weight = 0.48827505258413462D;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_REPORT_DSDHPTableAdapter
            // 
            this.sP_REPORT_DSDHPTableAdapter.ClearBeforeFill = true;
            // 
            // XtraReport_DSDHP
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.ds1});
            this.DataAdapter = this.sP_REPORT_DSDHPTableAdapter;
            this.DataMember = "SP_REPORT_DSDHP";
            this.DataSource = this.ds1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 141);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell cellSTT;
        private DevExpress.XtraReports.UI.XRTableCell cellHoTen;
        private DevExpress.XtraReports.UI.XRTableCell cellHocPhi;
        private DevExpress.XtraReports.UI.XRTableCell cellSoTienDaDong;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cell1;
        private DevExpress.XtraReports.UI.XRTableCell cell2;
        private DevExpress.XtraReports.UI.XRTableCell cell3;
        private DS ds1;
        private DSTableAdapters.SP_REPORT_DSDHPTableAdapter sP_REPORT_DSDHPTableAdapter;
        private DevExpress.XtraReports.UI.XRTableCell cell0;
        private DevExpress.XtraReports.UI.XRLabel lblHK;
        private DevExpress.XtraReports.UI.XRLabel lblNK;
        private DevExpress.XtraReports.UI.XRLabel lblLop;
        public DevExpress.XtraReports.UI.XRLabel lblHocKi;
        public DevExpress.XtraReports.UI.XRLabel lblNienKhoa;
        public DevExpress.XtraReports.UI.XRLabel lblTenLop;
        public DevExpress.XtraReports.UI.XRLabel lblTongTienHocPhi;
        private DevExpress.XtraReports.UI.XRLabel lblTongTien;
        public DevExpress.XtraReports.UI.XRLabel lblTongSinhVien;
        private DevExpress.XtraReports.UI.XRLabel lblTongSV;
    }
}
