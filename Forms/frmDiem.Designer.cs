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
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
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
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridViewDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHuy = new DevExpress.XtraGrid.GridControl();
            this.groupControlNhapDiem = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLanThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhapDiem)).BeginInit();
            this.groupControlNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // numericLanThi
            // 
            this.numericLanThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLanThi.Location = new System.Drawing.Point(91, 126);
            this.numericLanThi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericLanThi.Minimum = new decimal(new int[] {
            1,
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
            this.txtTenMon.Location = new System.Drawing.Point(571, 99);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Properties.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(398, 20);
            this.txtTenMon.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "TÊN MÔN";
            // 
            // lblLanthi
            // 
            this.lblLanthi.AutoSize = true;
            this.lblLanthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanthi.Location = new System.Drawing.Point(24, 131);
            this.lblLanthi.Name = "lblLanthi";
            this.lblLanthi.Size = new System.Drawing.Size(49, 13);
            this.lblLanthi.TabIndex = 11;
            this.lblLanthi.Text = "LẦN THI";
            // 
            // lookUpEditMaMon
            // 
            this.lookUpEditMaMon.Location = new System.Drawing.Point(91, 100);
            this.lookUpEditMaMon.Name = "lookUpEditMaMon";
            this.lookUpEditMaMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMaMon.Properties.DataSource = this.bdsMonhoc;
            this.lookUpEditMaMon.Properties.DisplayMember = "TENMH";
            this.lookUpEditMaMon.Properties.NullText = "Hãy chọn môn học";
            this.lookUpEditMaMon.Properties.ValueMember = "MAMH";
            this.lookUpEditMaMon.Size = new System.Drawing.Size(398, 20);
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
            this.label3.Location = new System.Drawing.Point(504, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MÃ MÔN";
            // 
            // lookUpEditMalop
            // 
            this.lookUpEditMalop.Location = new System.Drawing.Point(91, 67);
            this.lookUpEditMalop.Name = "lookUpEditMalop";
            this.lookUpEditMalop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMalop.Properties.DataSource = this.bdsLOP;
            this.lookUpEditMalop.Properties.DisplayMember = "TENLOP";
            this.lookUpEditMalop.Properties.NullText = "Hãy chọn lớp";
            this.lookUpEditMalop.Properties.ValueMember = "MALOP";
            this.lookUpEditMalop.Size = new System.Drawing.Size(398, 20);
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
            this.txtTenlop.Location = new System.Drawing.Point(570, 66);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Properties.ReadOnly = true;
            this.txtTenlop.Size = new System.Drawing.Size(398, 20);
            this.txtTenlop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÊN LỚP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MÃ LỚP";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Location = new System.Drawing.Point(24, 39);
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
            this.cmbKhoa.Location = new System.Drawing.Point(91, 32);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(398, 21);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
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
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THONGTINHOCPHICUASINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.btnHuy;
            this.gridView1.Name = "gridView1";
            // 
            // gridViewDiem
            // 
            this.gridViewDiem.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewDiem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDiem.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewDiem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoTen,
            this.colMASV,
            this.colDIEM});
            this.gridViewDiem.GridControl = this.btnHuy;
            this.gridViewDiem.Name = "gridViewDiem";
            this.gridViewDiem.OptionsView.ShowGroupPanel = false;
            this.gridViewDiem.OptionsView.ShowViewCaption = true;
            this.gridViewDiem.ViewCaption = "BẢNG ĐIỂM MÔN HỌC";
            this.gridViewDiem.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewDiem_CustomDrawRowIndicator);
            this.gridViewDiem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewnNhap_RowCellStyle);
            this.gridViewDiem.HiddenEditor += new System.EventHandler(this.gridViewnNhap_HiddenEditor);
            this.gridViewDiem.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewnNhap_ValidatingEditor);
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
            repositoryItemTextEdit3.AutoHeight = false;
            repositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositoryItemTextEdit3.Mask.BeepOnError = true;
            repositoryItemTextEdit3.Mask.EditMask = "f";
            repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            repositoryItemTextEdit3.MaxLength = 5;
            repositoryItemTextEdit3.Name = "repositoryItemTextEditNhap";
            this.colDIEM.ColumnEdit = repositoryItemTextEdit3;
            this.colDIEM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.Location = new System.Drawing.Point(0, 0);
            this.btnHuy.MainView = this.gridViewDiem;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(986, 273);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiem,
            this.gridView1});
            // 
            // groupControlNhapDiem
            // 
            this.groupControlNhapDiem.Controls.Add(this.numericLanThi);
            this.groupControlNhapDiem.Controls.Add(this.lblLanthi);
            this.groupControlNhapDiem.Controls.Add(this.cmbKhoa);
            this.groupControlNhapDiem.Controls.Add(this.txtTenMon);
            this.groupControlNhapDiem.Controls.Add(this.lblTenKhoa);
            this.groupControlNhapDiem.Controls.Add(this.label3);
            this.groupControlNhapDiem.Controls.Add(this.label5);
            this.groupControlNhapDiem.Controls.Add(this.lookUpEditMalop);
            this.groupControlNhapDiem.Controls.Add(this.label2);
            this.groupControlNhapDiem.Controls.Add(this.lookUpEditMaMon);
            this.groupControlNhapDiem.Controls.Add(this.txtTenlop);
            this.groupControlNhapDiem.Controls.Add(this.label1);
            this.groupControlNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlNhapDiem.Location = new System.Drawing.Point(0, 0);
            this.groupControlNhapDiem.Name = "groupControlNhapDiem";
            this.groupControlNhapDiem.Size = new System.Drawing.Size(986, 161);
            this.groupControlNhapDiem.TabIndex = 1;
            this.groupControlNhapDiem.Text = "Thông tin";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.btnNhap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(986, 69);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Điều khiển";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 37);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(66, 23);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Bắt đầu";
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(110, 37);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Cập nhật";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(213, 37);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 230);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 273);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupControlNhapDiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 161);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 69);
            this.panel4.TabIndex = 1;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDiem";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLanThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhapDiem)).EndInit();
            this.groupControlNhapDiem.ResumeLayout(false);
            this.groupControlNhapDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonhoc;
        private System.Windows.Forms.NumericUpDown numericLanThi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraGrid.GridControl btnHuy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlNhapDiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnNhap;
        private System.Windows.Forms.Panel panel3;
    }
}