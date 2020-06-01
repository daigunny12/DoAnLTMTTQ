namespace GUI.QuanLy.KhachHang
{
    partial class UpdateKH
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
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtGhiChuS = new System.Windows.Forms.TextBox();
            this.txtSoNo = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveKH = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtGhiChuS);
            this.groupBox1.Controls.Add(this.txtSoNo);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label6.Location = new System.Drawing.Point(230, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã KH :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(315, 14);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(145, 32);
            this.txtMaKH.TabIndex = 10;
            // 
            // txtGhiChuS
            // 
            this.txtGhiChuS.Location = new System.Drawing.Point(486, 135);
            this.txtGhiChuS.Multiline = true;
            this.txtGhiChuS.Name = "txtGhiChuS";
            this.txtGhiChuS.Size = new System.Drawing.Size(183, 87);
            this.txtGhiChuS.TabIndex = 9;
            // 
            // txtSoNo
            // 
            this.txtSoNo.Location = new System.Drawing.Point(486, 82);
            this.txtSoNo.MaxLength = 13;
            this.txtSoNo.Name = "txtSoNo";
            this.txtSoNo.Size = new System.Drawing.Size(183, 32);
            this.txtSoNo.TabIndex = 8;
            this.txtSoNo.Text = "0";
            this.txtSoNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNo_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(126, 190);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 32);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(126, 135);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(183, 32);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(126, 76);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(183, 32);
            this.txtTenKH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.Location = new System.Drawing.Point(403, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nợ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.Location = new System.Drawing.Point(61, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(43, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(41, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH :";
            // 
            // btnSaveKH
            // 
            this.btnSaveKH.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveKH.BackgroundImage = global::GUI.Properties.Resources.untitled21;
            this.btnSaveKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveKH.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnSaveKH.ForeColor = System.Drawing.Color.Black;
            this.btnSaveKH.Location = new System.Drawing.Point(623, 257);
            this.btnSaveKH.Name = "btnSaveKH";
            this.btnSaveKH.Size = new System.Drawing.Size(58, 52);
            this.btnSaveKH.TabIndex = 1;
            this.btnSaveKH.UseVisualStyleBackColor = false;
            this.btnSaveKH.Click += new System.EventHandler(this.btnSaveKH_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BackColor = System.Drawing.Color.Yellow;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblThongBao.Location = new System.Drawing.Point(12, 264);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 21);
            this.lblThongBao.TabIndex = 2;
            // 
            // UpdateKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 312);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnSaveKH);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateKH";
            this.Text = "Update Khách Hàng";
            this.Load += new System.EventHandler(this.UpdateKH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChuS;
        private System.Windows.Forms.TextBox txtSoNo;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveKH;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
    }
}