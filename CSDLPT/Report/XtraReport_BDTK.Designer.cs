namespace QLDSV.Report
{
    partial class XtraReport_BDTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport_BDTK));
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.crossTabGeneralStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.crossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.xrCrossTabCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sP_REPORT_BDTKTableAdapter1 = new QLDSV.DSTableAdapters.SP_REPORT_BDTKTableAdapter();
            this.ds1 = new QLDSV.DS();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.lblAuthor = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV.Properties.Settings.QLDSVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_REPORT_BDTK";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D16CQCN2";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_REPORT_BDTK";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // crossTabGeneralStyle
            // 
            this.crossTabGeneralStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.crossTabGeneralStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle.BorderWidth = 1F;
            this.crossTabGeneralStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            this.crossTabGeneralStyle.Name = "crossTabGeneralStyle";
            this.crossTabGeneralStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // crossTabDataStyle
            // 
            this.crossTabDataStyle.Name = "crossTabDataStyle";
            this.crossTabDataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderStyle
            // 
            this.crossTabHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.crossTabHeaderStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderStyle.Name = "crossTabHeaderStyle";
            this.crossTabHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabTotalStyle
            // 
            this.crossTabTotalStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.crossTabTotalStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabTotalStyle.Name = "crossTabTotalStyle";
            this.crossTabTotalStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 42.01302F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(279.0244F, 30.01302F);
            this.label1.StyleName = "TitleStyle";
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTab1});
            this.Detail.HeightF = 75F;
            this.Detail.Name = "Detail";
            // 
            // crossTab1
            // 
            this.crossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTabCell1,
            this.xrCrossTabCell2,
            this.xrCrossTabCell3,
            this.xrCrossTabCell4,
            this.xrCrossTabCell5,
            this.xrCrossTabCell6,
            this.xrCrossTabCell7,
            this.xrCrossTabCell8,
            this.xrCrossTabCell9});
            crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition2.Visible = false;
            this.crossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            crossTabColumnDefinition1,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F),
            crossTabColumnDefinition2});
            crossTabColumnField1.FieldName = "TENMH";
            this.crossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.crossTab1.DataAdapter = this.sP_REPORT_BDTKTableAdapter1;
            this.crossTab1.DataAreaStyleName = "crossTabDataStyle";
            crossTabDataField1.FieldName = "DIEM";
            this.crossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.crossTab1.DataMember = "SP_REPORT_BDTK";
            this.crossTab1.DataSource = this.ds1;
            this.crossTab1.GeneralStyleName = "crossTabGeneralStyle";
            this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle";
            this.crossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.crossTab1.Name = "crossTab1";
            crossTabRowDefinition1.Visible = false;
            this.crossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            crossTabRowDefinition1});
            crossTabRowField1.FieldName = "HOTEN";
            this.crossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.crossTab1.SizeF = new System.Drawing.SizeF(300F, 75F);
            this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle";
            // 
            // xrCrossTabCell1
            // 
            this.xrCrossTabCell1.ColumnIndex = 0;
            this.xrCrossTabCell1.Name = "xrCrossTabCell1";
            this.xrCrossTabCell1.RowIndex = 0;
            this.xrCrossTabCell1.Text = "HOTEN";
            // 
            // xrCrossTabCell2
            // 
            this.xrCrossTabCell2.ColumnIndex = 1;
            this.xrCrossTabCell2.Name = "xrCrossTabCell2";
            this.xrCrossTabCell2.RowIndex = 1;
            // 
            // xrCrossTabCell3
            // 
            this.xrCrossTabCell3.ColumnIndex = 1;
            this.xrCrossTabCell3.Name = "xrCrossTabCell3";
            this.xrCrossTabCell3.RowIndex = 0;
            // 
            // xrCrossTabCell4
            // 
            this.xrCrossTabCell4.ColumnIndex = 2;
            this.xrCrossTabCell4.Name = "xrCrossTabCell4";
            this.xrCrossTabCell4.RowIndex = 0;
            this.xrCrossTabCell4.Text = "Grand Total";
            // 
            // xrCrossTabCell5
            // 
            this.xrCrossTabCell5.ColumnIndex = 2;
            this.xrCrossTabCell5.Name = "xrCrossTabCell5";
            this.xrCrossTabCell5.RowIndex = 1;
            // 
            // xrCrossTabCell6
            // 
            this.xrCrossTabCell6.ColumnIndex = 0;
            this.xrCrossTabCell6.Name = "xrCrossTabCell6";
            this.xrCrossTabCell6.RowIndex = 1;
            // 
            // xrCrossTabCell7
            // 
            this.xrCrossTabCell7.ColumnIndex = 0;
            this.xrCrossTabCell7.Name = "xrCrossTabCell7";
            this.xrCrossTabCell7.RowIndex = 2;
            this.xrCrossTabCell7.Text = "Grand Total";
            // 
            // xrCrossTabCell8
            // 
            this.xrCrossTabCell8.ColumnIndex = 1;
            this.xrCrossTabCell8.Name = "xrCrossTabCell8";
            this.xrCrossTabCell8.RowIndex = 2;
            // 
            // xrCrossTabCell9
            // 
            this.xrCrossTabCell9.ColumnIndex = 2;
            this.xrCrossTabCell9.Name = "xrCrossTabCell9";
            this.xrCrossTabCell9.RowIndex = 2;
            // 
            // sP_REPORT_BDTKTableAdapter1
            // 
            this.sP_REPORT_BDTKTableAdapter1.ClearBeforeFill = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblAuthor});
            this.BottomMargin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.StylePriority.UseFont = false;
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new System.Drawing.Font("Arial", 18F);
            this.TitleStyle.Name = "TitleStyle";
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // lblAuthor
            // 
            this.lblAuthor.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 22.52862F);
            this.lblAuthor.Multiline = true;
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblAuthor.SizeF = new System.Drawing.SizeF(290F, 23F);
            this.lblAuthor.Text = "lblAuthor";
            // 
            // XtraReport_BDTK
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.ds1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TitleStyle,
            this.crossTabGeneralStyle,
            this.crossTabHeaderStyle,
            this.crossTabDataStyle,
            this.crossTabTotalStyle});
            this.Version = "19.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab crossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell9;
        private DS ds1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DSTableAdapters.SP_REPORT_BDTKTableAdapter sP_REPORT_BDTKTableAdapter1;
        public DevExpress.XtraReports.UI.XRLabel lblAuthor;
    }
}
