namespace QLDSV.Forms
{
    partial class frmLop
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label maLopLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.barManagerLop = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelBox = new System.Windows.Forms.Panel();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.DS = new QLDSV.DS();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.SINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnControlRight = new System.Windows.Forms.Panel();
            this.SinhVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextSinhVien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conThem = new System.Windows.Forms.ToolStripMenuItem();
            this.conSua = new System.Windows.Forms.ToolStripMenuItem();
            this.conXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.conGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.ToolStripSeparator();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMaLop = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnControlLeft = new System.Windows.Forms.Panel();
            this.grbLop = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            mAKHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).BeginInit();
            this.panelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnControlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGridControl)).BeginInit();
            this.contextSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.pnControlLeft.SuspendLayout();
            this.grbLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(5, 113);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(44, 14);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(5, 77);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(55, 14);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLopLabel.Location = new System.Drawing.Point(5, 40);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(50, 14);
            maLopLabel.TabIndex = 0;
            maLopLabel.Text = "MALOP:";
            // 
            // barManagerLop
            // 
            this.barManagerLop.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManagerLop.DockControls.Add(this.barDockControlTop);
            this.barManagerLop.DockControls.Add(this.barDockControlBottom);
            this.barManagerLop.DockControls.Add(this.barDockControlLeft);
            this.barManagerLop.DockControls.Add(this.barDockControlRight);
            this.barManagerLop.Form = this;
            this.barManagerLop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThem,
            this.barBtnSua,
            this.barBtnUndo,
            this.barBtnGhi,
            this.barBtnHuy,
            this.barBtnLamMoi,
            this.barBtnThoat,
            this.barBtnXoa});
            this.barManagerLop.MainMenu = this.bar2;
            this.barManagerLop.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Id = 0;
            this.barBtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThem.ImageOptions.SvgImage")));
            this.barBtnThem.Name = "barBtnThem";
            this.barBtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThem_ItemClick);
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Id = 8;
            this.barBtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnXoa.ImageOptions.SvgImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoa_ItemClick);
            // 
            // barBtnSua
            // 
            this.barBtnSua.Caption = "Sửa";
            this.barBtnSua.Id = 2;
            this.barBtnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSua.ImageOptions.SvgImage")));
            this.barBtnSua.Name = "barBtnSua";
            this.barBtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSua_ItemClick);
            // 
            // barBtnUndo
            // 
            this.barBtnUndo.Caption = "Phục Hồi";
            this.barBtnUndo.Id = 3;
            this.barBtnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUndo.ImageOptions.SvgImage")));
            this.barBtnUndo.Name = "barBtnUndo";
            this.barBtnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUndo_ItemClick);
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "Ghi";
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnGhi.ImageOptions.SvgImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnHuy
            // 
            this.barBtnHuy.Caption = "Hủy";
            this.barBtnHuy.Id = 5;
            this.barBtnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnHuy.ImageOptions.SvgImage")));
            this.barBtnHuy.Name = "barBtnHuy";
            this.barBtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHuy_ItemClick);
            // 
            // barBtnLamMoi
            // 
            this.barBtnLamMoi.Caption = "Làm Mới";
            this.barBtnLamMoi.Id = 6;
            this.barBtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLamMoi.ImageOptions.SvgImage")));
            this.barBtnLamMoi.Name = "barBtnLamMoi";
            this.barBtnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLammoi_ItemClick);
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 7;
            this.barBtnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.Image")));
            this.barBtnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.LargeImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerLop;
            this.barDockControlTop.Size = new System.Drawing.Size(908, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 503);
            this.barDockControlBottom.Manager = this.barManagerLop;
            this.barDockControlBottom.Size = new System.Drawing.Size(908, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerLop;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 479);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(908, 24);
            this.barDockControlRight.Manager = this.barManagerLop;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 479);
            // 
            // panelBox
            // 
            this.panelBox.Controls.Add(this.lblTenKhoa);
            this.panelBox.Controls.Add(this.cmbKhoa);
            this.panelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBox.Location = new System.Drawing.Point(0, 24);
            this.panelBox.Name = "panelBox";
            this.panelBox.Size = new System.Drawing.Size(908, 53);
            this.panelBox.TabIndex = 4;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Location = new System.Drawing.Point(431, 17);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(56, 19);
            this.lblTenKhoa.TabIndex = 1;
            this.lblTenKhoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(493, 17);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(273, 22);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.DS;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bdsLOP;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPGridControl.Location = new System.Drawing.Point(0, 77);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.MenuManager = this.barManagerLop;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(908, 265);
            this.lOPGridControl.TabIndex = 15;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.lOPGridControl.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.lOPGridControl_FocusedViewChanged);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceHeader.Options.UseFont = true;
            this.colMALOP.Caption = "Mã Lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.AllowFocus = false;
            this.colMALOP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MALOP", "Số dòng: {0}")});
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 161;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceCell.Options.UseTextOptions = true;
            this.colTENLOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTENLOP.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceHeader.Options.UseFont = true;
            this.colTENLOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENLOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOP.Caption = "Tên Lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.OptionsColumn.AllowFocus = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 363;
            // 
            // colMAKH
            // 
            this.colMAKH.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceHeader.Options.UseFont = true;
            this.colMAKH.Caption = "Mã Khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.OptionsColumn.AllowFocus = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 364;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLOP;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(57, 110);
            this.txtMaKhoa.MenuManager = this.barManagerLop;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaKhoa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(272, 20);
            this.txtMaKhoa.TabIndex = 5;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(57, 74);
            this.txtTenLop.MenuManager = this.barManagerLop;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.MaxLength = 100;
            this.txtTenLop.Size = new System.Drawing.Size(272, 20);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(57, 37);
            this.txtMaLop.MenuManager = this.barManagerLop;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Mask.EditMask = "\"\\\\p{Lu}+\"";
            this.txtMaLop.Properties.MaxLength = 8;
            this.txtMaLop.Size = new System.Drawing.Size(272, 20);
            this.txtMaLop.TabIndex = 1;
            this.txtMaLop.EditValueChanged += new System.EventHandler(this.txtMaLop_EditValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnControlRight);
            this.panel1.Controls.Add(this.pnControlLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 161);
            this.panel1.TabIndex = 21;
            // 
            // pnControlRight
            // 
            this.pnControlRight.Controls.Add(this.SinhVienGridControl);
            this.pnControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlRight.Location = new System.Drawing.Point(375, 0);
            this.pnControlRight.Name = "pnControlRight";
            this.pnControlRight.Size = new System.Drawing.Size(533, 161);
            this.pnControlRight.TabIndex = 1;
            // 
            // SinhVienGridControl
            // 
            this.SinhVienGridControl.ContextMenuStrip = this.contextSinhVien;
            this.SinhVienGridControl.DataSource = this.bdsSV;
            this.SinhVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SinhVienGridControl.Location = new System.Drawing.Point(0, 0);
            this.SinhVienGridControl.MainView = this.gridView2;
            this.SinhVienGridControl.MenuManager = this.barManagerLop;
            this.SinhVienGridControl.Name = "SinhVienGridControl";
            this.SinhVienGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMaLop});
            this.SinhVienGridControl.Size = new System.Drawing.Size(533, 161);
            this.SinhVienGridControl.TabIndex = 16;
            this.SinhVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // contextSinhVien
            // 
            this.contextSinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conThem,
            this.conSua,
            this.conXoa,
            this.toolStripSeparator1,
            this.conGhi,
            this.Refresh,
            this.toolStripMenuItem1});
            this.contextSinhVien.Name = "contextMenuStrip1";
            this.contextSinhVien.Size = new System.Drawing.Size(181, 148);
            // 
            // conThem
            // 
            this.conThem.Image = global::QLDSV.Properties.Resources.add_user_32;
            this.conThem.Name = "conThem";
            this.conThem.Size = new System.Drawing.Size(180, 22);
            this.conThem.Text = "Thêm";
            this.conThem.Click += new System.EventHandler(this.conThem_Click);
            // 
            // conSua
            // 
            this.conSua.Name = "conSua";
            this.conSua.Size = new System.Drawing.Size(180, 22);
            this.conSua.Text = "Sửa";
            this.conSua.Click += new System.EventHandler(this.conSua_Click);
            // 
            // conXoa
            // 
            this.conXoa.Name = "conXoa";
            this.conXoa.Size = new System.Drawing.Size(180, 22);
            this.conXoa.Text = "Xóa";
            this.conXoa.Click += new System.EventHandler(this.conXoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // conGhi
            // 
            this.conGhi.Name = "conGhi";
            this.conGhi.Size = new System.Drawing.Size(180, 22);
            this.conGhi.Text = "Ghi";
            this.conGhi.Click += new System.EventHandler(this.conGhi_Click);
            // 
            // Refresh
            // 
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(177, 6);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Lime;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Lime;
            this.gridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colMALOP1,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI,
            this.colGHICHU,
            this.colNGHIHOC});
            this.gridView2.GridControl = this.SinhVienGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowFocus = false;
            this.colMASV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MASV", "Số dòng : {0}")});
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 61;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ và tên lót";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowFocus = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 59;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowFocus = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 29;
            // 
            // colMALOP1
            // 
            this.colMALOP1.Caption = "Mã lớp";
            this.colMALOP1.ColumnEdit = this.repositoryItemMaLop;
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.OptionsColumn.AllowFocus = false;
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 3;
            this.colMALOP1.Width = 56;
            // 
            // repositoryItemMaLop
            // 
            this.repositoryItemMaLop.AutoHeight = false;
            this.repositoryItemMaLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMaLop.Name = "repositoryItemMaLop";
            this.repositoryItemMaLop.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTenn,
            this.colKhoa});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa
            // 
            this.colMa.AppearanceCell.Options.UseTextOptions = true;
            this.colMa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa.Caption = "Mã lớp";
            this.colMa.FieldName = "MALOP";
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colTenn
            // 
            this.colTenn.AppearanceCell.Options.UseTextOptions = true;
            this.colTenn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenn.Caption = "Tên lớp";
            this.colTenn.FieldName = "TENLOP";
            this.colTenn.Name = "colTenn";
            this.colTenn.Visible = true;
            this.colTenn.VisibleIndex = 1;
            // 
            // colKhoa
            // 
            this.colKhoa.AppearanceCell.Options.UseTextOptions = true;
            this.colKhoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKhoa.Caption = "Mã khoa";
            this.colKhoa.FieldName = "MAKH";
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.Visible = true;
            this.colKhoa.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowFocus = false;
            this.colPHAI.ToolTip = "(Tick --> Nam)";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 24;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowFocus = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 59;
            // 
            // colNOISINH
            // 
            this.colNOISINH.Caption = "Nơi sinh";
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.OptionsColumn.AllowFocus = false;
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 6;
            this.colNOISINH.Width = 51;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowFocus = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 7;
            this.colDIACHI.Width = 51;
            // 
            // colGHICHU
            // 
            this.colGHICHU.Caption = "Ghi chú";
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.OptionsColumn.AllowFocus = false;
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 8;
            this.colGHICHU.Width = 102;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.Caption = "Nghỉ học";
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.OptionsColumn.AllowFocus = false;
            this.colNGHIHOC.ToolTip = "(Tick --> nghỉ học)";
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 9;
            this.colNGHIHOC.Width = 30;
            // 
            // pnControlLeft
            // 
            this.pnControlLeft.BackColor = System.Drawing.Color.Silver;
            this.pnControlLeft.Controls.Add(this.grbLop);
            this.pnControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnControlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnControlLeft.Name = "pnControlLeft";
            this.pnControlLeft.Size = new System.Drawing.Size(375, 161);
            this.pnControlLeft.TabIndex = 0;
            // 
            // grbLop
            // 
            this.grbLop.Controls.Add(this.txtMaLop);
            this.grbLop.Controls.Add(maLopLabel);
            this.grbLop.Controls.Add(this.txtTenLop);
            this.grbLop.Controls.Add(this.txtMaKhoa);
            this.grbLop.Controls.Add(tENLOPLabel);
            this.grbLop.Controls.Add(mAKHLabel);
            this.grbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLop.Location = new System.Drawing.Point(12, 6);
            this.grbLop.Name = "grbLop";
            this.grbLop.Size = new System.Drawing.Size(346, 156);
            this.grbLop.TabIndex = 0;
            this.grbLop.TabStop = false;
            this.grbLop.Text = "Nhập thông tin lớp";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Làm mơi";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmLop
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(this.panelBox);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLop";
            this.Text = "Quản trị lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).EndInit();
            this.panelBox.ResumeLayout(false);
            this.panelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnControlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGridControl)).EndInit();
            this.contextSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.pnControlLeft.ResumeLayout(false);
            this.grbLop.ResumeLayout(false);
            this.grbLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerLop;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnUndo;
        private System.Windows.Forms.Panel panelBox;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnHuy;
        private DevExpress.XtraBars.BarButtonItem barBtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnControlRight;
        private System.Windows.Forms.Panel pnControlLeft;
        private System.Windows.Forms.GroupBox grbLop;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraGrid.GridControl SinhVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemMaLop;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenn;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoa;
        private System.Windows.Forms.ContextMenuStrip contextSinhVien;
        private System.Windows.Forms.ToolStripMenuItem conThem;
        private System.Windows.Forms.ToolStripMenuItem conSua;
        private System.Windows.Forms.ToolStripMenuItem conXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem conGhi;
        private System.Windows.Forms.ToolStripSeparator Refresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}