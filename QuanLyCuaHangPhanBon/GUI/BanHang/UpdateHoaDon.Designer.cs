namespace GUI.BanHang
{
    partial class UpdateHoaDon
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
            this.lblTenhh = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.lblMahh = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.lblThongbaogiaban = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenhh
            // 
            this.lblTenhh.AutoSize = true;
            this.lblTenhh.Location = new System.Drawing.Point(94, 9);
            this.lblTenhh.Name = "lblTenhh";
            this.lblTenhh.Size = new System.Drawing.Size(45, 13);
            this.lblTenhh.TabIndex = 0;
            this.lblTenhh.Text = "Tên HH";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(36, 33);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(26, 13);
            this.lblSl.TabIndex = 2;
            this.lblSl.Text = "SL :";
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(68, 30);
            this.txtSl.MaxLength = 4;
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(151, 20);
            this.txtSl.TabIndex = 1;
            this.txtSl.TextChanged += new System.EventHandler(this.txtSl_TextChanged);
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(79, 107);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.ForeColor = System.Drawing.Color.Red;
            this.lblThongbao.Location = new System.Drawing.Point(65, 53);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(0, 13);
            this.lblThongbao.TabIndex = 5;
            // 
            // lblMahh
            // 
            this.lblMahh.AutoSize = true;
            this.lblMahh.Location = new System.Drawing.Point(145, 9);
            this.lblMahh.Name = "lblMahh";
            this.lblMahh.Size = new System.Drawing.Size(0, 13);
            this.lblMahh.TabIndex = 6;
            this.lblMahh.Visible = false;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(68, 70);
            this.txtGiaban.MaxLength = 10;
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(151, 20);
            this.txtGiaban.TabIndex = 1;
            this.txtGiaban.TextChanged += new System.EventHandler(this.txtGiaban_TextChanged);
            this.txtGiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // lblGiaban
            // 
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.Location = new System.Drawing.Point(15, 77);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(50, 13);
            this.lblGiaban.TabIndex = 2;
            this.lblGiaban.Text = "Giá bán :";
            this.lblGiaban.Click += new System.EventHandler(this.lblGiaban_Click);
            // 
            // lblThongbaogiaban
            // 
            this.lblThongbaogiaban.AutoSize = true;
            this.lblThongbaogiaban.ForeColor = System.Drawing.Color.Red;
            this.lblThongbaogiaban.Location = new System.Drawing.Point(65, 93);
            this.lblThongbaogiaban.Name = "lblThongbaogiaban";
            this.lblThongbaogiaban.Size = new System.Drawing.Size(0, 13);
            this.lblThongbaogiaban.TabIndex = 7;
            this.lblThongbaogiaban.Click += new System.EventHandler(this.lblThongbaogiaban_Click);
            // 
            // UpdateHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 144);
            this.Controls.Add(this.lblThongbaogiaban);
            this.Controls.Add(this.lblMahh);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.lblGiaban);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.lblSl);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.lblTenhh);
            this.Name = "UpdateHoaDon";
            this.Text = "Chỉnh sửa hóa đơn";
            this.Load += new System.EventHandler(this.UpdateHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenhh;
        private System.Windows.Forms.Label lblSl;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Label lblMahh;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.Label lblThongbaogiaban;
    }
}