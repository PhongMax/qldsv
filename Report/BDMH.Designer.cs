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
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label_TenMonHoc = new System.Windows.Forms.Label();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.DS = new QLDSV.DS();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.label_LanThi = new System.Windows.Forms.Label();
            this.panelBDMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBDMH
            // 
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
            this.panelBDMH.Size = new System.Drawing.Size(838, 210);
            this.panelBDMH.TabIndex = 0;
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(315, 119);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(165, 23);
            this.button_Thoat.TabIndex = 11;
            this.button_Thoat.Text = "THOÁT";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_IN
            // 
            this.button_IN.Location = new System.Drawing.Point(135, 119);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(174, 23);
            this.button_IN.TabIndex = 10;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = true;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaLop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(492, 51);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 23);
            this.txtMaLop.TabIndex = 8;
            // 
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DataSource = this.bdsMONHOC;
            this.cmbTenMonHoc.DisplayMember = "TENMH";
            this.cmbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(135, 86);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(345, 21);
            this.cmbTenMonHoc.TabIndex = 6;
            this.cmbTenMonHoc.ValueMember = "MAMH";
            this.cmbTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbTenMonHoc_SelectedIndexChanged);
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(135, 51);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(345, 21);
            this.cmbTenLop.TabIndex = 5;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(135, 16);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(457, 21);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label_TenMonHoc
            // 
            this.label_TenMonHoc.AutoSize = true;
            this.label_TenMonHoc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenMonHoc.Location = new System.Drawing.Point(38, 91);
            this.label_TenMonHoc.Name = "label_TenMonHoc";
            this.label_TenMonHoc.Size = new System.Drawing.Size(84, 15);
            this.label_TenMonHoc.TabIndex = 2;
            this.label_TenMonHoc.Text = "TÊN MÔN HỌC";
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(38, 55);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(56, 15);
            this.label_TenLop.TabIndex = 1;
            this.label_TenLop.Text = "TÊN LỚP";
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(38, 19);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(35, 15);
            this.label_Khoa.TabIndex = 0;
            this.label_Khoa.Text = "KHOA";
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoa.Location = new System.Drawing.Point(141, 19);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(41, 13);
            this.labelKhoa.TabIndex = 12;
            this.labelKhoa.Text = "KHOA";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
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
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DS;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaMonHoc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(492, 87);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(100, 23);
            this.txtMaMonHoc.TabIndex = 13;
            // 
            // cmbLan
            // 
            this.cmbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(632, 87);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(38, 21);
            this.cmbLan.TabIndex = 14;
            // 
            // label_LanThi
            // 
            this.label_LanThi.AutoSize = true;
            this.label_LanThi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LanThi.Location = new System.Drawing.Point(598, 90);
            this.label_LanThi.Name = "label_LanThi";
            this.label_LanThi.Size = new System.Drawing.Size(28, 15);
            this.label_LanThi.TabIndex = 15;
            this.label_LanThi.Text = "LẦN";
            // 
            // BDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 487);
            this.Controls.Add(this.panelBDMH);
            this.Name = "BDMH";
            this.Text = "BDMH";
            this.Load += new System.EventHandler(this.BDMH_Load);
            this.panelBDMH.ResumeLayout(false);
            this.panelBDMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
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