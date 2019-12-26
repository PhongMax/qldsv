namespace QLDSV.Forms
{
    partial class frmDiem
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
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.pnLeftControl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.grbDiem = new System.Windows.Forms.GroupBox();
            this.numericLanThi = new System.Windows.Forms.NumericUpDown();
            this.txtTenMon = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLanthi = new System.Windows.Forms.Label();
            this.lookUpEditMaMon = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.label3 = new System.Windows.Forms.Label();
            this.lookUpEditMalop = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenlop = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.gridControlNhap = new DevExpress.XtraGrid.GridControl();
            this.gridViewnNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditNhap = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControlSua = new DevExpress.XtraGrid.GridControl();
            this.bdsSP_BDMH = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewSua = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.SP_BDMHTableAdapter = new QLDSV.DSTableAdapters.SP_BDMHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.pnLeftControl.SuspendLayout();
            this.grbControl.SuspendLayout();
            this.grbDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLanThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).BeginInit();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewnNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_BDMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSua)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // pnLeftControl
            // 
            this.pnLeftControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnLeftControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLeftControl.Controls.Add(this.button1);
            this.pnLeftControl.Controls.Add(this.grbControl);
            this.pnLeftControl.Controls.Add(this.grbDiem);
            this.pnLeftControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftControl.Location = new System.Drawing.Point(0, 0);
            this.pnLeftControl.Name = "pnLeftControl";
            this.pnLeftControl.Size = new System.Drawing.Size(437, 503);
            this.pnLeftControl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enable Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.btnHuy);
            this.grbControl.Controls.Add(this.btnLuu);
            this.grbControl.Controls.Add(this.btnNhap);
            this.grbControl.Location = new System.Drawing.Point(65, 338);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(221, 100);
            this.grbControl.TabIndex = 1;
            this.grbControl.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(111, 62);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(21, 62);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(79, 4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Start";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // grbDiem
            // 
            this.grbDiem.Controls.Add(this.numericLanThi);
            this.grbDiem.Controls.Add(this.txtTenMon);
            this.grbDiem.Controls.Add(this.label5);
            this.grbDiem.Controls.Add(this.lblLanthi);
            this.grbDiem.Controls.Add(this.lookUpEditMaMon);
            this.grbDiem.Controls.Add(this.label3);
            this.grbDiem.Controls.Add(this.lookUpEditMalop);
            this.grbDiem.Controls.Add(this.txtTenlop);
            this.grbDiem.Controls.Add(this.label2);
            this.grbDiem.Controls.Add(this.label1);
            this.grbDiem.Controls.Add(this.lblTenKhoa);
            this.grbDiem.Controls.Add(this.cmbKhoa);
            this.grbDiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDiem.Location = new System.Drawing.Point(10, 10);
            this.grbDiem.Name = "grbDiem";
            this.grbDiem.Size = new System.Drawing.Size(423, 309);
            this.grbDiem.TabIndex = 0;
            this.grbDiem.TabStop = false;
            this.grbDiem.Text = "Nhập điểm";
            // 
            // numericLanThi
            // 
            this.numericLanThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLanThi.Location = new System.Drawing.Point(166, 269);
            this.numericLanThi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericLanThi.Name = "numericLanThi";
            this.numericLanThi.Size = new System.Drawing.Size(55, 20);
            this.numericLanThi.TabIndex = 15;
            this.numericLanThi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(76, 226);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Properties.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(317, 20);
            this.txtTenMon.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "TÊN MÔN";
            // 
            // lblLanthi
            // 
            this.lblLanthi.AutoSize = true;
            this.lblLanthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanthi.Location = new System.Drawing.Point(31, 276);
            this.lblLanthi.Name = "lblLanthi";
            this.lblLanthi.Size = new System.Drawing.Size(49, 13);
            this.lblLanthi.TabIndex = 11;
            this.lblLanthi.Text = "LẦN THI";
            // 
            // lookUpEditMaMon
            // 
            this.lookUpEditMaMon.Location = new System.Drawing.Point(76, 185);
            this.lookUpEditMaMon.Name = "lookUpEditMaMon";
            this.lookUpEditMaMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMaMon.Properties.DataSource = this.bdsMonhoc;
            this.lookUpEditMaMon.Properties.DisplayMember = "MAMH";
            this.lookUpEditMaMon.Properties.NullText = "Chọn mã môn";
            this.lookUpEditMaMon.Properties.ValueMember = "TENMH";
            this.lookUpEditMaMon.Size = new System.Drawing.Size(317, 20);
            this.lookUpEditMaMon.TabIndex = 10;
            this.lookUpEditMaMon.EditValueChanged += new System.EventHandler(this.lookUpEditMaMon_EditValueChanged);
            // 
            // bdsMonhoc
            // 
            this.bdsMonhoc.DataMember = "MONHOC";
            this.bdsMonhoc.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MÃ MÔN";
            // 
            // lookUpEditMalop
            // 
            this.lookUpEditMalop.Location = new System.Drawing.Point(76, 80);
            this.lookUpEditMalop.Name = "lookUpEditMalop";
            this.lookUpEditMalop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMalop.Properties.DataSource = this.bdsLOP;
            this.lookUpEditMalop.Properties.DisplayMember = "MALOP";
            this.lookUpEditMalop.Properties.NullText = "Chọn mã lớp";
            this.lookUpEditMalop.Properties.ValueMember = "TENLOP";
            this.lookUpEditMalop.Size = new System.Drawing.Size(317, 20);
            this.lookUpEditMalop.TabIndex = 8;
            this.lookUpEditMalop.EditValueChanged += new System.EventHandler(this.lookUpEditMalop_EditValueChanged);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.DS;
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(76, 133);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Properties.ReadOnly = true;
            this.txtTenlop.Size = new System.Drawing.Size(317, 20);
            this.txtTenlop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÊN LỚP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MÃ LỚP";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Location = new System.Drawing.Point(9, 44);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(39, 14);
            this.lblTenKhoa.TabIndex = 3;
            this.lblTenKhoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(76, 41);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(317, 21);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.gridControlNhap);
            this.pnRight.Controls.Add(this.gridControlSua);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(437, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(549, 503);
            this.pnRight.TabIndex = 1;
            // 
            // gridControlNhap
            // 
            this.gridControlNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhap.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhap.MainView = this.gridViewnNhap;
            this.gridControlNhap.Name = "gridControlNhap";
            this.gridControlNhap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditNhap});
            this.gridControlNhap.Size = new System.Drawing.Size(549, 503);
            this.gridControlNhap.TabIndex = 0;
            this.gridControlNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewnNhap});
            // 
            // gridViewnNhap
            // 
            this.gridViewnNhap.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewnNhap.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewnNhap.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewnNhap.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewnNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoTen,
            this.colMASV,
            this.colDIEM});
            this.gridViewnNhap.GridControl = this.gridControlNhap;
            this.gridViewnNhap.Name = "gridViewnNhap";
            this.gridViewnNhap.OptionsView.ShowGroupPanel = false;
            this.gridViewnNhap.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewnNhap_RowCellStyle);
            this.gridViewnNhap.HiddenEditor += new System.EventHandler(this.gridViewnNhap_HiddenEditor);
            this.gridViewnNhap.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewnNhap_ValidatingEditor);
            // 
            // colHoTen
            // 
            this.colHoTen.AppearanceCell.Options.UseTextOptions = true;
            this.colHoTen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colHoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoTen.Caption = "Họ và Tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.ReadOnly = true;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Options.UseTextOptions = true;
            this.colMASV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMASV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 1;
            // 
            // colDIEM
            // 
            this.colDIEM.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM.Caption = "Điểm";
            this.colDIEM.ColumnEdit = this.repositoryItemTextEditNhap;
            this.colDIEM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            // 
            // repositoryItemTextEditNhap
            // 
            this.repositoryItemTextEditNhap.AutoHeight = false;
            this.repositoryItemTextEditNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditNhap.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditNhap.Mask.BeepOnError = true;
            this.repositoryItemTextEditNhap.Mask.EditMask = "f";
            this.repositoryItemTextEditNhap.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditNhap.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditNhap.MaxLength = 5;
            this.repositoryItemTextEditNhap.Name = "repositoryItemTextEditNhap";
            // 
            // gridControlSua
            // 
            this.gridControlSua.DataSource = this.bdsSP_BDMH;
            this.gridControlSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSua.Location = new System.Drawing.Point(0, 0);
            this.gridControlSua.MainView = this.gridViewSua;
            this.gridControlSua.Name = "gridControlSua";
            this.gridControlSua.Size = new System.Drawing.Size(549, 503);
            this.gridControlSua.TabIndex = 2;
            this.gridControlSua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSua});
            // 
            // bdsSP_BDMH
            // 
            this.bdsSP_BDMH.DataMember = "SP_BDMH";
            this.bdsSP_BDMH.DataSource = this.DS;
            // 
            // gridViewSua
            // 
            this.gridViewSua.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewSua.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewSua.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewSua.GridControl = this.gridControlSua;
            this.gridViewSua.Name = "gridViewSua";
            this.gridViewSua.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Họ và tên";
            this.gridColumn1.FieldName = "HoTen";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã sinh viên";
            this.gridColumn2.FieldName = "MASV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Điểm";
            this.gridColumn3.FieldName = "DIEM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
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
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // SP_BDMHTableAdapter
            // 
            this.SP_BDMHTableAdapter.ClearBeforeFill = true;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 503);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeftControl);
            this.Name = "frmDiem";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.pnLeftControl.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            this.grbDiem.ResumeLayout(false);
            this.grbDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLanThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).EndInit();
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewnNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_BDMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeftControl;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.GroupBox grbDiem;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblLanthi;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMaMon;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMalop;
        private DevExpress.XtraEditors.TextEdit txtTenlop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTenMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhap;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonhoc;
        private System.Windows.Forms.NumericUpDown numericLanThi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bdsSP_BDMH;
        private DSTableAdapters.SP_BDMHTableAdapter SP_BDMHTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewnNhap;
        private DevExpress.XtraGrid.GridControl gridControlSua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSua;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNhap;
    }
}