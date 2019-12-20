namespace QLDSV
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Lop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButton_Lop = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup_MonHoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButton_MonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButton_SinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup_Diem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_GiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMAGV,
            this.lblHOTEN,
            this.lblNHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMAGV
            // 
            this.lblMAGV.Name = "lblMAGV";
            this.lblMAGV.Size = new System.Drawing.Size(41, 17);
            this.lblMAGV.Text = "MAGV";
            // 
            // lblHOTEN
            // 
            this.lblHOTEN.Name = "lblHOTEN";
            this.lblHOTEN.Size = new System.Drawing.Size(46, 17);
            this.lblHOTEN.Text = "HOTEN";
            // 
            // lblNHOM
            // 
            this.lblNHOM.Name = "lblNHOM";
            this.lblNHOM.Size = new System.Drawing.Size(45, 17);
            this.lblNHOM.Text = "NHOM";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Lop,
            this.ribbonPageGroup_MonHoc,
            this.ribbonPageGroup1,
            this.ribbonPageGroup_Diem});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup_Lop
            // 
            this.ribbonPageGroup_Lop.ItemLinks.Add(this.barButton_Lop);
            this.ribbonPageGroup_Lop.Name = "ribbonPageGroup_Lop";
            this.ribbonPageGroup_Lop.Text = "LỚP";
            // 
            // barButton_Lop
            // 
            this.barButton_Lop.Id = 4;
            this.barButton_Lop.ImageOptions.Image = global::QLDSV.Properties.Resources._class;
            this.barButton_Lop.LargeWidth = 100;
            this.barButton_Lop.Name = "barButton_Lop";
            this.barButton_Lop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButton_Lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_Lop_ItemClick);
            // 
            // ribbonPageGroup_MonHoc
            // 
            this.ribbonPageGroup_MonHoc.ImageOptions.Image = global::QLDSV.Properties.Resources.bright;
            this.ribbonPageGroup_MonHoc.ItemLinks.Add(this.barButton_MonHoc);
            this.ribbonPageGroup_MonHoc.KeyTip = "MÔN HỌC";
            this.ribbonPageGroup_MonHoc.Name = "ribbonPageGroup_MonHoc";
            this.ribbonPageGroup_MonHoc.Text = "MÔN HỌC";
            // 
            // barButton_MonHoc
            // 
            this.barButton_MonHoc.Id = 7;
            this.barButton_MonHoc.ImageOptions.Image = global::QLDSV.Properties.Resources.bright;
            this.barButton_MonHoc.LargeWidth = 100;
            this.barButton_MonHoc.Name = "barButton_MonHoc";
            this.barButton_MonHoc.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButton_SinhVien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "SINH VIÊN";
            // 
            // barButton_SinhVien
            // 
            this.barButton_SinhVien.Id = 9;
            this.barButton_SinhVien.ImageOptions.Image = global::QLDSV.Properties.Resources.students;
            this.barButton_SinhVien.LargeWidth = 100;
            this.barButton_SinhVien.Name = "barButton_SinhVien";
            this.barButton_SinhVien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.barButton_SinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_SinhVien_ItemClick);
            // 
            // ribbonPageGroup_Diem
            // 
            this.ribbonPageGroup_Diem.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup_Diem.Name = "ribbonPageGroup_Diem";
            this.ribbonPageGroup_Diem.Text = "ĐIỂM";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = global::QLDSV.Properties.Resources.score;
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            // 
            // barButtonItem_Thoat
            // 
            this.barButtonItem_Thoat.Id = 11;
            this.barButtonItem_Thoat.ImageOptions.Image = global::QLDSV.Properties.Resources.power_button;
            this.barButtonItem_Thoat.LargeWidth = 80;
            this.barButtonItem_Thoat.Name = "barButtonItem_Thoat";
            this.barButtonItem_Thoat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.barButtonItem_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Thoat_ItemClick);
            // 
            // barButton_GiangVien
            // 
            this.barButton_GiangVien.Id = 8;
            this.barButton_GiangVien.ImageOptions.Image = global::QLDSV.Properties.Resources.conference;
            this.barButton_GiangVien.LargeWidth = 80;
            this.barButton_GiangVien.Name = "barButton_GiangVien";
            this.barButton_GiangVien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Môn Học";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.Image = global::QLDSV.Properties.Resources.books__1_;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Giảng Viên";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageOptions.Image = global::QLDSV.Properties.Resources.conference;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnTaoTaiKhoan,
            this.barBtnDangXuat,
            this.barButton_Lop,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButton_MonHoc,
            this.barButton_GiangVien,
            this.barButton_SinhVien,
            this.barButtonItem1,
            this.barButtonItem_Thoat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1011, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barBtnTaoTaiKhoan
            // 
            this.barBtnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.barBtnTaoTaiKhoan.Id = 2;
            this.barBtnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.barBtnTaoTaiKhoan.LargeWidth = 80;
            this.barBtnTaoTaiKhoan.Name = "barBtnTaoTaiKhoan";
            this.barBtnTaoTaiKhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.barBtnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaoTaiKhoan_ItemClick);
            // 
            // barBtnDangXuat
            // 
            this.barBtnDangXuat.Caption = "Đăng xuất";
            this.barBtnDangXuat.Id = 3;
            this.barBtnDangXuat.ImageOptions.Image = global::QLDSV.Properties.Resources.turn_off_32;
            this.barBtnDangXuat.LargeWidth = 80;
            this.barBtnDangXuat.Name = "barBtnDangXuat";
            this.barBtnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDangXuat_ItemClick);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Cấu hình";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnTaoTaiKhoan);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnDangXuat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hệ thống";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeftLayout = true;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblNHOM;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Lop;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_MonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barBtnDangXuat;
        private DevExpress.XtraBars.BarButtonItem barButton_Lop;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButton_MonHoc;
        private DevExpress.XtraBars.BarButtonItem barButton_GiangVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButton_SinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Diem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Thoat;
        public System.Windows.Forms.ToolStripStatusLabel lblMAGV;
        public System.Windows.Forms.ToolStripStatusLabel lblHOTEN;
    }
}

