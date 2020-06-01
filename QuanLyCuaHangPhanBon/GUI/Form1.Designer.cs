namespace GUI
{
    partial class Form1
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
            this.btnNV = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHH = new System.Windows.Forms.Button();
            this.btnChiTietBanHang = new System.Windows.Forms.Button();
            this.btnChiTietNhapHang = new System.Windows.Forms.Button();
            this.btnHoaDonBanHang = new System.Windows.Forms.Button();
            this.btnHoaDonNhapHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.ForeColor = System.Drawing.Color.White;
            this.btnNV.Location = new System.Drawing.Point(444, 173);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(181, 136);
            this.btnNV.TabIndex = 2;
            this.btnNV.Text = "Nhân Viên";
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.Magenta;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.Color.White;
            this.btnKH.Location = new System.Drawing.Point(12, 331);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(181, 136);
            this.btnKH.TabIndex = 3;
            this.btnKH.Text = "Khách Hàng";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.Location = new System.Drawing.Point(444, 331);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(181, 136);
            this.btnNCC.TabIndex = 4;
            this.btnNCC.Text = "Nhà Cung Cấp";
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(203, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ";
            // 
            // btnHH
            // 
            this.btnHH.BackColor = System.Drawing.Color.Red;
            this.btnHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHH.ForeColor = System.Drawing.Color.White;
            this.btnHH.Location = new System.Drawing.Point(12, 173);
            this.btnHH.Name = "btnHH";
            this.btnHH.Size = new System.Drawing.Size(181, 136);
            this.btnHH.TabIndex = 6;
            this.btnHH.Text = "Hàng Hóa";
            this.btnHH.UseVisualStyleBackColor = false;
            this.btnHH.Click += new System.EventHandler(this.btnHH_Click);
            // 
            // btnChiTietBanHang
            // 
            this.btnChiTietBanHang.BackColor = System.Drawing.Color.Red;
            this.btnChiTietBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietBanHang.ForeColor = System.Drawing.Color.White;
            this.btnChiTietBanHang.Location = new System.Drawing.Point(6, 29);
            this.btnChiTietBanHang.Name = "btnChiTietBanHang";
            this.btnChiTietBanHang.Size = new System.Drawing.Size(228, 64);
            this.btnChiTietBanHang.TabIndex = 7;
            this.btnChiTietBanHang.Text = "Chi Tiết Bán Hàng";
            this.btnChiTietBanHang.UseVisualStyleBackColor = false;
            this.btnChiTietBanHang.Click += new System.EventHandler(this.btnChiTietBanHang_Click);
            // 
            // btnChiTietNhapHang
            // 
            this.btnChiTietNhapHang.BackColor = System.Drawing.Color.Red;
            this.btnChiTietNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnChiTietNhapHang.Location = new System.Drawing.Point(3, 99);
            this.btnChiTietNhapHang.Name = "btnChiTietNhapHang";
            this.btnChiTietNhapHang.Size = new System.Drawing.Size(228, 64);
            this.btnChiTietNhapHang.TabIndex = 8;
            this.btnChiTietNhapHang.Text = "Chi Tiết Nhập Hàng";
            this.btnChiTietNhapHang.UseVisualStyleBackColor = false;
            this.btnChiTietNhapHang.Click += new System.EventHandler(this.btnChiTietNhapHang_Click);
            // 
            // btnHoaDonBanHang
            // 
            this.btnHoaDonBanHang.BackColor = System.Drawing.Color.Red;
            this.btnHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonBanHang.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonBanHang.Location = new System.Drawing.Point(3, 169);
            this.btnHoaDonBanHang.Name = "btnHoaDonBanHang";
            this.btnHoaDonBanHang.Size = new System.Drawing.Size(228, 64);
            this.btnHoaDonBanHang.TabIndex = 9;
            this.btnHoaDonBanHang.Text = "Hóa Đơn Bán Hàng";
            this.btnHoaDonBanHang.UseVisualStyleBackColor = false;
            this.btnHoaDonBanHang.Click += new System.EventHandler(this.btnHoaDonBanHang_Click);
            // 
            // btnHoaDonNhapHang
            // 
            this.btnHoaDonNhapHang.BackColor = System.Drawing.Color.Red;
            this.btnHoaDonNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonNhapHang.Location = new System.Drawing.Point(3, 239);
            this.btnHoaDonNhapHang.Name = "btnHoaDonNhapHang";
            this.btnHoaDonNhapHang.Size = new System.Drawing.Size(228, 64);
            this.btnHoaDonNhapHang.TabIndex = 10;
            this.btnHoaDonNhapHang.Text = "Hóa Đơn Nhập Hàng";
            this.btnHoaDonNhapHang.UseVisualStyleBackColor = false;
            this.btnHoaDonNhapHang.Click += new System.EventHandler(this.btnHoaDonNhapHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnChiTietBanHang);
            this.groupBox1.Controls.Add(this.btnHoaDonNhapHang);
            this.groupBox1.Controls.Add(this.btnChiTietNhapHang);
            this.groupBox1.Controls.Add(this.btnHoaDonBanHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(199, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 294);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Tê Tê";
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.BackColor = System.Drawing.Color.Red;
            this.btnXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatKho.ForeColor = System.Drawing.Color.White;
            this.btnXuatKho.Location = new System.Drawing.Point(12, 55);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(181, 64);
            this.btnXuatKho.TabIndex = 12;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.UseVisualStyleBackColor = false;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.Red;
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(458, 55);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(181, 64);
            this.btnNhapKho.TabIndex = 13;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 479);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.btnXuatKho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNCC);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnNV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHH;
        private System.Windows.Forms.Button btnChiTietBanHang;
        private System.Windows.Forms.Button btnChiTietNhapHang;
        private System.Windows.Forms.Button btnHoaDonBanHang;
        private System.Windows.Forms.Button btnHoaDonNhapHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnNhapKho;
    }
}

