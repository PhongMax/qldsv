namespace QLDSV.Forms
{
    partial class frmHocPhi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gbTTSinhVien = new DevExpress.XtraEditors.GroupControl();
            this.cmbSinhVien = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.SINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.gcTTHocPhi = new DevExpress.XtraGrid.GridControl();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.gvTTHocPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOCPHITableAdapter = new QLDSV.DSTableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.hOCPHILabel = new System.Windows.Forms.Label();
            this.hOCKYLabel = new System.Windows.Forms.Label();
            this.sOTIENDADONGLabel = new System.Windows.Forms.Label();
            this.nIENKHOALabel = new System.Windows.Forms.Label();
            this.gbTTHocPhi = new DevExpress.XtraEditors.GroupControl();
            this.spiSoTienDong = new DevExpress.XtraEditors.SpinEdit();
            this.spiHocPhi = new DevExpress.XtraEditors.SpinEdit();
            this.spiHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTSinhVien)).BeginInit();
            this.gbTTSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTTHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTTHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTHocPhi)).BeginInit();
            this.gbTTHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spiSoTienDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Location = new System.Drawing.Point(12, 32);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(70, 13);
            this.mAMHLabel.TabIndex = 0;
            this.mAMHLabel.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã lớp:";
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Location = new System.Drawing.Point(227, 32);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(74, 13);
            this.tENMHLabel.TabIndex = 2;
            this.tENMHLabel.Text = "Tên sinh viên:";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(77, 133);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "THÊM";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "LÀM MỚI";
            this.btnLamMoi.Id = 5;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1096, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 426);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1096, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 402);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1096, 24);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 402);
            // 
            // gbTTSinhVien
            // 
            this.gbTTSinhVien.Controls.Add(this.cmbSinhVien);
            this.gbTTSinhVien.Controls.Add(this.mAMHLabel);
            this.gbTTSinhVien.Controls.Add(this.txtMaLop);
            this.gbTTSinhVien.Controls.Add(this.label1);
            this.gbTTSinhVien.Controls.Add(this.tENMHLabel);
            this.gbTTSinhVien.Controls.Add(this.txtTenSV);
            this.gbTTSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTTSinhVien.Location = new System.Drawing.Point(0, 24);
            this.gbTTSinhVien.Name = "gbTTSinhVien";
            this.gbTTSinhVien.Size = new System.Drawing.Size(1096, 58);
            this.gbTTSinhVien.TabIndex = 4;
            this.gbTTSinhVien.Text = "Thông tin sinh viên";
            // 
            // cmbSinhVien
            // 
            this.cmbSinhVien.Location = new System.Drawing.Point(88, 29);
            this.cmbSinhVien.MenuManager = this.barManager;
            this.cmbSinhVien.Name = "cmbSinhVien";
            this.cmbSinhVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSinhVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "Mã sinh viên")});
            this.cmbSinhVien.Properties.DataSource = this.bdsSinhVien;
            this.cmbSinhVien.Properties.DisplayMember = "MASV";
            this.cmbSinhVien.Properties.NullText = "Nhâp mã sv...";
            this.cmbSinhVien.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.cmbSinhVien.Properties.ValueMember = "MASV";
            this.cmbSinhVien.Size = new System.Drawing.Size(133, 20);
            this.cmbSinhVien.TabIndex = 1;
            this.cmbSinhVien.EditValueChanged += new System.EventHandler(this.lkeSinhVien_EditValueChanged);
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(546, 28);
            this.txtMaLop.MenuManager = this.barManager;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(114, 20);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(305, 28);
            this.txtTenSV.MenuManager = this.barManager;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(187, 20);
            this.txtTenSV.TabIndex = 3;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcTTHocPhi
            // 
            this.gcTTHocPhi.DataSource = this.bdsHocPhi;
            this.gcTTHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTTHocPhi.Location = new System.Drawing.Point(0, 190);
            this.gcTTHocPhi.MainView = this.gvTTHocPhi;
            this.gcTTHocPhi.MenuManager = this.barManager;
            this.gcTTHocPhi.Name = "gcTTHocPhi";
            this.gcTTHocPhi.Size = new System.Drawing.Size(1096, 236);
            this.gcTTHocPhi.TabIndex = 16;
            this.gcTTHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTTHocPhi});
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "FK_HOCPHI_SINHVIEN";
            this.bdsHocPhi.DataSource = this.bdsSinhVien;
            // 
            // gvTTHocPhi
            // 
            this.gvTTHocPhi.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvTTHocPhi.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTTHocPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gvTTHocPhi.GridControl = this.gcTTHocPhi;
            this.gvTTHocPhi.Name = "gvTTHocPhi";
            this.gvTTHocPhi.OptionsView.ShowGroupPanel = false;
            this.gvTTHocPhi.OptionsView.ShowViewCaption = true;
            this.gvTTHocPhi.ViewCaption = "THÔNG TIN ĐÓNG HỌC PHÍ CỦA SINH VIÊN";
            this.gvTTHocPhi.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvTTHocPhi_CustomDrawRowIndicator);
            this.gvTTHocPhi.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvTTHocPhi_CustomColumnDisplayText_1);
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.Caption = "NIÊN KHÓA";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceCell.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.Caption = "HỌC KỲ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.AppearanceCell.Options.UseTextOptions = true;
            this.colHOCPHI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCPHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCPHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCPHI.Caption = "HỌC PHÍ";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.AppearanceCell.Options.UseTextOptions = true;
            this.colSOTIENDADONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIENDADONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOTIENDADONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIENDADONG.Caption = "SỐ TIỀN ĐÃ ĐÓNG";
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // HOCPHITableAdapter
            // 
            this.HOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.HOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.THONGTINHOCPHICUASINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHILabel
            // 
            this.hOCPHILabel.AutoSize = true;
            this.hOCPHILabel.Location = new System.Drawing.Point(12, 55);
            this.hOCPHILabel.Name = "hOCPHILabel";
            this.hOCPHILabel.Size = new System.Drawing.Size(49, 13);
            this.hOCPHILabel.TabIndex = 4;
            this.hOCPHILabel.Text = "Học phí:";
            // 
            // hOCKYLabel
            // 
            this.hOCKYLabel.AutoSize = true;
            this.hOCKYLabel.Location = new System.Drawing.Point(251, 29);
            this.hOCKYLabel.Name = "hOCKYLabel";
            this.hOCKYLabel.Size = new System.Drawing.Size(44, 13);
            this.hOCKYLabel.TabIndex = 2;
            this.hOCKYLabel.Text = "Học kỳ:";
            // 
            // sOTIENDADONGLabel
            // 
            this.sOTIENDADONGLabel.AutoSize = true;
            this.sOTIENDADONGLabel.Location = new System.Drawing.Point(194, 55);
            this.sOTIENDADONGLabel.Name = "sOTIENDADONGLabel";
            this.sOTIENDADONGLabel.Size = new System.Drawing.Size(87, 13);
            this.sOTIENDADONGLabel.TabIndex = 6;
            this.sOTIENDADONGLabel.Text = "Số tiền đã đóng:";
            // 
            // nIENKHOALabel
            // 
            this.nIENKHOALabel.AutoSize = true;
            this.nIENKHOALabel.Location = new System.Drawing.Point(12, 29);
            this.nIENKHOALabel.Name = "nIENKHOALabel";
            this.nIENKHOALabel.Size = new System.Drawing.Size(59, 13);
            this.nIENKHOALabel.TabIndex = 0;
            this.nIENKHOALabel.Text = "Niên khóa:";
            // 
            // gbTTHocPhi
            // 
            this.gbTTHocPhi.Controls.Add(this.spiSoTienDong);
            this.gbTTHocPhi.Controls.Add(this.spiHocPhi);
            this.gbTTHocPhi.Controls.Add(this.spiHocKy);
            this.gbTTHocPhi.Controls.Add(this.txtNienKhoa);
            this.gbTTHocPhi.Controls.Add(this.nIENKHOALabel);
            this.gbTTHocPhi.Controls.Add(this.sOTIENDADONGLabel);
            this.gbTTHocPhi.Controls.Add(this.hOCKYLabel);
            this.gbTTHocPhi.Controls.Add(this.hOCPHILabel);
            this.gbTTHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTTHocPhi.Location = new System.Drawing.Point(0, 82);
            this.gbTTHocPhi.Name = "gbTTHocPhi";
            this.gbTTHocPhi.Size = new System.Drawing.Size(1096, 108);
            this.gbTTHocPhi.TabIndex = 5;
            this.gbTTHocPhi.Text = "Thông tin đóng học phí";
            // 
            // spiSoTienDong
            // 
            this.spiSoTienDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "SOTIENDADONG", true));
            this.spiSoTienDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiSoTienDong.Location = new System.Drawing.Point(300, 52);
            this.spiSoTienDong.MenuManager = this.barManager;
            this.spiSoTienDong.Name = "spiSoTienDong";
            this.spiSoTienDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiSoTienDong.Properties.IsFloatValue = false;
            this.spiSoTienDong.Properties.Mask.EditMask = "N00";
            this.spiSoTienDong.Size = new System.Drawing.Size(100, 20);
            this.spiSoTienDong.TabIndex = 15;
            this.spiSoTienDong.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.spiHocPhi_CustomDisplayText);
            // 
            // spiHocPhi
            // 
            this.spiHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCPHI", true));
            this.spiHocPhi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiHocPhi.Location = new System.Drawing.Point(77, 52);
            this.spiHocPhi.MenuManager = this.barManager;
            this.spiHocPhi.Name = "spiHocPhi";
            this.spiHocPhi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiHocPhi.Properties.IsFloatValue = false;
            this.spiHocPhi.Properties.Mask.EditMask = "N00";
            this.spiHocPhi.Size = new System.Drawing.Size(100, 20);
            this.spiHocPhi.TabIndex = 13;
            this.spiHocPhi.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.spiHocPhi_CustomDisplayText);
            // 
            // spiHocKy
            // 
            this.spiHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCKY", true));
            this.spiHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spiHocKy.Location = new System.Drawing.Point(300, 26);
            this.spiHocKy.MenuManager = this.barManager;
            this.spiHocKy.Name = "spiHocKy";
            this.spiHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiHocKy.Properties.IsFloatValue = false;
            this.spiHocKy.Properties.Mask.EditMask = "N00";
            this.spiHocKy.Properties.MaxValue = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.spiHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spiHocKy.Size = new System.Drawing.Size(100, 20);
            this.spiHocKy.TabIndex = 11;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(77, 26);
            this.txtNienKhoa.MenuManager = this.barManager;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(157, 20);
            this.txtNienKhoa.TabIndex = 9;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 426);
            this.Controls.Add(this.gcTTHocPhi);
            this.Controls.Add(this.gbTTHocPhi);
            this.Controls.Add(this.gbTTSinhVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHocPhi";
            this.Text = "Đóng học phí";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTSinhVien)).EndInit();
            this.gbTTSinhVien.ResumeLayout(false);
            this.gbTTSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTTHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTTHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTHocPhi)).EndInit();
            this.gbTTHocPhi.ResumeLayout(false);
            this.gbTTHocPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spiSoTienDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl gbTTSinhVien;
        private DevExpress.XtraEditors.LookUpEdit cmbSinhVien;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DS DS;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gcTTHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTTHocPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private System.Windows.Forms.Label mAMHLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tENMHLabel;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private DSTableAdapters.HOCPHITableAdapter HOCPHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gbTTHocPhi;
        private System.Windows.Forms.Label nIENKHOALabel;
        private System.Windows.Forms.Label sOTIENDADONGLabel;
        private System.Windows.Forms.Label hOCKYLabel;
        private System.Windows.Forms.Label hOCPHILabel;
        private DevExpress.XtraEditors.SpinEdit spiSoTienDong;
        private DevExpress.XtraEditors.SpinEdit spiHocPhi;
        private DevExpress.XtraEditors.SpinEdit spiHocKy;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
    }
}