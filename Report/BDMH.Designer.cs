namespace QLDSV.Report
{
    partial class BDMH
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
            this.panelBDMH = new System.Windows.Forms.Panel();
            this.label_LanThi = new System.Windows.Forms.Label();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label_TenMonHoc = new System.Windows.Forms.Label();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.MONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.panelBDMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBDMH
            // 
            this.panelBDMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBDMH.Controls.Add(this.label_LanThi);
            this.panelBDMH.Controls.Add(this.cmbLan);
            this.panelBDMH.Controls.Add(this.txtMaMonHoc);
            this.panelBDMH.Controls.Add(this.labelKhoa);
            this.panelBDMH.Controls.Add(this.button_Thoat);
            this.panelBDMH.Controls.Add(this.button_IN);
            this.panelBDMH.Controls.Add(this.txtMaLop);
            this.panelBDMH.Controls.Add(this.cmbTenMonHoc);
            this.panelBDMH.Controls.Add(this.cmbTenLop);
            this.panelBDMH.Controls.Add(this.cmbKhoa);
            this.panelBDMH.Controls.Add(this.label_TenMonHoc);
            this.panelBDMH.Controls.Add(this.label_TenLop);
            this.panelBDMH.Controls.Add(this.label_Khoa);
            this.panelBDMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBDMH.Location = new System.Drawing.Point(0, 0);
            this.panelBDMH.Name = "panelBDMH";
            this.panelBDMH.Size = new System.Drawing.Size(1049, 187);
            this.panelBDMH.TabIndex = 0;
            // 
            // label_LanThi
            // 
            this.label_LanThi.AutoSize = true;
            this.label_LanThi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LanThi.Location = new System.Drawing.Point(823, 97);
            this.label_LanThi.Name = "label_LanThi";
            this.label_LanThi.Size = new System.Drawing.Size(36, 19);
            this.label_LanThi.TabIndex = 15;
            this.label_LanThi.Text = "LẦN";
            // 
            // cmbLan
            // 
            this.cmbLan.BackColor = System.Drawing.Color.Gold;
            this.cmbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(865, 96);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(38, 21);
            this.cmbLan.TabIndex = 14;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaMonHoc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(717, 94);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(100, 26);
            this.txtMaMonHoc.TabIndex = 13;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoa.Location = new System.Drawing.Point(366, 26);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(41, 13);
            this.labelKhoa.TabIndex = 12;
            this.labelKhoa.Text = "KHOA";
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.LightCoral;
            this.button_Thoat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(632, 126);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(73, 37);
            this.button_Thoat.TabIndex = 11;
            this.button_Thoat.Text = "THOÁT";
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_IN
            // 
            this.button_IN.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(553, 126);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(73, 37);
            this.button_IN.TabIndex = 10;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(717, 58);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 26);
            this.txtMaLop.TabIndex = 8;
            // 
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DataSource = this.bdsMONHOC;
            this.cmbTenMonHoc.DisplayMember = "TENMH";
            this.cmbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMonHoc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(360, 93);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(345, 23);
            this.cmbTenMonHoc.TabIndex = 6;
            this.cmbTenMonHoc.ValueMember = "MAMH";
            this.cmbTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbTenMonHoc_SelectedIndexChanged);
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(360, 58);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(345, 23);
            this.cmbTenLop.TabIndex = 5;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.DS;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(360, 23);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(457, 23);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label_TenMonHoc
            // 
            this.label_TenMonHoc.AutoSize = true;
            this.label_TenMonHoc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenMonHoc.Location = new System.Drawing.Point(227, 93);
            this.label_TenMonHoc.Name = "label_TenMonHoc";
            this.label_TenMonHoc.Size = new System.Drawing.Size(108, 19);
            this.label_TenMonHoc.TabIndex = 2;
            this.label_TenMonHoc.Text = "TÊN MÔN HỌC";
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(227, 61);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(72, 19);
            this.label_TenLop.TabIndex = 1;
            this.label_TenLop.Text = "TÊN LỚP";
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(227, 23);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(45, 19);
            this.label_Khoa.TabIndex = 0;
            this.label_Khoa.Text = "KHOA";
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // BDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 487);
            this.Controls.Add(this.panelBDMH);
            this.Name = "BDMH";
            this.Text = "BẢNG ĐIỂM MÔN HỌC";
            this.Load += new System.EventHandler(this.BDMH_Load);
            this.panelBDMH.ResumeLayout(false);
            this.panelBDMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBDMH;
        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label_TenMonHoc;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_IN;
        private System.Windows.Forms.Label labelKhoa;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label_LanThi;
        private System.Windows.Forms.ComboBox cmbLan;
    }
}