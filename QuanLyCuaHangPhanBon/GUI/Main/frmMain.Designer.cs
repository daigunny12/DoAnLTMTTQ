namespace GUI.Main
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnTong = new System.Windows.Forms.Panel();
            this.pnMainCon = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tabBaoCao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabBanHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabNhapHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabQuanLy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabManHinhChinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnfrm = new System.Windows.Forms.Panel();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.btnDangXuat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDoiMatKhau = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.btnAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTileFrm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFullscreenExit = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.supMenu = new GUI.supMenu();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnTong.SuspendLayout();
            this.pnMainCon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnMain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.Interval = 15;
            // 
            // pnTong
            // 
            this.pnTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.pnTong.Controls.Add(this.pnMainCon);
            this.pnTong.Controls.Add(this.pnMain);
            this.bunifuTransition2.SetDecoration(this.pnTong, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnTong, BunifuAnimatorNS.DecorationType.None);
            this.pnTong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTong.Location = new System.Drawing.Point(0, 51);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(566, 818);
            this.pnTong.TabIndex = 4;
            // 
            // pnMainCon
            // 
            this.pnMainCon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainCon.BackgroundImage")));
            this.pnMainCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMainCon.Controls.Add(this.supMenu);
            this.pnMainCon.Controls.Add(this.panel1);
            this.bunifuTransition2.SetDecoration(this.pnMainCon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnMainCon, BunifuAnimatorNS.DecorationType.None);
            this.pnMainCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainCon.GradientBottomLeft = System.Drawing.Color.White;
            this.pnMainCon.GradientBottomRight = System.Drawing.Color.White;
            this.pnMainCon.GradientTopLeft = System.Drawing.Color.White;
            this.pnMainCon.GradientTopRight = System.Drawing.Color.White;
            this.pnMainCon.Location = new System.Drawing.Point(382, 0);
            this.pnMainCon.Name = "pnMainCon";
            this.pnMainCon.Quality = 10;
            this.pnMainCon.Size = new System.Drawing.Size(184, 818);
            this.pnMainCon.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 76);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox6
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox6, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::GUI.Properties.Resources.iconList;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(184, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.tabBaoCao);
            this.pnMain.Controls.Add(this.tabBanHang);
            this.pnMain.Controls.Add(this.tabNhapHang);
            this.pnMain.Controls.Add(this.tabQuanLy);
            this.pnMain.Controls.Add(this.tabManHinhChinh);
            this.pnMain.Controls.Add(this.panel3);
            this.bunifuTransition2.SetDecoration(this.pnMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnMain, BunifuAnimatorNS.DecorationType.None);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMain.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.pnMain.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.pnMain.GradientTopLeft = System.Drawing.Color.Blue;
            this.pnMain.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Quality = 10;
            this.pnMain.Size = new System.Drawing.Size(382, 818);
            this.pnMain.TabIndex = 0;
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.tabBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBaoCao.BorderRadius = 0;
            this.tabBaoCao.ButtonText = "         Báo cáo thống kê";
            this.tabBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.tabBaoCao, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tabBaoCao, BunifuAnimatorNS.DecorationType.None);
            this.tabBaoCao.DisabledColor = System.Drawing.Color.Gray;
            this.tabBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabBaoCao.Iconcolor = System.Drawing.Color.Transparent;
            this.tabBaoCao.Iconimage = global::GUI.Properties.Resources.iconThongKe;
            this.tabBaoCao.Iconimage_right = null;
            this.tabBaoCao.Iconimage_right_Selected = null;
            this.tabBaoCao.Iconimage_Selected = null;
            this.tabBaoCao.IconMarginLeft = 0;
            this.tabBaoCao.IconMarginRight = 0;
            this.tabBaoCao.IconRightVisible = true;
            this.tabBaoCao.IconRightZoom = 0D;
            this.tabBaoCao.IconVisible = true;
            this.tabBaoCao.IconZoom = 70D;
            this.tabBaoCao.IsTab = true;
            this.tabBaoCao.Location = new System.Drawing.Point(0, 348);
            this.tabBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Normalcolor = System.Drawing.Color.Transparent;
            this.tabBaoCao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabBaoCao.OnHoverTextColor = System.Drawing.Color.White;
            this.tabBaoCao.selected = false;
            this.tabBaoCao.Size = new System.Drawing.Size(382, 60);
            this.tabBaoCao.TabIndex = 15;
            this.tabBaoCao.Tag = "5";
            this.tabBaoCao.Text = "         Báo cáo thống kê";
            this.tabBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabBaoCao.Textcolor = System.Drawing.Color.White;
            this.tabBaoCao.TextFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBaoCao.Click += new System.EventHandler(this.tabBaoCao_Click);
            // 
            // tabBanHang
            // 
            this.tabBanHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabBanHang.BackColor = System.Drawing.Color.Transparent;
            this.tabBanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBanHang.BorderRadius = 0;
            this.tabBanHang.ButtonText = "         Bán hàng";
            this.tabBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.tabBanHang, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tabBanHang, BunifuAnimatorNS.DecorationType.None);
            this.tabBanHang.DisabledColor = System.Drawing.Color.Gray;
            this.tabBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabBanHang.Iconcolor = System.Drawing.Color.Transparent;
            this.tabBanHang.Iconimage = global::GUI.Properties.Resources.iconBan;
            this.tabBanHang.Iconimage_right = null;
            this.tabBanHang.Iconimage_right_Selected = null;
            this.tabBanHang.Iconimage_Selected = null;
            this.tabBanHang.IconMarginLeft = 0;
            this.tabBanHang.IconMarginRight = 0;
            this.tabBanHang.IconRightVisible = true;
            this.tabBanHang.IconRightZoom = 0D;
            this.tabBanHang.IconVisible = true;
            this.tabBanHang.IconZoom = 70D;
            this.tabBanHang.IsTab = true;
            this.tabBanHang.Location = new System.Drawing.Point(0, 288);
            this.tabBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Normalcolor = System.Drawing.Color.Transparent;
            this.tabBanHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabBanHang.OnHoverTextColor = System.Drawing.Color.White;
            this.tabBanHang.selected = false;
            this.tabBanHang.Size = new System.Drawing.Size(382, 60);
            this.tabBanHang.TabIndex = 14;
            this.tabBanHang.Tag = "4";
            this.tabBanHang.Text = "         Bán hàng";
            this.tabBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabBanHang.Textcolor = System.Drawing.Color.White;
            this.tabBanHang.TextFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBanHang.Click += new System.EventHandler(this.tabBanHang_Click);
            // 
            // tabNhapHang
            // 
            this.tabNhapHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabNhapHang.BackColor = System.Drawing.Color.Transparent;
            this.tabNhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNhapHang.BorderRadius = 0;
            this.tabNhapHang.ButtonText = "         Nhập hàng";
            this.tabNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.tabNhapHang, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tabNhapHang, BunifuAnimatorNS.DecorationType.None);
            this.tabNhapHang.DisabledColor = System.Drawing.Color.Gray;
            this.tabNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabNhapHang.Iconcolor = System.Drawing.Color.Transparent;
            this.tabNhapHang.Iconimage = global::GUI.Properties.Resources.iconNhapHang;
            this.tabNhapHang.Iconimage_right = null;
            this.tabNhapHang.Iconimage_right_Selected = null;
            this.tabNhapHang.Iconimage_Selected = null;
            this.tabNhapHang.IconMarginLeft = 0;
            this.tabNhapHang.IconMarginRight = 0;
            this.tabNhapHang.IconRightVisible = true;
            this.tabNhapHang.IconRightZoom = 0D;
            this.tabNhapHang.IconVisible = true;
            this.tabNhapHang.IconZoom = 70D;
            this.tabNhapHang.IsTab = true;
            this.tabNhapHang.Location = new System.Drawing.Point(0, 228);
            this.tabNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNhapHang.Name = "tabNhapHang";
            this.tabNhapHang.Normalcolor = System.Drawing.Color.Transparent;
            this.tabNhapHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabNhapHang.OnHoverTextColor = System.Drawing.Color.White;
            this.tabNhapHang.selected = false;
            this.tabNhapHang.Size = new System.Drawing.Size(382, 60);
            this.tabNhapHang.TabIndex = 13;
            this.tabNhapHang.Tag = "3";
            this.tabNhapHang.Text = "         Nhập hàng";
            this.tabNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabNhapHang.Textcolor = System.Drawing.Color.White;
            this.tabNhapHang.TextFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhapHang.Click += new System.EventHandler(this.tabNhapHang_Click);
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.tabQuanLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabQuanLy.BorderRadius = 0;
            this.tabQuanLy.ButtonText = "         Quản lý";
            this.tabQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.tabQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tabQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.tabQuanLy.DisabledColor = System.Drawing.Color.Gray;
            this.tabQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabQuanLy.Iconcolor = System.Drawing.Color.Transparent;
            this.tabQuanLy.Iconimage = global::GUI.Properties.Resources.iconQuanLy;
            this.tabQuanLy.Iconimage_right = null;
            this.tabQuanLy.Iconimage_right_Selected = null;
            this.tabQuanLy.Iconimage_Selected = null;
            this.tabQuanLy.IconMarginLeft = 0;
            this.tabQuanLy.IconMarginRight = 0;
            this.tabQuanLy.IconRightVisible = true;
            this.tabQuanLy.IconRightZoom = 0D;
            this.tabQuanLy.IconVisible = true;
            this.tabQuanLy.IconZoom = 70D;
            this.tabQuanLy.IsTab = true;
            this.tabQuanLy.Location = new System.Drawing.Point(0, 168);
            this.tabQuanLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Normalcolor = System.Drawing.Color.Transparent;
            this.tabQuanLy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabQuanLy.OnHoverTextColor = System.Drawing.Color.White;
            this.tabQuanLy.selected = false;
            this.tabQuanLy.Size = new System.Drawing.Size(382, 60);
            this.tabQuanLy.TabIndex = 12;
            this.tabQuanLy.Tag = "2";
            this.tabQuanLy.Text = "         Quản lý";
            this.tabQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabQuanLy.Textcolor = System.Drawing.Color.White;
            this.tabQuanLy.TextFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLy.Click += new System.EventHandler(this.tabQuanLy_Click);
            // 
            // tabManHinhChinh
            // 
            this.tabManHinhChinh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabManHinhChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabManHinhChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabManHinhChinh.BorderRadius = 0;
            this.tabManHinhChinh.ButtonText = "         Màn hình chính";
            this.tabManHinhChinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.tabManHinhChinh, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tabManHinhChinh, BunifuAnimatorNS.DecorationType.None);
            this.tabManHinhChinh.DisabledColor = System.Drawing.Color.Gray;
            this.tabManHinhChinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabManHinhChinh.Iconcolor = System.Drawing.Color.Transparent;
            this.tabManHinhChinh.Iconimage = global::GUI.Properties.Resources.iconLapTop;
            this.tabManHinhChinh.Iconimage_right = null;
            this.tabManHinhChinh.Iconimage_right_Selected = null;
            this.tabManHinhChinh.Iconimage_Selected = null;
            this.tabManHinhChinh.IconMarginLeft = 0;
            this.tabManHinhChinh.IconMarginRight = 0;
            this.tabManHinhChinh.IconRightVisible = true;
            this.tabManHinhChinh.IconRightZoom = 0D;
            this.tabManHinhChinh.IconVisible = true;
            this.tabManHinhChinh.IconZoom = 70D;
            this.tabManHinhChinh.IsTab = true;
            this.tabManHinhChinh.Location = new System.Drawing.Point(0, 108);
            this.tabManHinhChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabManHinhChinh.Name = "tabManHinhChinh";
            this.tabManHinhChinh.Normalcolor = System.Drawing.Color.Transparent;
            this.tabManHinhChinh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.tabManHinhChinh.OnHoverTextColor = System.Drawing.Color.White;
            this.tabManHinhChinh.selected = true;
            this.tabManHinhChinh.Size = new System.Drawing.Size(382, 60);
            this.tabManHinhChinh.TabIndex = 9;
            this.tabManHinhChinh.Tag = "0";
            this.tabManHinhChinh.Text = "         Màn hình chính";
            this.tabManHinhChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabManHinhChinh.Textcolor = System.Drawing.Color.White;
            this.tabManHinhChinh.TextFont = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManHinhChinh.Click += new System.EventHandler(this.tabManHinhChinh_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 108);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::GUI.Properties.Resources.iconStore;
            this.pictureBox1.Location = new System.Drawing.Point(155, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnfrm
            // 
            this.pnfrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuTransition2.SetDecoration(this.pnfrm, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnfrm, BunifuAnimatorNS.DecorationType.None);
            this.pnfrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnfrm.Location = new System.Drawing.Point(566, 51);
            this.pnfrm.Name = "pnfrm";
            this.pnfrm.Size = new System.Drawing.Size(760, 818);
            this.pnfrm.TabIndex = 3;
            this.pnfrm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnfrm_MouseClick);
            // 
            // pnAccount
            // 
            this.pnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.pnAccount.Controls.Add(this.btnDangXuat);
            this.pnAccount.Controls.Add(this.btnDoiMatKhau);
            this.pnAccount.Controls.Add(this.pictureBox5);
            this.pnAccount.Controls.Add(this.pictureBox4);
            this.pnAccount.Controls.Add(this.lblTenNV);
            this.pnAccount.Controls.Add(this.pictureBox3);
            this.bunifuTransition2.SetDecoration(this.pnAccount, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnAccount, BunifuAnimatorNS.DecorationType.None);
            this.pnAccount.Location = new System.Drawing.Point(0, 0);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(260, 190);
            this.pnAccount.TabIndex = 0;
            this.pnAccount.MouseHover += new System.EventHandler(this.pnAccount_MouseHover);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ActiveBorderThickness = 1;
            this.btnDangXuat.ActiveCornerRadius = 20;
            this.btnDangXuat.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.ActiveForecolor = System.Drawing.Color.White;
            this.btnDangXuat.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnDangXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.BackgroundImage")));
            this.btnDangXuat.ButtonText = "Đăng xuất";
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.btnDangXuat, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnDangXuat, BunifuAnimatorNS.DecorationType.None);
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.IdleBorderThickness = 1;
            this.btnDangXuat.IdleCornerRadius = 20;
            this.btnDangXuat.IdleFillColor = System.Drawing.Color.White;
            this.btnDangXuat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.Location = new System.Drawing.Point(62, 116);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(177, 60);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.ActiveBorderThickness = 1;
            this.btnDoiMatKhau.ActiveCornerRadius = 20;
            this.btnDoiMatKhau.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDoiMatKhau.ActiveForecolor = System.Drawing.Color.White;
            this.btnDoiMatKhau.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnDoiMatKhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.BackgroundImage")));
            this.btnDoiMatKhau.ButtonText = "Đổi mật khẩu";
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.btnDoiMatKhau, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnDoiMatKhau, BunifuAnimatorNS.DecorationType.None);
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDoiMatKhau.IdleBorderThickness = 1;
            this.btnDoiMatKhau.IdleCornerRadius = 20;
            this.btnDoiMatKhau.IdleFillColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDoiMatKhau.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(62, 60);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(177, 60);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // pictureBox5
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = global::GUI.Properties.Resources.iconLogOut;
            this.pictureBox5.Location = new System.Drawing.Point(6, 121);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::GUI.Properties.Resources.Pass;
            this.pictureBox4.Location = new System.Drawing.Point(6, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTenNV, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblTenNV, BunifuAnimatorNS.DecorationType.None);
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.White;
            this.lblTenNV.Location = new System.Drawing.Point(67, 33);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(88, 22);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "lblTenNV";
            // 
            // pictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::GUI.Properties.Resources.UserName;
            this.pictureBox3.Location = new System.Drawing.Point(6, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTitleBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblTitleBar, BunifuAnimatorNS.DecorationType.None);
            this.lblTitleBar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleBar.Location = new System.Drawing.Point(66, 13);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(395, 26);
            this.lblTitleBar.TabIndex = 5;
            this.lblTitleBar.Text = "Phần mền quản lý của hàng phân bón";
            this.lblTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleBar_MouseDown);
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.pnTitleBar.Controls.Add(this.btnAccount);
            this.pnTitleBar.Controls.Add(this.lblTileFrm);
            this.pnTitleBar.Controls.Add(this.label1);
            this.pnTitleBar.Controls.Add(this.lblTitleBar);
            this.pnTitleBar.Controls.Add(this.pictureBox2);
            this.pnTitleBar.Controls.Add(this.btnMin);
            this.pnTitleBar.Controls.Add(this.btnFullscreenExit);
            this.pnTitleBar.Controls.Add(this.btnFullscreen);
            this.pnTitleBar.Controls.Add(this.btnClose);
            this.bunifuTransition2.SetDecoration(this.pnTitleBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnTitleBar, BunifuAnimatorNS.DecorationType.None);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(1326, 51);
            this.pnTitleBar.TabIndex = 1;
            this.pnTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.bunifuTransition2.SetDecoration(this.btnAccount, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnAccount, BunifuAnimatorNS.DecorationType.None);
            this.btnAccount.Image = global::GUI.Properties.Resources.iconSetting1;
            this.btnAccount.ImageActive = null;
            this.btnAccount.Location = new System.Drawing.Point(1045, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(68, 51);
            this.btnAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAccount.TabIndex = 9;
            this.btnAccount.TabStop = false;
            this.btnAccount.Zoom = 10;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // lblTileFrm
            // 
            this.lblTileFrm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTileFrm.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTileFrm, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblTileFrm, BunifuAnimatorNS.DecorationType.None);
            this.lblTileFrm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileFrm.ForeColor = System.Drawing.Color.White;
            this.lblTileFrm.Location = new System.Drawing.Point(527, 11);
            this.lblTileFrm.Name = "lblTileFrm";
            this.lblTileFrm.Size = new System.Drawing.Size(20, 26);
            this.lblTileFrm.TabIndex = 8;
            this.lblTileFrm.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::GUI.Properties.Resources.iconTilteBar;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.btnMin, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnMin, BunifuAnimatorNS.DecorationType.None);
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::GUI.Properties.Resources.iconMin;
            this.btnMin.Location = new System.Drawing.Point(1134, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(60, 51);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnFullscreenExit
            // 
            this.btnFullscreenExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.btnFullscreenExit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnFullscreenExit, BunifuAnimatorNS.DecorationType.None);
            this.btnFullscreenExit.FlatAppearance.BorderSize = 0;
            this.btnFullscreenExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreenExit.Image = global::GUI.Properties.Resources.iconFullscreenExit;
            this.btnFullscreenExit.Location = new System.Drawing.Point(1200, 0);
            this.btnFullscreenExit.Name = "btnFullscreenExit";
            this.btnFullscreenExit.Size = new System.Drawing.Size(60, 51);
            this.btnFullscreenExit.TabIndex = 3;
            this.btnFullscreenExit.UseVisualStyleBackColor = true;
            this.btnFullscreenExit.Click += new System.EventHandler(this.btnFullscreenExit_Click);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.btnFullscreen, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnFullscreen, BunifuAnimatorNS.DecorationType.None);
            this.btnFullscreen.FlatAppearance.BorderSize = 0;
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.Image = global::GUI.Properties.Resources.iconFullscreen;
            this.btnFullscreen.Location = new System.Drawing.Point(1200, 0);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(60, 51);
            this.btnFullscreen.TabIndex = 2;
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GUI.Properties.Resources.iconClose;
            this.btnClose.Location = new System.Drawing.Point(1266, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 51);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation4;
            this.bunifuTransition2.Interval = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // supMenu
            // 
            this.supMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.bunifuTransition1.SetDecoration(this.supMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.supMenu, BunifuAnimatorNS.DecorationType.None);
            this.supMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supMenu.Location = new System.Drawing.Point(0, 76);
            this.supMenu.Name = "supMenu";
            this.supMenu.Size = new System.Drawing.Size(184, 742);
            this.supMenu.TabIndex = 12;
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 869);
            this.Controls.Add(this.pnAccount);
            this.Controls.Add(this.pnfrm);
            this.Controls.Add(this.pnTong);
            this.Controls.Add(this.pnTitleBar);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "frmMain";
            this.Opacity = 0D;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnTong.ResumeLayout(false);
            this.pnMainCon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Panel pnfrm;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnMainCon;
        private Bunifu.Framework.UI.BunifuGradientPanel pnMain;
        private Bunifu.Framework.UI.BunifuFlatButton tabBaoCao;
        private Bunifu.Framework.UI.BunifuFlatButton tabBanHang;
        private Bunifu.Framework.UI.BunifuFlatButton tabNhapHang;
        private Bunifu.Framework.UI.BunifuFlatButton tabQuanLy;
        private Bunifu.Framework.UI.BunifuFlatButton tabManHinhChinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private supMenu supMenu;
        private System.Windows.Forms.Panel pnAccount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Button btnFullscreenExit;
        private System.Windows.Forms.Label lblTileFrm;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnAccount;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDangXuat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDoiMatKhau;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer timer2;
    }
}