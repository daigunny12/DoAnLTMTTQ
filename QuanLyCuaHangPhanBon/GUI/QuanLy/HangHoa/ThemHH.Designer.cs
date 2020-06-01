namespace GUI.QuanLy.HangHoa
{
    partial class ThemHH
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveHangHoa = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtGiaMua);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.txtTenHH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hàng Hóa";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(486, 97);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(183, 87);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(486, 41);
            this.txtGiaMua.MaxLength = 13;
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(183, 32);
            this.txtGiaMua.TabIndex = 8;
            this.txtGiaMua.Text = "0";
            this.txtGiaMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(126, 151);
            this.txtGiaBan.MaxLength = 13;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(183, 32);
            this.txtGiaBan.TabIndex = 7;
            this.txtGiaBan.Text = "0";
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(126, 94);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(183, 32);
            this.txtDVT.TabIndex = 6;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(126, 45);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(183, 32);
            this.txtTenHH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.Location = new System.Drawing.Point(402, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá mua :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá bán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên HH :";
            // 
            // btnSaveHangHoa
            // 
            this.btnSaveHangHoa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveHangHoa.BackgroundImage = global::GUI.Properties.Resources.untitled21;
            this.btnSaveHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveHangHoa.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnSaveHangHoa.ForeColor = System.Drawing.Color.Black;
            this.btnSaveHangHoa.Location = new System.Drawing.Point(616, 217);
            this.btnSaveHangHoa.Name = "btnSaveHangHoa";
            this.btnSaveHangHoa.Size = new System.Drawing.Size(65, 60);
            this.btnSaveHangHoa.TabIndex = 1;
            this.btnSaveHangHoa.UseVisualStyleBackColor = false;
            this.btnSaveHangHoa.Click += new System.EventHandler(this.btnSaveHangHoa_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BackColor = System.Drawing.Color.Yellow;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblThongBao.Location = new System.Drawing.Point(8, 224);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 21);
            this.lblThongBao.TabIndex = 2;
            // 
            // ThemHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 280);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnSaveHangHoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemHH";
            this.Text = "Thêm Hàng Hóa";
            this.Load += new System.EventHandler(this.frmThemHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveHangHoa;
        private System.Windows.Forms.Label lblThongBao;
    }
}