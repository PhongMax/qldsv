﻿namespace QLDSV.Report
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
            this.label_NgayThi = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.panelDSTHM = new System.Windows.Forms.Panel();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.MONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panelDSTHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khoa.Location = new System.Drawing.Point(228, 29);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(45, 19);
            this.label_Khoa.TabIndex = 0;
            this.label_Khoa.Text = "KHOA";
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(228, 65);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(72, 19);
            this.label_TenLop.TabIndex = 1;
            this.label_TenLop.Text = "TÊN LỚP";
            // 
            // label_TenMonHoc
            // 
            this.label_TenMonHoc.AutoSize = true;
            this.label_TenMonHoc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenMonHoc.Location = new System.Drawing.Point(228, 106);
            this.label_TenMonHoc.Name = "label_TenMonHoc";
            this.label_TenMonHoc.Size = new System.Drawing.Size(108, 19);
            this.label_TenMonHoc.TabIndex = 2;
            this.label_TenMonHoc.Text = "TÊN MÔN HỌC";
            // 
            // label_NgayThi
            // 
            this.label_NgayThi.AutoSize = true;
            this.label_NgayThi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayThi.Location = new System.Drawing.Point(228, 147);
            this.label_NgayThi.Name = "label_NgayThi";
            this.label_NgayThi.Size = new System.Drawing.Size(81, 19);
            this.label_NgayThi.TabIndex = 4;
            this.label_NgayThi.Text = "NGÀY THI";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(344, 29);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(536, 23);
            this.cmbKhoa.TabIndex = 5;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(344, 67);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(393, 23);
            this.cmbTenLop.TabIndex = 6;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(743, 65);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(137, 26);
            this.txtMaLop.TabIndex = 8;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(743, 102);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(137, 26);
            this.txtMaMonHoc.TabIndex = 9;
            // 
            // panelDSTHM
            // 
            this.panelDSTHM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDSTHM.Controls.Add(this.labelKhoa);
            this.panelDSTHM.Controls.Add(this.button_Thoat);
            this.panelDSTHM.Controls.Add(this.button_IN);
            this.panelDSTHM.Controls.Add(this.dateTimePicker);
            this.panelDSTHM.Controls.Add(this.txtMaMonHoc);
            this.panelDSTHM.Controls.Add(this.txtMaLop);
            this.panelDSTHM.Controls.Add(this.cmbTenMonHoc);
            this.panelDSTHM.Controls.Add(this.cmbTenLop);
            this.panelDSTHM.Controls.Add(this.cmbKhoa);
            this.panelDSTHM.Controls.Add(this.label_NgayThi);
            this.panelDSTHM.Controls.Add(this.label_TenMonHoc);
            this.panelDSTHM.Controls.Add(this.label_TenLop);
            this.panelDSTHM.Controls.Add(this.label_Khoa);
            this.panelDSTHM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDSTHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDSTHM.Location = new System.Drawing.Point(0, 0);
            this.panelDSTHM.Name = "panelDSTHM";
            this.panelDSTHM.Size = new System.Drawing.Size(1082, 244);
            this.panelDSTHM.TabIndex = 0;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoa.Location = new System.Drawing.Point(344, 32);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(45, 19);
            this.labelKhoa.TabIndex = 14;
            this.labelKhoa.Text = "KHOA";
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.LightCoral;
            this.button_Thoat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(423, 185);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(73, 35);
            this.button_Thoat.TabIndex = 13;
            this.button_Thoat.Text = "THOÁT";
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_IN
            // 
            this.button_IN.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(344, 185);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(73, 35);
            this.button_IN.TabIndex = 12;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(344, 147);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(393, 23);
            this.dateTimePicker.TabIndex = 11;
            // 
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DataSource = this.bdsMONHOC;
            this.cmbTenMonHoc.DisplayMember = "TENMH";
            this.cmbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMonHoc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(344, 105);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(393, 23);
            this.cmbTenMonHoc.TabIndex = 7;
            this.cmbTenMonHoc.ValueMember = "MAMH";
            this.cmbTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbTenMonHoc_SelectedIndexChanged);
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DS;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // DSTHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 436);
            this.Controls.Add(this.panelDSTHM);
            this.Name = "DSTHM";
            this.Text = "DANH SÁCH THI HẾT MÔN";
            this.Load += new System.EventHandler(this.DSTHM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panelDSTHM.ResumeLayout(false);
            this.panelDSTHM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.Label label_TenMonHoc;
        private System.Windows.Forms.Label label_NgayThi;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Panel panelDSTHM;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_IN;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Label labelKhoa;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
    }
}