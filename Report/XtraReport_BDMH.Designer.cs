namespace QLDSV.Report
{
    partial class XtraReport_BDMH
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
            this.lblLanThi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenMonHoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenLop = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLan = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMonHoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLop = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellHoVaTen = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDiem = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ds1 = new QLDSV.DS();
            this.sP_REPORT_BDMHTableAdapter = new QLDSV.DSTableAdapters.SP_REPORT_BDMHTableAdapter();
            this.cellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.cell0 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV.Properties.Settings.QLDSVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_REPORT_BDMH";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D16CQCN2";
            queryParameter2.Name = "@MAMONHOC";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "CSDL";
            queryParameter3.Name = "@LAN";
            queryParameter3.Type = typeof(int);
            queryParameter3.ValueInfo = "1";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.StoredProcName = "SP_REPORT_BDMH";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlNQX1JFUE9SVF9CRE1IIj48R" +
    "mllbGQgTmFtZT0iSE9URU4iIFR5cGU9IlN0cmluZyIgLz48RmllbGQgTmFtZT0iRElFTSIgVHlwZT0iS" +
    "W50MzIiIC8+PC9WaWV3PjwvRGF0YVNldD4=";
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
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 245.3333F;
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
            this.lblLanThi,
            this.lblTenMonHoc,
            this.lblTenLop,
            this.lblLan,
            this.lblMonHoc,
            this.lblLop,
            this.label1});
            this.ReportHeader.HeightF = 132.9166F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblLanThi
            // 
            this.lblLanThi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanThi.LocationFloat = new DevExpress.Utils.PointFloat(148.9583F, 94.91666F);
            this.lblLanThi.Multiline = true;
            this.lblLanThi.Name = "lblLanThi";
            this.lblLanThi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLanThi.SizeF = new System.Drawing.SizeF(452.0834F, 23F);
            this.lblLanThi.StylePriority.UseFont = false;
            this.lblLanThi.Text = "LanThi";
            // 
            // lblTenMonHoc
            // 
            this.lblTenMonHoc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonHoc.LocationFloat = new DevExpress.Utils.PointFloat(148.9583F, 71.91664F);
            this.lblTenMonHoc.Multiline = true;
            this.lblTenMonHoc.Name = "lblTenMonHoc";
            this.lblTenMonHoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenMonHoc.SizeF = new System.Drawing.SizeF(452.0834F, 23F);
            this.lblTenMonHoc.StylePriority.UseFont = false;
            this.lblTenMonHoc.Text = "TenMonHoc";
            // 
            // lblTenLop
            // 
            this.lblTenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLop.LocationFloat = new DevExpress.Utils.PointFloat(148.9583F, 48.91666F);
            this.lblTenLop.Multiline = true;
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenLop.SizeF = new System.Drawing.SizeF(452.0834F, 23F);
            this.lblTenLop.StylePriority.UseFont = false;
            this.lblTenLop.Text = "TenLop";
            // 
            // lblLan
            // 
            this.lblLan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLan.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 94.91666F);
            this.lblLan.Multiline = true;
            this.lblLan.Name = "lblLan";
            this.lblLan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLan.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblLan.StylePriority.UseFont = false;
            this.lblLan.Text = "LẦN THI:";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 71.91664F);
            this.lblMonHoc.Multiline = true;
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblMonHoc.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblMonHoc.StylePriority.UseFont = false;
            this.lblMonHoc.Text = "MÔN HỌC:";
            // 
            // lblLop
            // 
            this.lblLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 48.91666F);
            this.lblLop.Multiline = true;
            this.lblLop.Name = "lblLop";
            this.lblLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLop.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblLop.StylePriority.UseFont = false;
            this.lblLop.Text = "LỚP:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(202F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(247.375F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "BẢNG ĐIỂM MÔN HỌC";
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
            this.cellHoVaTen,
            this.cellDiem});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // cellHoVaTen
            // 
            this.cellHoVaTen.BorderColor = System.Drawing.Color.Black;
            this.cellHoVaTen.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHoVaTen.Name = "cellHoVaTen";
            this.cellHoVaTen.StyleName = "DetailCaption1";
            this.cellHoVaTen.StylePriority.UseBorderColor = false;
            this.cellHoVaTen.StylePriority.UseBorders = false;
            this.cellHoVaTen.StylePriority.UseTextAlignment = false;
            this.cellHoVaTen.Text = "HỌ VÀ TÊN";
            this.cellHoVaTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellHoVaTen.Weight = 0.5591143329326923D;
            // 
            // cellDiem
            // 
            this.cellDiem.BorderColor = System.Drawing.Color.Black;
            this.cellDiem.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellDiem.Name = "cellDiem";
            this.cellDiem.StyleName = "DetailCaption1";
            this.cellDiem.StylePriority.UseBorderColor = false;
            this.cellDiem.StylePriority.UseBorders = false;
            this.cellDiem.StylePriority.UseTextAlignment = false;
            this.cellDiem.Text = "ĐIỂM";
            this.cellDiem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellDiem.Weight = 0.44088562011718752D;
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
            this.cell2});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // cell1
            // 
            this.cell1.BorderColor = System.Drawing.Color.Black;
            this.cell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HOTEN]")});
            this.cell1.Name = "cell1";
            this.cell1.StyleName = "DetailData1";
            this.cell1.StylePriority.UseBorderColor = false;
            this.cell1.StylePriority.UseBorders = false;
            this.cell1.StylePriority.UseTextAlignment = false;
            this.cell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell1.Weight = 0.55911437988281254D;
            // 
            // cell2
            // 
            this.cell2.BorderColor = System.Drawing.Color.Black;
            this.cell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DIEM]")});
            this.cell2.Name = "cell2";
            this.cell2.StyleName = "DetailData1";
            this.cell2.StylePriority.UseBorderColor = false;
            this.cell2.StylePriority.UseBorders = false;
            this.cell2.StylePriority.UseTextAlignment = false;
            this.cell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cell2.Weight = 0.44088562011718752D;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_REPORT_BDMHTableAdapter
            // 
            this.sP_REPORT_BDMHTableAdapter.ClearBeforeFill = true;
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
            this.cellSTT.Weight = 0.5591143329326923D;
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
            this.cell0.Weight = 0.55911437988281254D;
            // 
            // XtraReport_BDMH
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
            this.DataAdapter = this.sP_REPORT_BDMHTableAdapter;
            this.DataMember = "SP_REPORT_BDMH";
            this.DataSource = this.ds1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 245);
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
        private DevExpress.XtraReports.UI.XRTableCell cellHoVaTen;
        private DevExpress.XtraReports.UI.XRTableCell cellDiem;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cell1;
        private DevExpress.XtraReports.UI.XRTableCell cell2;
        private DS ds1;
        private DSTableAdapters.SP_REPORT_BDMHTableAdapter sP_REPORT_BDMHTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel lblLan;
        private DevExpress.XtraReports.UI.XRLabel lblMonHoc;
        private DevExpress.XtraReports.UI.XRLabel lblLop;
        public DevExpress.XtraReports.UI.XRLabel lblLanThi;
        public DevExpress.XtraReports.UI.XRLabel lblTenMonHoc;
        public DevExpress.XtraReports.UI.XRLabel lblTenLop;
        private DevExpress.XtraReports.UI.XRTableCell cellSTT;
        private DevExpress.XtraReports.UI.XRTableCell cell0;
    }
}
