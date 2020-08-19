namespace GUI.QuanLy.NhanVien
{
    partial class frmThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTaiKhoan));
            this.lblThongBao = new System.Windows.Forms.Label();
            this.txtmlMK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthemTaiKhoan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(183, 365);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 27);
            this.lblThongBao.TabIndex = 19;
            // 
            // txtmlMK
            // 
            this.txtmlMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmlMK.Location = new System.Drawing.Point(375, 249);
            this.txtmlMK.MaxLength = 10;
            this.txtmlMK.Name = "txtmlMK";
            this.txtmlMK.PasswordChar = '*';
            this.txtmlMK.Size = new System.Drawing.Size(252, 34);
            this.txtmlMK.TabIndex = 17;
            this.txtmlMK.Click += new System.EventHandler(this.txtTenDN_Click);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(375, 192);
            this.txtMK.MaxLength = 10;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(252, 34);
            this.txtMK.TabIndex = 16;
            this.txtMK.Click += new System.EventHandler(this.txtTenDN_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(375, 135);
            this.txtTenDN.MaxLength = 20;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(252, 34);
            this.txtTenDN.TabIndex = 15;
            this.txtTenDN.Click += new System.EventHandler(this.txtTenDN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhập lại MKM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên đăng nhập :";
            // 
            // btnthemTaiKhoan
            // 
            this.btnthemTaiKhoan.ActiveBorderThickness = 1;
            this.btnthemTaiKhoan.ActiveCornerRadius = 20;
            this.btnthemTaiKhoan.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnthemTaiKhoan.ActiveForecolor = System.Drawing.Color.White;
            this.btnthemTaiKhoan.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnthemTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.btnthemTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthemTaiKhoan.BackgroundImage")));
            this.btnthemTaiKhoan.ButtonText = "Thêm Tài Khoản";
            this.btnthemTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemTaiKhoan.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnthemTaiKhoan.IdleBorderThickness = 1;
            this.btnthemTaiKhoan.IdleCornerRadius = 20;
            this.btnthemTaiKhoan.IdleFillColor = System.Drawing.Color.White;
            this.btnthemTaiKhoan.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnthemTaiKhoan.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnthemTaiKhoan.Location = new System.Drawing.Point(249, 409);
            this.btnthemTaiKhoan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnthemTaiKhoan.Name = "btnthemTaiKhoan";
            this.btnthemTaiKhoan.Size = new System.Drawing.Size(289, 73);
            this.btnthemTaiKhoan.TabIndex = 18;
            this.btnthemTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthemTaiKhoan.Click += new System.EventHandler(this.btnthemTaiKhoan_Click);
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(378, 92);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(75, 27);
            this.lblTenNV.TabIndex = 23;
            this.lblTenNV.Text = "tenNV";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(378, 35);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(74, 27);
            this.lblMaNV.TabIndex = 22;
            this.lblMaNV.Text = "maNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên nhân viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã nhân viên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Chức vụ :";
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbChucVu.Location = new System.Drawing.Point(375, 305);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(252, 34);
            this.cbChucVu.TabIndex = 25;
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 495);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnthemTaiKhoan);
            this.Controls.Add(this.txtmlMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmThemTaiKhoan";
            this.Text = "Thêm tài khoản";
            this.Load += new System.EventHandler(this.frmThemTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthemTaiKhoan;
        private System.Windows.Forms.TextBox txtmlMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbChucVu;
    }
}