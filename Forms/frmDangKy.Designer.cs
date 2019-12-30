namespace QLDSV.Forms
{
    partial class frmDangKy
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
            this.grbDangKy = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rdoPGV = new System.Windows.Forms.RadioButton();
            this.rdoKhoa = new System.Windows.Forms.RadioButton();
            this.rdoPKeToan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lookUpUser = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.txtConfirm = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.DSGVTableAdapter = new QLDSV.DSTableAdapters.GETDSGVTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDangKy.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDangKy
            // 
            this.grbDangKy.Controls.Add(this.panel1);
            this.grbDangKy.Controls.Add(this.lblTrangThai);
            this.grbDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDangKy.Location = new System.Drawing.Point(0, 0);
            this.grbDangKy.Name = "grbDangKy";
            this.grbDangKy.Size = new System.Drawing.Size(1024, 580);
            this.grbDangKy.TabIndex = 0;
            this.grbDangKy.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.lookUpUser);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.chkShowPass);
            this.panel1.Controls.Add(this.txtConfirm);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblConfirm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Location = new System.Drawing.Point(477, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 425);
            this.panel1.TabIndex = 24;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rdoPGV);
            this.panelControl1.Controls.Add(this.rdoKhoa);
            this.panelControl1.Controls.Add(this.rdoPKeToan);
            this.panelControl1.Location = new System.Drawing.Point(90, 279);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(203, 50);
            this.panelControl1.TabIndex = 23;
            // 
            // rdoPGV
            // 
            this.rdoPGV.AutoSize = true;
            this.rdoPGV.Location = new System.Drawing.Point(15, 19);
            this.rdoPGV.Name = "rdoPGV";
            this.rdoPGV.Size = new System.Drawing.Size(47, 17);
            this.rdoPGV.TabIndex = 4;
            this.rdoPGV.TabStop = true;
            this.rdoPGV.Text = "PGV";
            this.rdoPGV.UseVisualStyleBackColor = true;
            // 
            // rdoKhoa
            // 
            this.rdoKhoa.AutoSize = true;
            this.rdoKhoa.Location = new System.Drawing.Point(68, 19);
            this.rdoKhoa.Name = "rdoKhoa";
            this.rdoKhoa.Size = new System.Drawing.Size(50, 17);
            this.rdoKhoa.TabIndex = 5;
            this.rdoKhoa.TabStop = true;
            this.rdoKhoa.Text = "Khoa";
            this.rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // rdoPKeToan
            // 
            this.rdoPKeToan.AutoSize = true;
            this.rdoPKeToan.Location = new System.Drawing.Point(126, 19);
            this.rdoPKeToan.Name = "rdoPKeToan";
            this.rdoPKeToan.Size = new System.Drawing.Size(70, 17);
            this.rdoPKeToan.TabIndex = 6;
            this.rdoPKeToan.TabStop = true;
            this.rdoPKeToan.Text = "PKeToan";
            this.rdoPKeToan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Image = global::QLDSV.Properties.Resources.clipboard__1_;
            this.label5.Location = new System.Drawing.Point(131, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 134);
            this.label5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DimGray;
            this.btnHuy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(189, 386);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(167, 39);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lookUpUser
            // 
            this.lookUpUser.Location = new System.Drawing.Point(90, 246);
            this.lookUpUser.Name = "lookUpUser";
            this.lookUpUser.Properties.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.lookUpUser.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUser.Properties.DataSource = this.bdsDSGV;
            this.lookUpUser.Properties.DisplayMember = "MAGV";
            this.lookUpUser.Properties.DropDownRows = 10;
            this.lookUpUser.Properties.NullText = "Chọn mã giảng viên";
            this.lookUpUser.Properties.ValueMember = "MAGV";
            this.lookUpUser.Size = new System.Drawing.Size(201, 20);
            this.lookUpUser.TabIndex = 3;
            // 
            // bdsDSGV
            // 
            this.bdsDSGV.DataMember = "GETDSGV";
            this.bdsDSGV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangKy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(0, 386);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(166, 39);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(298, 219);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(51, 17);
            this.chkShowPass.TabIndex = 9;
            this.chkShowPass.Text = "show";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(90, 216);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirm.Properties.Appearance.Options.UseBackColor = true;
            this.txtConfirm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtConfirm.Properties.MaxLength = 25;
            this.txtConfirm.Properties.UseSystemPasswordChar = true;
            this.txtConfirm.Size = new System.Drawing.Size(201, 20);
            this.txtConfirm.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(90, 161);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.Properties.Appearance.Options.UseBackColor = true;
            this.txtLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtLogin.Properties.MaxLength = 25;
            this.txtLogin.Size = new System.Drawing.Size(201, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giảng Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Role";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(5, 218);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(56, 15);
            this.lblConfirm.TabIndex = 22;
            this.lblConfirm.Text = "Confirm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(90, 190);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.Properties.Appearance.Options.UseBackColor = true;
            this.txtPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtPass.Properties.MaxLength = 25;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(201, 20);
            this.txtPass.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(696, 354);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 13);
            this.lblTrangThai.TabIndex = 23;
            // 
            // DSGVTableAdapter
            // 
            this.DSGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THONGTINHOCPHICUASINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 580);
            this.Controls.Add(this.grbDangKy);
            this.Name = "frmDangKy";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmĐangKy_Load);
            this.Enter += new System.EventHandler(this.frmĐangKy_Load);
            this.grbDangKy.ResumeLayout(false);
            this.grbDangKy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoPKeToan;
        private System.Windows.Forms.RadioButton rdoKhoa;
        private System.Windows.Forms.RadioButton rdoPGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private System.Windows.Forms.Button btnDangKy;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private System.Windows.Forms.Button btnHuy;
        private DevExpress.XtraEditors.LookUpEdit lookUpUser;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDSGV;
        private DSTableAdapters.GETDSGVTableAdapter DSGVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}