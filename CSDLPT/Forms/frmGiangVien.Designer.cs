namespace QLDSV.Forms
{
    partial class frmGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.barManagerGiangVien = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerGiangVien
            // 
            this.barManagerGiangVien.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManagerGiangVien.DockControls.Add(this.barDockControlTop);
            this.barManagerGiangVien.DockControls.Add(this.barDockControlBottom);
            this.barManagerGiangVien.DockControls.Add(this.barDockControlLeft);
            this.barManagerGiangVien.DockControls.Add(this.barDockControlRight);
            this.barManagerGiangVien.Form = this;
            this.barManagerGiangVien.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnAdd,
            this.barBtnDelete,
            this.barBtnUpdate,
            this.barBtnUndo,
            this.barBtnSave,
            this.barBtnCancel,
            this.barBtnRefresh,
            this.barBtnClose});
            this.barManagerGiangVien.MainMenu = this.bar2;
            this.barManagerGiangVien.MaxItemId = 8;
            this.barManagerGiangVien.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnAdd
            // 
            this.barBtnAdd.Caption = "Thêm";
            this.barBtnAdd.Id = 0;
            this.barBtnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnAdd.ImageOptions.SvgImage")));
            this.barBtnAdd.Name = "barBtnAdd";
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "Xóa";
            this.barBtnDelete.Id = 1;
            this.barBtnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDelete.ImageOptions.SvgImage")));
            this.barBtnDelete.Name = "barBtnDelete";
            // 
            // barBtnUpdate
            // 
            this.barBtnUpdate.Caption = "Sửa";
            this.barBtnUpdate.Id = 2;
            this.barBtnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUpdate.ImageOptions.SvgImage")));
            this.barBtnUpdate.Name = "barBtnUpdate";
            // 
            // barBtnUndo
            // 
            this.barBtnUndo.Caption = "Phục Hồi";
            this.barBtnUndo.Id = 3;
            this.barBtnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUndo.ImageOptions.SvgImage")));
            this.barBtnUndo.Name = "barBtnUndo";
            // 
            // barBtnSave
            // 
            this.barBtnSave.Caption = "Ghi";
            this.barBtnSave.Id = 4;
            this.barBtnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSave.ImageOptions.SvgImage")));
            this.barBtnSave.Name = "barBtnSave";
            // 
            // barBtnCancel
            // 
            this.barBtnCancel.Caption = "Hủy";
            this.barBtnCancel.Id = 5;
            this.barBtnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnCancel.ImageOptions.SvgImage")));
            this.barBtnCancel.Name = "barBtnCancel";
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Làm Mới";
            this.barBtnRefresh.Id = 6;
            this.barBtnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnRefresh.ImageOptions.SvgImage")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            // 
            // barBtnClose
            // 
            this.barBtnClose.Caption = "Đóng";
            this.barBtnClose.Id = 7;
            this.barBtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnClose.ImageOptions.SvgImage")));
            this.barBtnClose.Name = "barBtnClose";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerGiangVien;
            this.barDockControlTop.Size = new System.Drawing.Size(846, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Manager = this.barManagerGiangVien;
            this.barDockControlBottom.Size = new System.Drawing.Size(846, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Manager = this.barManagerGiangVien;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 353);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(846, 53);
            this.barDockControlRight.Manager = this.barManagerGiangVien;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 353);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 429);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerGiangVien;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnDelete;
        private DevExpress.XtraBars.BarButtonItem barBtnUpdate;
        private DevExpress.XtraBars.BarButtonItem barBtnUndo;
        private DevExpress.XtraBars.BarButtonItem barBtnSave;
        private DevExpress.XtraBars.BarButtonItem barBtnCancel;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarButtonItem barBtnClose;
    }
}