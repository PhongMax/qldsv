namespace QLDSV.Report
{
    partial class DSTHM
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
            this.label_Khoa = new System.Windows.Forms.Label();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_TenMonHoc = new System.Windows.Forms.Label();
            this.label_LanThi = new System.Windows.Forms.Label();
            this.label_NgayThi = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.panelDSTHM = new System.Windows.Forms.Panel();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.panelDSTHM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(132, 30);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(51, 17);
            this.label_Khoa.TabIndex = 0;
            this.label_Khoa.Text = "KHOA";
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(108, 68);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(75, 17);
            this.label_TenLop.TabIndex = 1;
            this.label_TenLop.Text = "TÊN LỚP";
            // 
            // label_TenMonHoc
            // 
            this.label_TenMonHoc.AutoSize = true;
            this.label_TenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenMonHoc.Location = new System.Drawing.Point(66, 106);
            this.label_TenMonHoc.Name = "label_TenMonHoc";
            this.label_TenMonHoc.Size = new System.Drawing.Size(117, 17);
            this.label_TenMonHoc.TabIndex = 2;
            this.label_TenMonHoc.Text = "TÊN MÔN HỌC";
            // 
            // label_LanThi
            // 
            this.label_LanThi.AutoSize = true;
            this.label_LanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LanThi.Location = new System.Drawing.Point(115, 145);
            this.label_LanThi.Name = "label_LanThi";
            this.label_LanThi.Size = new System.Drawing.Size(68, 17);
            this.label_LanThi.TabIndex = 3;
            this.label_LanThi.Text = "LẦN THI";
            // 
            // label_NgayThi
            // 
            this.label_NgayThi.AutoSize = true;
            this.label_NgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayThi.Location = new System.Drawing.Point(291, 141);
            this.label_NgayThi.Name = "label_NgayThi";
            this.label_NgayThi.Size = new System.Drawing.Size(81, 17);
            this.label_NgayThi.TabIndex = 4;
            this.label_NgayThi.Text = "NGÀY THI";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(209, 27);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(536, 24);
            this.cmbKhoa.TabIndex = 5;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(209, 65);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(393, 24);
            this.cmbTenLop.TabIndex = 6;
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
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(209, 103);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(393, 24);
            this.cmbTenMonHoc.TabIndex = 7;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(608, 65);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(137, 23);
            this.txtMaLop.TabIndex = 8;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(608, 104);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(137, 23);
            this.txtMaMonHoc.TabIndex = 9;
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Location = new System.Drawing.Point(209, 141);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(46, 24);
            this.cmbLanThi.TabIndex = 10;
            // 
            // panelDSTHM
            // 
            this.panelDSTHM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDSTHM.Controls.Add(this.labelKhoa);
            this.panelDSTHM.Controls.Add(this.button_Thoat);
            this.panelDSTHM.Controls.Add(this.button_IN);
            this.panelDSTHM.Controls.Add(this.dateTimePicker);
            this.panelDSTHM.Controls.Add(this.cmbLanThi);
            this.panelDSTHM.Controls.Add(this.txtMaMonHoc);
            this.panelDSTHM.Controls.Add(this.txtMaLop);
            this.panelDSTHM.Controls.Add(this.cmbTenMonHoc);
            this.panelDSTHM.Controls.Add(this.cmbTenLop);
            this.panelDSTHM.Controls.Add(this.cmbKhoa);
            this.panelDSTHM.Controls.Add(this.label_NgayThi);
            this.panelDSTHM.Controls.Add(this.label_LanThi);
            this.panelDSTHM.Controls.Add(this.label_TenMonHoc);
            this.panelDSTHM.Controls.Add(this.label_TenLop);
            this.panelDSTHM.Controls.Add(this.label_Khoa);
            this.panelDSTHM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDSTHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDSTHM.Location = new System.Drawing.Point(0, 0);
            this.panelDSTHM.Name = "panelDSTHM";
            this.panelDSTHM.Size = new System.Drawing.Size(807, 364);
            this.panelDSTHM.TabIndex = 0;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(209, 30);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(51, 17);
            this.labelKhoa.TabIndex = 14;
            this.labelKhoa.Text = "KHOA";
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(310, 187);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(95, 35);
            this.button_Thoat.TabIndex = 13;
            this.button_Thoat.Text = "THOÁT";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_IN
            // 
            this.button_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(209, 187);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(95, 35);
            this.button_IN.TabIndex = 12;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = true;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(378, 141);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // DSTHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 436);
            this.Controls.Add(this.panelDSTHM);
            this.Name = "DSTHM";
            this.Text = "DSTHM";
            this.Load += new System.EventHandler(this.DSTHM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.panelDSTHM.ResumeLayout(false);
            this.panelDSTHM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.Label label_TenMonHoc;
        private System.Windows.Forms.Label label_LanThi;
        private System.Windows.Forms.Label label_NgayThi;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.Panel panelDSTHM;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_IN;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Label labelKhoa;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
    }
}