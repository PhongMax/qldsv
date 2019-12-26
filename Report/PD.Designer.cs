namespace QLDSV.Report
{
    partial class PD
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
            this.panelPD = new System.Windows.Forms.Panel();
            this.cmbTenSinhVien = new System.Windows.Forms.ComboBox();
            this.bdsSINHVIENFK = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.button_THOAT = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.btnSelectSinhVien = new System.Windows.Forms.Button();
            this.panelPD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIENFK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPD
            // 
            this.panelPD.Controls.Add(this.btnSelectSinhVien);
            this.panelPD.Controls.Add(this.cmbTenSinhVien);
            this.panelPD.Controls.Add(this.labelKhoa);
            this.panelPD.Controls.Add(this.button_THOAT);
            this.panelPD.Controls.Add(this.button_IN);
            this.panelPD.Controls.Add(this.labelMaSV);
            this.panelPD.Controls.Add(this.txtMaSV);
            this.panelPD.Controls.Add(this.label_TenLop);
            this.panelPD.Controls.Add(this.label_Khoa);
            this.panelPD.Controls.Add(this.cmbTenLop);
            this.panelPD.Controls.Add(this.cmbKhoa);
            this.panelPD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPD.Location = new System.Drawing.Point(0, 0);
            this.panelPD.Name = "panelPD";
            this.panelPD.Size = new System.Drawing.Size(802, 163);
            this.panelPD.TabIndex = 0;
            // 
            // cmbTenSinhVien
            // 
            this.cmbTenSinhVien.DataSource = this.bdsSINHVIENFK;
            this.cmbTenSinhVien.DisplayMember = "TEN";
            this.cmbTenSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenSinhVien.FormattingEnabled = true;
            this.cmbTenSinhVien.Location = new System.Drawing.Point(344, 91);
            this.cmbTenSinhVien.Name = "cmbTenSinhVien";
            this.cmbTenSinhVien.Size = new System.Drawing.Size(169, 21);
            this.cmbTenSinhVien.TabIndex = 9;
            this.cmbTenSinhVien.ValueMember = "MASV";
            this.cmbTenSinhVien.SelectedIndexChanged += new System.EventHandler(this.cmbTenSinhVien_SelectedIndexChanged);
            // 
            // bdsSINHVIENFK
            // 
            this.bdsSINHVIENFK.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSINHVIENFK.DataSource = this.bdsLOP;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoa.Location = new System.Drawing.Point(156, 15);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(45, 19);
            this.labelKhoa.TabIndex = 8;
            this.labelKhoa.Text = "KHOA";
            // 
            // button_THOAT
            // 
            this.button_THOAT.Location = new System.Drawing.Point(253, 128);
            this.button_THOAT.Name = "button_THOAT";
            this.button_THOAT.Size = new System.Drawing.Size(75, 23);
            this.button_THOAT.TabIndex = 7;
            this.button_THOAT.Text = "THOÁT";
            this.button_THOAT.UseVisualStyleBackColor = true;
            this.button_THOAT.Click += new System.EventHandler(this.button_THOAT_Click);
            // 
            // button_IN
            // 
            this.button_IN.Location = new System.Drawing.Point(160, 128);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(75, 23);
            this.button_IN.TabIndex = 6;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = true;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSV.Location = new System.Drawing.Point(31, 94);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(117, 19);
            this.labelMaSV.TabIndex = 5;
            this.labelMaSV.Text = "MÃ SINH VIÊN";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(160, 91);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(168, 23);
            this.txtMaSV.TabIndex = 4;
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(31, 56);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(72, 19);
            this.label_TenLop.TabIndex = 3;
            this.label_TenLop.Text = "TÊN LỚP";
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(31, 18);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(45, 19);
            this.label_Khoa.TabIndex = 2;
            this.label_Khoa.Text = "KHOA";
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(160, 53);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(353, 21);
            this.cmbTenLop.TabIndex = 1;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(160, 15);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(353, 21);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // btnSelectSinhVien
            // 
            this.btnSelectSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelectSinhVien.Location = new System.Drawing.Point(344, 128);
            this.btnSelectSinhVien.Name = "btnSelectSinhVien";
            this.btnSelectSinhVien.Size = new System.Drawing.Size(169, 23);
            this.btnSelectSinhVien.TabIndex = 10;
            this.btnSelectSinhVien.Text = "CHỌN THEO TÊN";
            this.btnSelectSinhVien.UseVisualStyleBackColor = false;
            this.btnSelectSinhVien.Click += new System.EventHandler(this.btnSelectSinhVien_Click);
            // 
            // PD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 474);
            this.Controls.Add(this.panelPD);
            this.Name = "PD";
            this.Text = "PHIẾU ĐIỂM";
            this.Load += new System.EventHandler(this.PD_Load);
            this.panelPD.ResumeLayout(false);
            this.panelPD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIENFK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPD;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button button_THOAT;
        private System.Windows.Forms.Button button_IN;
        private System.Windows.Forms.Label labelKhoa;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenSinhVien;
        private System.Windows.Forms.BindingSource bdsSINHVIENFK;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Button btnSelectSinhVien;
    }
}