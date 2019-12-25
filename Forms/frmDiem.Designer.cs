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
            this.pnLeftNhapDiem = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pnLeftNhapDiem.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // pnLeftNhapDiem
            // 
            this.pnLeftNhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnLeftNhapDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLeftNhapDiem.Controls.Add(this.button1);
            this.pnLeftNhapDiem.Controls.Add(this.grbControl);
            this.pnLeftNhapDiem.Controls.Add(this.grbDiem);
            this.pnLeftNhapDiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftNhapDiem.Location = new System.Drawing.Point(0, 0);
            this.pnLeftNhapDiem.Name = "pnLeftNhapDiem";
            this.pnLeftNhapDiem.Size = new System.Drawing.Size(437, 503);
            this.pnLeftNhapDiem.TabIndex = 0;
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
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(21, 62);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(79, 4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Start";
            this.btnNhap.UseVisualStyleBackColor = true;
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
            this.grbDiem.Size = new System.Drawing.Size(416, 307);
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
            this.lblTenKhoa.Click += new System.EventHandler(this.lblTenKhoa_Click);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(437, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 503);
            this.panel2.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enable Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnLeftNhapDiem);
            this.Name = "frmDiem";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.pnLeftNhapDiem.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeftNhapDiem;
        private System.Windows.Forms.Panel panel2;
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
    }
}