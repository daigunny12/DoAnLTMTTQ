namespace GUI.QuanLy.HangHoa
{
    partial class UpdateHH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtGhiChuS = new System.Windows.Forms.TextBox();
            this.txtGiaMuaS = new System.Windows.Forms.TextBox();
            this.txtGiaBanS = new System.Windows.Forms.TextBox();
            this.txtDVTS = new System.Windows.Forms.TextBox();
            this.txtTenHHS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveHangHoaS = new System.Windows.Forms.Button();
            this.lblThongBaoS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaHH);
            this.groupBox1.Controls.Add(this.txtGhiChuS);
            this.groupBox1.Controls.Add(this.txtGiaMuaS);
            this.groupBox1.Controls.Add(this.txtGiaBanS);
            this.groupBox1.Controls.Add(this.txtDVTS);
            this.groupBox1.Controls.Add(this.txtTenHHS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(903, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hàng Hóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label6.Location = new System.Drawing.Point(307, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã HH :";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Enabled = false;
            this.txtMaHH.Location = new System.Drawing.Point(420, 17);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(192, 38);
            this.txtMaHH.TabIndex = 10;
            // 
            // txtGhiChuS
            // 
            this.txtGhiChuS.Location = new System.Drawing.Point(648, 166);
            this.txtGhiChuS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChuS.MaxLength = 50;
            this.txtGhiChuS.Multiline = true;
            this.txtGhiChuS.Name = "txtGhiChuS";
            this.txtGhiChuS.Size = new System.Drawing.Size(243, 106);
            this.txtGhiChuS.TabIndex = 9;
            // 
            // txtGiaMuaS
            // 
            this.txtGiaMuaS.Location = new System.Drawing.Point(648, 101);
            this.txtGiaMuaS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaMuaS.MaxLength = 13;
            this.txtGiaMuaS.Name = "txtGiaMuaS";
            this.txtGiaMuaS.Size = new System.Drawing.Size(243, 38);
            this.txtGiaMuaS.TabIndex = 8;
            this.txtGiaMuaS.Text = "0";
            this.txtGiaMuaS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMuaS_KeyPress);
            // 
            // txtGiaBanS
            // 
            this.txtGiaBanS.Location = new System.Drawing.Point(168, 234);
            this.txtGiaBanS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaBanS.MaxLength = 13;
            this.txtGiaBanS.Name = "txtGiaBanS";
            this.txtGiaBanS.Size = new System.Drawing.Size(243, 38);
            this.txtGiaBanS.TabIndex = 7;
            this.txtGiaBanS.Text = "0";
            this.txtGiaBanS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBanS_KeyPress);
            // 
            // txtDVTS
            // 
            this.txtDVTS.Location = new System.Drawing.Point(168, 166);
            this.txtDVTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDVTS.MaxLength = 20;
            this.txtDVTS.Name = "txtDVTS";
            this.txtDVTS.Size = new System.Drawing.Size(243, 38);
            this.txtDVTS.TabIndex = 6;
            // 
            // txtTenHHS
            // 
            this.txtTenHHS.Location = new System.Drawing.Point(168, 94);
            this.txtTenHHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHHS.MaxLength = 50;
            this.txtTenHHS.Name = "txtTenHHS";
            this.txtTenHHS.Size = new System.Drawing.Size(243, 38);
            this.txtTenHHS.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.Location = new System.Drawing.Point(537, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá mua :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.Location = new System.Drawing.Point(57, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá bán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(21, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(55, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên HH :";
            // 
            // btnSaveHangHoaS
            // 
            this.btnSaveHangHoaS.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveHangHoaS.BackgroundImage = global::GUI.Properties.Resources.untitled21;
            this.btnSaveHangHoaS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveHangHoaS.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnSaveHangHoaS.ForeColor = System.Drawing.Color.Black;
            this.btnSaveHangHoaS.Location = new System.Drawing.Point(831, 316);
            this.btnSaveHangHoaS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveHangHoaS.Name = "btnSaveHangHoaS";
            this.btnSaveHangHoaS.Size = new System.Drawing.Size(77, 64);
            this.btnSaveHangHoaS.TabIndex = 1;
            this.btnSaveHangHoaS.UseVisualStyleBackColor = false;
            this.btnSaveHangHoaS.Click += new System.EventHandler(this.btnSaveHangHoaS_Click);
            // 
            // lblThongBaoS
            // 
            this.lblThongBaoS.AutoSize = true;
            this.lblThongBaoS.BackColor = System.Drawing.Color.Yellow;
            this.lblThongBaoS.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblThongBaoS.Location = new System.Drawing.Point(16, 325);
            this.lblThongBaoS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBaoS.Name = "lblThongBaoS";
            this.lblThongBaoS.Size = new System.Drawing.Size(0, 27);
            this.lblThongBaoS.TabIndex = 2;
            // 
            // UpdateHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 384);
            this.Controls.Add(this.lblThongBaoS);
            this.Controls.Add(this.btnSaveHangHoaS);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateHH";
            this.Text = "Update Hàng Hóa";
            this.Load += new System.EventHandler(this.frmUpdateHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChuS;
        private System.Windows.Forms.TextBox txtGiaMuaS;
        private System.Windows.Forms.TextBox txtGiaBanS;
        private System.Windows.Forms.TextBox txtDVTS;
        private System.Windows.Forms.TextBox txtTenHHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveHangHoaS;
        private System.Windows.Forms.Label lblThongBaoS;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label6;
    }
}