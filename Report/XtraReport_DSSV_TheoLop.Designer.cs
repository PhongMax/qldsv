namespace QLDSV.Report
{
    partial class XtraReport_DSSV_TheoLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport_DSSV_TheoLop));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblTenLop = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLop = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellHo = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTen = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellPhai = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellNgaySinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellNoiSinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cell0 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ds1 = new QLDSV.DS();
            this.sP_REPORT_DSSVTableAdapter = new QLDSV.DSTableAdapters.SP_REPORT_DSSVTableAdapter();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblAuthor = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV.Properties.Settings.QLDSVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_REPORT_DSSV";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D16CQCN3";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_REPORT_DSSV";
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
            this.lblAuthor,
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 182.8333F;
            this.BottomMargin.Name = "BottomMargin";
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
            this.lblTenLop,
            this.lblLop,
            this.label1});
            this.ReportHeader.HeightF = 85.00002F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblTenLop
            // 
            this.lblTenLop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenLop.LocationFloat = new DevExpress.Utils.PointFloat(43.41784F, 62.41668F);
            this.lblTenLop.Multiline = true;
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenLop.SizeF = new System.Drawing.SizeF(457.2488F, 22.58333F);
            this.lblTenLop.StylePriority.UseFont = false;
            this.lblTenLop.Text = "TenLop";
            // 
            // lblLop
            // 
            this.lblLop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblLop.LocationFloat = new DevExpress.Utils.PointFloat(0F, 62.41668F);
            this.lblLop.Multiline = true;
            this.lblLop.Name = "lblLop";
            this.lblLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLop.SizeF = new System.Drawing.SizeF(43.41784F, 22.58333F);
            this.lblLop.StylePriority.UseFont = false;
            this.lblLop.Text = "LỚP : ";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(211.5494F, 23.54167F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(224.1172F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "DANH SÁCH SINH VIÊN";
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
            this.table1.SizeF = new System.Drawing.SizeF(653F, 28F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellSTT,
            this.cellHo,
            this.cellTen,
            this.cellPhai,
            this.cellNgaySinh,
            this.cellNoiSinh});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // cellSTT
            // 
            this.cellSTT.BorderColor = System.Drawing.Color.Black;
            this.cellSTT.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellSTT.Multiline = true;
            this.cellSTT.Name = "cellSTT";
            this.cellSTT.StyleName = "DetailCaption1";
            this.cellSTT.StylePriority.UseBorderColor = false;
            this.cellSTT.StylePriority.UseBorders = false;
            this.cellSTT.StylePriority.UseTextAlignment = false;
            this.cellSTT.Text = "STT";
            this.cellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellSTT.Weight = 0.17513000149698738D;
            // 
            // cellHo
            // 
            this.cellHo.BorderColor = System.Drawing.Color.Black;
            this.cellHo.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHo.Name = "cellHo";
            this.cellHo.StyleName = "DetailCaption1";
            this.cellHo.StylePriority.UseBorderColor = false;
            this.cellHo.StylePriority.UseBorders = false;
            this.cellHo.StylePriority.UseTextAlignment = false;
            this.cellHo.Text = "HỌ";
            this.cellHo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellHo.Weight = 0.17513000149698738D;
            // 
            // cellTen
            // 
            this.cellTen.BorderColor = System.Drawing.Color.Black;
            this.cellTen.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellTen.Name = "cellTen";
            this.cellTen.StyleName = "DetailCaption1";
            this.cellTen.StylePriority.UseBorderColor = false;
            this.cellTen.StylePriority.UseBorders = false;
            this.cellTen.StylePriority.UseTextAlignment = false;
            this.cellTen.Text = "TÊN";
            this.cellTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellTen.Weight = 0.10225372653035639D;
            // 
            // cellPhai
            // 
            this.cellPhai.BorderColor = System.Drawing.Color.Black;
            this.cellPhai.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellPhai.Name = "cellPhai";
            this.cellPhai.StyleName = "DetailCaption1";
            this.cellPhai.StylePriority.UseBorderColor = false;
            this.cellPhai.StylePriority.UseBorders = false;
            this.cellPhai.StylePriority.UseTextAlignment = false;
            this.cellPhai.Text = "PHÁI";
            this.cellPhai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellPhai.Weight = 0.16844801682692306D;
            // 
            // cellNgaySinh
            // 
            this.cellNgaySinh.BorderColor = System.Drawing.Color.Black;
            this.cellNgaySinh.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellNgaySinh.Name = "cellNgaySinh";
            this.cellNgaySinh.StyleName = "DetailCaption1";
            this.cellNgaySinh.StylePriority.UseBorderColor = false;
            this.cellNgaySinh.StylePriority.UseBorders = false;
            this.cellNgaySinh.StylePriority.UseTextAlignment = false;
            this.cellNgaySinh.Text = "NGÀY SINH";
            this.cellNgaySinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellNgaySinh.Weight = 0.30295313908503607D;
            // 
            // cellNoiSinh
            // 
            this.cellNoiSinh.BorderColor = System.Drawing.Color.Black;
            this.cellNoiSinh.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellNoiSinh.Name = "cellNoiSinh";
            this.cellNoiSinh.StyleName = "DetailCaption1";
            this.cellNoiSinh.StylePriority.UseBorderColor = false;
            this.cellNoiSinh.StylePriority.UseBorders = false;
            this.cellNoiSinh.StylePriority.UseTextAlignment = false;
            this.cellNoiSinh.Text = "NƠI SINH";
            this.cellNoiSinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellNoiSinh.Weight = 0.25121504563551683D;
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
            this.table2.SizeF = new System.Drawing.SizeF(653F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cell0,
            this.cell1,
            this.cell2,
            this.cell3,
            this.cell4,
            this.cell5});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // cell0
            // 
            this.cell0.BorderColor = System.Drawing.Color.Black;
            this.cell0.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell0.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
            this.cell0.Multiline = true;
            this.cell0.Name = "cell0";
            this.cell0.StyleName = "DetailData1";
            this.cell0.StylePriority.UseBorderColor = false;
            this.cell0.StylePriority.UseBorders = false;
            this.cell0.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cell0.Summary = xrSummary1;
            this.cell0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell0.Weight = 0.17513001718464674D;
            // 
            // cell1
            // 
            this.cell1.BorderColor = System.Drawing.Color.Black;
            this.cell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HO]")});
            this.cell1.Name = "cell1";
            this.cell1.StyleName = "DetailData1";
            this.cell1.StylePriority.UseBorderColor = false;
            this.cell1.StylePriority.UseBorders = false;
            this.cell1.StylePriority.UseTextAlignment = false;
            this.cell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell1.Weight = 0.17513001718464674D;
            // 
            // cell2
            // 
            this.cell2.BorderColor = System.Drawing.Color.Black;
            this.cell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TEN]")});
            this.cell2.Name = "cell2";
            this.cell2.StyleName = "DetailData1";
            this.cell2.StylePriority.UseBorderColor = false;
            this.cell2.StylePriority.UseBorders = false;
            this.cell2.StylePriority.UseTextAlignment = false;
            this.cell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell2.Weight = 0.10225373431775711D;
            // 
            // cell3
            // 
            this.cell3.BorderColor = System.Drawing.Color.Black;
            this.cell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PHAI]")});
            this.cell3.Name = "cell3";
            this.cell3.StyleName = "DetailData1";
            this.cell3.StylePriority.UseBorderColor = false;
            this.cell3.StylePriority.UseBorders = false;
            this.cell3.StylePriority.UseTextAlignment = false;
            this.cell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell3.Weight = 0.16844802856445312D;
            // 
            // cell4
            // 
            this.cell4.BorderColor = System.Drawing.Color.Black;
            this.cell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAYSINH]")});
            this.cell4.Name = "cell4";
            this.cell4.StyleName = "DetailData1";
            this.cell4.StylePriority.UseBorderColor = false;
            this.cell4.StylePriority.UseBorders = false;
            this.cell4.StylePriority.UseTextAlignment = false;
            this.cell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell4.Weight = 0.30295316256009613D;
            // 
            // cell5
            // 
            this.cell5.BorderColor = System.Drawing.Color.Black;
            this.cell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NOISINH]")});
            this.cell5.Name = "cell5";
            this.cell5.StyleName = "DetailData1";
            this.cell5.StylePriority.UseBorderColor = false;
            this.cell5.StylePriority.UseBorders = false;
            this.cell5.StylePriority.UseTextAlignment = false;
            this.cell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell5.Weight = 0.25121506911057695D;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_REPORT_DSSVTableAdapter
            // 
            this.sP_REPORT_DSSVTableAdapter.ClearBeforeFill = true;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 49.45828F);
            this.lblAuthor.Multiline = true;
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblAuthor.SizeF = new System.Drawing.SizeF(391.9166F, 23F);
            this.lblAuthor.StylePriority.UseFont = false;
            this.lblAuthor.Text = "lblAuthor";
            // 
            // XtraReport_DSSV_TheoLop
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.ds1,
            this.excelDataSource1});
            this.DataAdapter = this.sP_REPORT_DSSVTableAdapter;
            this.DataMember = "SP_REPORT_DSSV";
            this.DataSource = this.ds1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 97, 100, 183);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
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
        private DevExpress.XtraReports.UI.XRTableCell cellHo;
        private DevExpress.XtraReports.UI.XRTableCell cellTen;
        private DevExpress.XtraReports.UI.XRTableCell cellPhai;
        private DevExpress.XtraReports.UI.XRTableCell cellNgaySinh;
        private DevExpress.XtraReports.UI.XRTableCell cellNoiSinh;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cell1;
        private DevExpress.XtraReports.UI.XRTableCell cell2;
        private DevExpress.XtraReports.UI.XRTableCell cell3;
        private DevExpress.XtraReports.UI.XRTableCell cell4;
        private DevExpress.XtraReports.UI.XRTableCell cell5;
        private DS ds1;
        private DSTableAdapters.SP_REPORT_DSSVTableAdapter sP_REPORT_DSSVTableAdapter;
        public DevExpress.XtraReports.UI.XRLabel lblTenLop;
        public DevExpress.XtraReports.UI.XRLabel lblLop;// here important!
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Diagnostics.EventLog eventLog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraReports.UI.XRTableCell cellSTT;
        private DevExpress.XtraReports.UI.XRTableCell cell0;
        public DevExpress.XtraReports.UI.XRLabel lblAuthor;
    }
}
