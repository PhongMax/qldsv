namespace QLDSV.Report
{
    partial class DSSV
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
            this.panelDSSV = new System.Windows.Forms.Panel();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.button_THOAT = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.label_MaLop = new System.Windows.Forms.Label();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.panelDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDSSV
            // 
            this.panelDSSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDSSV.Controls.Add(this.labelKhoa);
            this.panelDSSV.Controls.Add(this.txtMaLop);
            this.panelDSSV.Controls.Add(this.button_THOAT);
            this.panelDSSV.Controls.Add(this.button_IN);
            this.panelDSSV.Controls.Add(this.label_MaLop);
            this.panelDSSV.Controls.Add(this.cmbTenLop);
            this.panelDSSV.Controls.Add(this.label_TenLop);
            this.panelDSSV.Controls.Add(this.cmbKhoa);
            this.panelDSSV.Controls.Add(this.label_Khoa);
            this.panelDSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDSSV.Location = new System.Drawing.Point(0, 0);
            this.panelDSSV.Name = "panelDSSV";
            this.panelDSSV.Size = new System.Drawing.Size(839, 174);
            this.panelDSSV.TabIndex = 0;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoa.Location = new System.Drawing.Point(339, 24);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(45, 19);
            this.labelKhoa.TabIndex = 9;
            this.labelKhoa.Text = "KHOA";
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txtMaLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(339, 85);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(324, 26);
            this.txtMaLop.TabIndex = 8;
            // 
            // button_THOAT
            // 
            this.button_THOAT.BackColor = System.Drawing.Color.LightCoral;
            this.button_THOAT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THOAT.Location = new System.Drawing.Point(588, 120);
            this.button_THOAT.Name = "button_THOAT";
            this.button_THOAT.Size = new System.Drawing.Size(75, 36);
            this.button_THOAT.TabIndex = 7;
            this.button_THOAT.Text = "THOÁT";
            this.button_THOAT.UseVisualStyleBackColor = false;
            this.button_THOAT.Click += new System.EventHandler(this.button_THOAT_Click);
            // 
            // button_IN
            // 
            this.button_IN.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(507, 120);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(75, 36);
            this.button_IN.TabIndex = 6;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // label_MaLop
            // 
            this.label_MaLop.AutoSize = true;
            this.label_MaLop.BackColor = System.Drawing.Color.White;
            this.label_MaLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaLop.Location = new System.Drawing.Point(267, 87);
            this.label_MaLop.Name = "label_MaLop";
            this.label_MaLop.Size = new System.Drawing.Size(63, 19);
            this.label_MaLop.TabIndex = 4;
            this.label_MaLop.Text = "MÃ LỚP";
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(339, 56);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(324, 23);
            this.cmbTenLop.TabIndex = 3;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.BackColor = System.Drawing.Color.White;
            this.label_TenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(258, 55);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(72, 19);
            this.label_TenLop.TabIndex = 2;
            this.label_TenLop.Text = "TÊN LỚP";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(339, 21);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(324, 23);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.BackColor = System.Drawing.Color.White;
            this.label_Khoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(285, 24);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(45, 19);
            this.label_Khoa.TabIndex = 0;
            this.label_Khoa.Text = "KHOA";
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // DSSV
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 434);
            this.Controls.Add(this.panelDSSV);
            this.Name = "DSSV";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.DSSV_Load);
            this.panelDSSV.ResumeLayout(false);
            this.panelDSSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDSSV;
        private System.Windows.Forms.Label label_MaLop;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.Button button_THOAT;
        private System.Windows.Forms.Button button_IN;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label labelKhoa;
    }
}