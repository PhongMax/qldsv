namespace QLDSV.Forms
{
    partial class frmChuyenLop
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
            this.panel = new System.Windows.Forms.Panel();
            this.gbTTSinhVien = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditChuyenLop = new DevExpress.XtraEditors.LookUpEdit();
            this.SINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.button_Check = new System.Windows.Forms.Button();
            this.labelSupport = new System.Windows.Forms.Label();
            this.txtMaSVMoi = new System.Windows.Forms.TextBox();
            this.labelMaSVMoi = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.txtMaLopChuyenDen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.SINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTSinhVien)).BeginInit();
            this.gbTTSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChuyenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel.Controls.Add(this.gbTTSinhVien);
            this.panel.Controls.Add(this.labelKhoa);
            this.panel.Controls.Add(this.button_Check);
            this.panel.Controls.Add(this.labelSupport);
            this.panel.Controls.Add(this.txtMaSVMoi);
            this.panel.Controls.Add(this.labelMaSVMoi);
            this.panel.Controls.Add(this.buttonCancel);
            this.panel.Controls.Add(this.buttonOK);
            this.panel.Controls.Add(this.txtMaLopChuyenDen);
            this.panel.Controls.Add(this.txtMaSV);
            this.panel.Controls.Add(this.labelMaLop);
            this.panel.Controls.Add(this.labelMaSV);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1049, 355);
            this.panel.TabIndex = 0;
            // 
            // gbTTSinhVien
            // 
            this.gbTTSinhVien.Controls.Add(this.lookUpEditChuyenLop);
            this.gbTTSinhVien.Controls.Add(this.mAMHLabel);
            this.gbTTSinhVien.Controls.Add(this.txtMaLop);
            this.gbTTSinhVien.Controls.Add(this.label1);
            this.gbTTSinhVien.Controls.Add(this.tENMHLabel);
            this.gbTTSinhVien.Controls.Add(this.txtTenSV);
            this.gbTTSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTTSinhVien.Location = new System.Drawing.Point(0, 0);
            this.gbTTSinhVien.Name = "gbTTSinhVien";
            this.gbTTSinhVien.Size = new System.Drawing.Size(1049, 58);
            this.gbTTSinhVien.TabIndex = 12;
            this.gbTTSinhVien.Text = "Tìm Nhanh Sinh Viên";
            // 
            // lookUpEditChuyenLop
            // 
            this.lookUpEditChuyenLop.Location = new System.Drawing.Point(311, 28);
            this.lookUpEditChuyenLop.Name = "lookUpEditChuyenLop";
            this.lookUpEditChuyenLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditChuyenLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "Mã sinh viên")});
            this.lookUpEditChuyenLop.Properties.DataSource = this.SINHVIENBindingSource;
            this.lookUpEditChuyenLop.Properties.DisplayMember = "MASV";
            this.lookUpEditChuyenLop.Properties.NullText = "Nhâp mã sv...";
            this.lookUpEditChuyenLop.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lookUpEditChuyenLop.Properties.ValueMember = "MASV";
            this.lookUpEditChuyenLop.Size = new System.Drawing.Size(133, 20);
            this.lookUpEditChuyenLop.TabIndex = 1;
            this.lookUpEditChuyenLop.EditValueChanged += new System.EventHandler(this.lookUpEditChuyenLop_EditValueChanged);
            // 
            // SINHVIENBindingSource
            // 
            this.SINHVIENBindingSource.DataMember = "SINHVIEN";
            this.SINHVIENBindingSource.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAMHLabel.Location = new System.Drawing.Point(186, 31);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(119, 14);
            this.mAMHLabel.TabIndex = 0;
            this.mAMHLabel.Text = "Gõ Mã sinh viên:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(824, 28);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(114, 20);
            this.txtMaLop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(757, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã lớp:";
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENMHLabel.Location = new System.Drawing.Point(453, 32);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(105, 14);
            this.tENMHLabel.TabIndex = 2;
            this.tENMHLabel.Text = "Tên sinh viên:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(564, 28);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(187, 20);
            this.txtTenSV.TabIndex = 3;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoa.Location = new System.Drawing.Point(345, 80);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(45, 19);
            this.labelKhoa.TabIndex = 10;
            this.labelKhoa.Text = "KHOA";
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Check.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.Location = new System.Drawing.Point(594, 151);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(91, 26);
            this.button_Check.TabIndex = 9;
            this.button_Check.Text = "CHECK";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupport.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelSupport.Location = new System.Drawing.Point(345, 222);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(64, 18);
            this.labelSupport.TabIndex = 8;
            this.labelSupport.Text = "Support";
            // 
            // txtMaSVMoi
            // 
            this.txtMaSVMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSVMoi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSVMoi.Location = new System.Drawing.Point(348, 193);
            this.txtMaSVMoi.Name = "txtMaSVMoi";
            this.txtMaSVMoi.Size = new System.Drawing.Size(239, 26);
            this.txtMaSVMoi.TabIndex = 7;
            // 
            // labelMaSVMoi
            // 
            this.labelMaSVMoi.AutoSize = true;
            this.labelMaSVMoi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSVMoi.Location = new System.Drawing.Point(207, 196);
            this.labelMaSVMoi.Name = "labelMaSVMoi";
            this.labelMaSVMoi.Size = new System.Drawing.Size(136, 18);
            this.labelMaSVMoi.TabIndex = 6;
            this.labelMaSVMoi.Text = "Mã Sinh Viên Mới";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(473, 251);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 38);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "HỦY";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(348, 251);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(114, 38);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "XÁC NHẬN";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // txtMaLopChuyenDen
            // 
            this.txtMaLopChuyenDen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLopChuyenDen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLopChuyenDen.Location = new System.Drawing.Point(348, 151);
            this.txtMaLopChuyenDen.Name = "txtMaLopChuyenDen";
            this.txtMaLopChuyenDen.Size = new System.Drawing.Size(239, 26);
            this.txtMaLopChuyenDen.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(348, 108);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(239, 26);
            this.txtMaSV.TabIndex = 2;
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLop.Location = new System.Drawing.Point(207, 156);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(144, 18);
            this.labelMaLop.TabIndex = 1;
            this.labelMaLop.Text = "Mã Lớp Chuyển Đến";
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSV.Location = new System.Drawing.Point(207, 113);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(104, 18);
            this.labelMaSV.TabIndex = 0;
            this.labelMaSV.Text = "Mã Sinh Viên";
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 408);
            this.Controls.Add(this.panel);
            this.Name = "frmChuyenLop";
            this.Text = "Chuyển lớp";
            this.Load += new System.EventHandler(this.frmChuyenLop_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTSinhVien)).EndInit();
            this.gbTTSinhVien.ResumeLayout(false);
            this.gbTTSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChuyenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox txtMaLopChuyenDen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.TextBox txtMaSVMoi;
        private System.Windows.Forms.Label labelMaSVMoi;
        private System.Windows.Forms.Label labelSupport;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Label labelKhoa;
        private DevExpress.XtraEditors.GroupControl gbTTSinhVien;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditChuyenLop;
        private System.Windows.Forms.Label mAMHLabel;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tENMHLabel;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private DS DS;
        private System.Windows.Forms.BindingSource SINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
    }
}