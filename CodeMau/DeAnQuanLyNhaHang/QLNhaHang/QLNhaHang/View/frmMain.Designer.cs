namespace QLNhaHang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonAnUaThich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lime;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLy,
            this.hệThốngToolStripMenuItem,
            this.mnuDS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(902, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLy
            // 
            this.QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuMonAn,
            this.mnuHoaDon});
            this.QuanLy.Image = global::QLNhaHang.Properties.Resources.download;
            this.QuanLy.Name = "QuanLy";
            this.QuanLy.Size = new System.Drawing.Size(108, 27);
            this.QuanLy.Text = "Quản lý";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Enabled = false;
            this.mnuNhanVien.Image = global::QLNhaHang.Properties.Resources.users_vector_icon_png_260862;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(184, 28);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Enabled = false;
            this.mnuKhachHang.Image = global::QLNhaHang.Properties.Resources.download__2_;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(184, 28);
            this.mnuKhachHang.Text = "Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuMonAn
            // 
            this.mnuMonAn.Enabled = false;
            this.mnuMonAn.Image = global::QLNhaHang.Properties.Resources.download__3_;
            this.mnuMonAn.Name = "mnuMonAn";
            this.mnuMonAn.Size = new System.Drawing.Size(184, 28);
            this.mnuMonAn.Text = "Món ăn";
            this.mnuMonAn.Click += new System.EventHandler(this.mnuMonAn_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Enabled = false;
            this.mnuHoaDon.Image = global::QLNhaHang.Properties.Resources.icon_contract;
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(184, 28);
            this.mnuHoaDon.Text = "Hóa đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat});
            this.hệThốngToolStripMenuItem.Image = global::QLNhaHang.Properties.Resources.download1;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Enabled = false;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(172, 28);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuDS
            // 
            this.mnuDS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMonAnUaThich,
            this.mnuDSNV});
            this.mnuDS.Image = global::QLNhaHang.Properties.Resources.download__1_;
            this.mnuDS.Name = "mnuDS";
            this.mnuDS.Size = new System.Drawing.Size(128, 27);
            this.mnuDS.Text = "Danh sách";
            // 
            // mnuMonAnUaThich
            // 
            this.mnuMonAnUaThich.Image = global::QLNhaHang.Properties.Resources.icon_contract;
            this.mnuMonAnUaThich.Name = "mnuMonAnUaThich";
            this.mnuMonAnUaThich.Size = new System.Drawing.Size(256, 28);
            this.mnuMonAnUaThich.Text = "Món ăn ưa thích";
            this.mnuMonAnUaThich.Click += new System.EventHandler(this.mnuMonAnUaThich_Click);
            // 
            // mnuDSNV
            // 
            this.mnuDSNV.Name = "mnuDSNV";
            this.mnuDSNV.Size = new System.Drawing.Size(256, 28);
            this.mnuDSNV.Text = "Danh sách nhân viên";
            this.mnuDSNV.Click += new System.EventHandler(this.mnuDSNV_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::QLNhaHang.Properties.Resources.anh9;
            this.ClientSize = new System.Drawing.Size(902, 540);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem QuanLy;
        public System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        public System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        public System.Windows.Forms.ToolStripMenuItem mnuMonAn;
        public System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        public System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        public System.Windows.Forms.ToolStripMenuItem mnuDS;
        public System.Windows.Forms.ToolStripMenuItem mnuMonAnUaThich;
        private System.Windows.Forms.ToolStripMenuItem mnuDSNV;
    }
}

