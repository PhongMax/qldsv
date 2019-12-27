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
            this.panel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.txtMaLopChuyenDen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel.Controls.Add(this.buttonCancel);
            this.panel.Controls.Add(this.buttonOK);
            this.panel.Controls.Add(this.txtMaLopChuyenDen);
            this.panel.Controls.Add(this.txtMaSV);
            this.panel.Controls.Add(this.labelMaLop);
            this.panel.Controls.Add(this.labelMaSV);
            this.panel.Location = new System.Drawing.Point(115, 34);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(389, 349);
            this.panel.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(189, 311);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 38);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "HỦY";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(0, 311);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(183, 38);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "XÁC NHẬN";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // txtMaLopChuyenDen
            // 
            this.txtMaLopChuyenDen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLopChuyenDen.Location = new System.Drawing.Point(133, 117);
            this.txtMaLopChuyenDen.Name = "txtMaLopChuyenDen";
            this.txtMaLopChuyenDen.Size = new System.Drawing.Size(239, 20);
            this.txtMaLopChuyenDen.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSV.Location = new System.Drawing.Point(133, 83);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(239, 20);
            this.txtMaSV.TabIndex = 2;
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLop.Location = new System.Drawing.Point(3, 119);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(126, 15);
            this.labelMaLop.TabIndex = 1;
            this.labelMaLop.Text = "Mã Lớp Chuyển Đến";
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSV.Location = new System.Drawing.Point(3, 85);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(126, 15);
            this.labelMaSV.TabIndex = 0;
            this.labelMaSV.Text = "Nhập Mã Sinh Viên";
            // 
            // frmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 408);
            this.Controls.Add(this.panel);
            this.Name = "frmChuyenLop";
            this.Text = "frmChuyenLop";
            this.Load += new System.EventHandler(this.frmChuyenLop_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
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
    }
}