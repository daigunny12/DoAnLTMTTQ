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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFullscreenExit = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.pnTong = new System.Windows.Forms.Panel();
            this.pnMainCon = new System.Windows.Forms.Panel();
            this.supMenu1 = new GUI.supMenu();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tabBaoCao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabBanHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabNhapHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabQuanLy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabHeThong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabManHinhChinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnTong.SuspendLayout();
            this.pnMainCon.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 15;
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(118)))));
            this.pnTitleBar.Controls.Add(this.lblTitleBar);
            this.pnTitleBar.Controls.Add(this.pictureBox2);
            this.pnTitleBar.Controls.Add(this.btnMin);
            this.pnTitleBar.Controls.Add(this.btnFullscreenExit);
            this.pnTitleBar.Controls.Add(this.btnFullscreen);
            this.pnTitleBar.Controls.Add(this.btnClose);
            this.bunifuTransition1.SetDecoration(this.pnTitleBar, BunifuAnimatorNS.DecorationType.None);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(1075, 51);
            this.pnTitleBar.TabIndex = 1;
            this.pnTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTitleBar, BunifuAnimatorNS.DecorationType.None);
            this.lblTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleBar.Location = new System.Drawing.Point(66, 12);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(367, 24);
            this.lblTitleBar.TabIndex = 5;
            this.lblTitleBar.Text = "Phần mền quản lý của hàng phân bón";
            this.lblTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleBar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
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
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::GUI.Properties.Resources.iconMin;
            this.btnMin.Location = new System.Drawing.Point(883, 0);
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
            this.btnFullscreenExit.FlatAppearance.BorderSize = 0;
            this.btnFullscreenExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreenExit.Image = global::GUI.Properties.Resources.iconFullscreenExit;
            this.btnFullscreenExit.Location = new System.Drawing.Point(949, 0);
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
            this.btnFullscreen.FlatAppearance.BorderSize = 0;
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.Image = global::GUI.Properties.Resources.iconFullscreen;
            this.btnFullscreen.Location = new System.Drawing.Point(949, 0);
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
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GUI.Properties.Resources.iconClose;
            this.btnClose.Location = new System.Drawing.Point(1015, 0);
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
            // pnTong
            // 
            this.pnTong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnTong.Controls.Add(this.pnMainCon);
            this.pnTong.Controls.Add(this.pnMain);
            this.bunifuTransition1.SetDecoration(this.pnTong, BunifuAnimatorNS.DecorationType.None);
            this.pnTong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTong.Location = new System.Drawing.Point(0, 51);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(716, 633);
            this.pnTong.TabIndex = 2;
            // 
            // pnMainCon
            // 
            this.pnMainCon.Controls.Add(this.supMenu1);
            this.pnMainCon.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.pnMainCon, BunifuAnimatorNS.DecorationType.None);
            this.pnMainCon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMainCon.Location = new System.Drawing.Point(403, 0);
            this.pnMainCon.Name = "pnMainCon";
            this.pnMainCon.Size = new System.Drawing.Size(291, 633);
            this.pnMainCon.TabIndex = 5;
            // 
            // supMenu1
            // 
            this.bunifuTransition1.SetDecoration(this.supMenu1, BunifuAnimatorNS.DecorationType.None);
            this.supMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supMenu1.Location = new System.Drawing.Point(0, 88);
            this.supMenu1.Name = "supMenu1";
            this.supMenu1.Size = new System.Drawing.Size(291, 545);
            this.supMenu1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 88);
            this.panel3.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Navy;
            this.pnMain.Controls.Add(this.tabBaoCao);
            this.pnMain.Controls.Add(this.tabBanHang);
            this.pnMain.Controls.Add(this.tabNhapHang);
            this.pnMain.Controls.Add(this.tabQuanLy);
            this.pnMain.Controls.Add(this.tabHeThong);
            this.pnMain.Controls.Add(this.tabManHinhChinh);
            this.pnMain.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this.pnMain, BunifuAnimatorNS.DecorationType.None);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(403, 633);
            this.pnMain.TabIndex = 4;
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabBaoCao.AutoScroll = true;
            this.tabBaoCao.AutoSize = true;
            this.tabBaoCao.BackColor = System.Drawing.Color.Navy;
            this.tabBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBaoCao.BorderRadius = 0;
            this.tabBaoCao.ButtonText = "Báo cáo thống kê      ";
            this.tabBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tabBaoCao.IconZoom = 50D;
            this.tabBaoCao.IsTab = true;
            this.tabBaoCao.Location = new System.Drawing.Point(0, 420);
            this.tabBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Normalcolor = System.Drawing.Color.Navy;
            this.tabBaoCao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabBaoCao.OnHoverTextColor = System.Drawing.Color.White;
            this.tabBaoCao.selected = false;
            this.tabBaoCao.Size = new System.Drawing.Size(403, 60);
            this.tabBaoCao.TabIndex = 6;
            this.tabBaoCao.Tag = "5";
            this.tabBaoCao.Text = "Báo cáo thống kê      ";
            this.tabBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabBaoCao.Textcolor = System.Drawing.Color.White;
            this.tabBaoCao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBaoCao.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tabBanHang
            // 
            this.tabBanHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabBanHang.AutoScroll = true;
            this.tabBanHang.AutoSize = true;
            this.tabBanHang.BackColor = System.Drawing.Color.Navy;
            this.tabBanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBanHang.BorderRadius = 0;
            this.tabBanHang.ButtonText = "Bán hàng                    ";
            this.tabBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tabBanHang.IconZoom = 50D;
            this.tabBanHang.IsTab = true;
            this.tabBanHang.Location = new System.Drawing.Point(0, 360);
            this.tabBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Normalcolor = System.Drawing.Color.Navy;
            this.tabBanHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabBanHang.OnHoverTextColor = System.Drawing.Color.White;
            this.tabBanHang.selected = false;
            this.tabBanHang.Size = new System.Drawing.Size(403, 60);
            this.tabBanHang.TabIndex = 5;
            this.tabBanHang.Tag = "4";
            this.tabBanHang.Text = "Bán hàng                    ";
            this.tabBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabBanHang.Textcolor = System.Drawing.Color.White;
            this.tabBanHang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBanHang.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tabNhapHang
            // 
            this.tabNhapHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabNhapHang.AutoScroll = true;
            this.tabNhapHang.AutoSize = true;
            this.tabNhapHang.BackColor = System.Drawing.Color.Navy;
            this.tabNhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNhapHang.BorderRadius = 0;
            this.tabNhapHang.ButtonText = "Nhập hàng                 ";
            this.tabNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tabNhapHang.IconZoom = 50D;
            this.tabNhapHang.IsTab = true;
            this.tabNhapHang.Location = new System.Drawing.Point(0, 300);
            this.tabNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNhapHang.Name = "tabNhapHang";
            this.tabNhapHang.Normalcolor = System.Drawing.Color.Navy;
            this.tabNhapHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabNhapHang.OnHoverTextColor = System.Drawing.Color.White;
            this.tabNhapHang.selected = false;
            this.tabNhapHang.Size = new System.Drawing.Size(403, 60);
            this.tabNhapHang.TabIndex = 4;
            this.tabNhapHang.Tag = "3";
            this.tabNhapHang.Text = "Nhập hàng                 ";
            this.tabNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabNhapHang.Textcolor = System.Drawing.Color.White;
            this.tabNhapHang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhapHang.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabQuanLy.AutoScroll = true;
            this.tabQuanLy.AutoSize = true;
            this.tabQuanLy.BackColor = System.Drawing.Color.Navy;
            this.tabQuanLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabQuanLy.BorderRadius = 0;
            this.tabQuanLy.ButtonText = "Quản lý                       ";
            this.tabQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tabQuanLy.IconZoom = 50D;
            this.tabQuanLy.IsTab = true;
            this.tabQuanLy.Location = new System.Drawing.Point(0, 240);
            this.tabQuanLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Normalcolor = System.Drawing.Color.Navy;
            this.tabQuanLy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabQuanLy.OnHoverTextColor = System.Drawing.Color.White;
            this.tabQuanLy.selected = false;
            this.tabQuanLy.Size = new System.Drawing.Size(403, 60);
            this.tabQuanLy.TabIndex = 3;
            this.tabQuanLy.Tag = "2";
            this.tabQuanLy.Text = "Quản lý                       ";
            this.tabQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabQuanLy.Textcolor = System.Drawing.Color.White;
            this.tabQuanLy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLy.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tabHeThong
            // 
            this.tabHeThong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabHeThong.AutoScroll = true;
            this.tabHeThong.AutoSize = true;
            this.tabHeThong.BackColor = System.Drawing.Color.Navy;
            this.tabHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHeThong.BorderRadius = 0;
            this.tabHeThong.ButtonText = "Hệ thống                    ";
            this.tabHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabHeThong, BunifuAnimatorNS.DecorationType.None);
            this.tabHeThong.DisabledColor = System.Drawing.Color.Gray;
            this.tabHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabHeThong.Iconcolor = System.Drawing.Color.Transparent;
            this.tabHeThong.Iconimage = global::GUI.Properties.Resources.iconSetting;
            this.tabHeThong.Iconimage_right = null;
            this.tabHeThong.Iconimage_right_Selected = null;
            this.tabHeThong.Iconimage_Selected = null;
            this.tabHeThong.IconMarginLeft = 0;
            this.tabHeThong.IconMarginRight = 0;
            this.tabHeThong.IconRightVisible = true;
            this.tabHeThong.IconRightZoom = 0D;
            this.tabHeThong.IconVisible = true;
            this.tabHeThong.IconZoom = 50D;
            this.tabHeThong.IsTab = true;
            this.tabHeThong.Location = new System.Drawing.Point(0, 180);
            this.tabHeThong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHeThong.Name = "tabHeThong";
            this.tabHeThong.Normalcolor = System.Drawing.Color.Navy;
            this.tabHeThong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabHeThong.OnHoverTextColor = System.Drawing.Color.White;
            this.tabHeThong.selected = false;
            this.tabHeThong.Size = new System.Drawing.Size(403, 60);
            this.tabHeThong.TabIndex = 2;
            this.tabHeThong.Tag = "1";
            this.tabHeThong.Text = "Hệ thống                    ";
            this.tabHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabHeThong.Textcolor = System.Drawing.Color.White;
            this.tabHeThong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHeThong.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tabManHinhChinh
            // 
            this.tabManHinhChinh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabManHinhChinh.AutoScroll = true;
            this.tabManHinhChinh.AutoSize = true;
            this.tabManHinhChinh.BackColor = System.Drawing.Color.Navy;
            this.tabManHinhChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabManHinhChinh.BorderRadius = 0;
            this.tabManHinhChinh.ButtonText = "Màn hình chính          ";
            this.tabManHinhChinh.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tabManHinhChinh.IconZoom = 50D;
            this.tabManHinhChinh.IsTab = true;
            this.tabManHinhChinh.Location = new System.Drawing.Point(0, 120);
            this.tabManHinhChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabManHinhChinh.Name = "tabManHinhChinh";
            this.tabManHinhChinh.Normalcolor = System.Drawing.Color.Navy;
            this.tabManHinhChinh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.tabManHinhChinh.OnHoverTextColor = System.Drawing.Color.White;
            this.tabManHinhChinh.selected = true;
            this.tabManHinhChinh.Size = new System.Drawing.Size(403, 60);
            this.tabManHinhChinh.TabIndex = 1;
            this.tabManHinhChinh.Tag = "0";
            this.tabManHinhChinh.Text = "Màn hình chính          ";
            this.tabManHinhChinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabManHinhChinh.Textcolor = System.Drawing.Color.White;
            this.tabManHinhChinh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManHinhChinh.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 120);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::GUI.Properties.Resources.iconStore;
            this.pictureBox1.Location = new System.Drawing.Point(167, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 684);
            this.Controls.Add(this.pnTong);
            this.Controls.Add(this.pnTitleBar);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnTong.ResumeLayout(false);
            this.pnMainCon.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFullscreenExit;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Panel pnMainCon;
        private supMenu supMenu1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnMain;
        private Bunifu.Framework.UI.BunifuFlatButton tabBaoCao;
        private Bunifu.Framework.UI.BunifuFlatButton tabBanHang;
        private Bunifu.Framework.UI.BunifuFlatButton tabNhapHang;
        private Bunifu.Framework.UI.BunifuFlatButton tabQuanLy;
        private Bunifu.Framework.UI.BunifuFlatButton tabHeThong;
        private Bunifu.Framework.UI.BunifuFlatButton tabManHinhChinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}