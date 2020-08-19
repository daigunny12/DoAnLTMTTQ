namespace GUI.QuanLy.KhachHang
{
    partial class KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKH
            // 
            this.txtKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.Location = new System.Drawing.Point(207, 69);
            this.txtKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtKH.Multiline = true;
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(249, 35);
            this.txtKH.TabIndex = 4;
            this.txtKH.TextChanged += new System.EventHandler(this.txtKH_TextChanged);
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.AllowUserToAddRows = false;
            this.dtgKhachHang.AllowUserToDeleteRows = false;
            this.dtgKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKhachHang.ColumnHeadersHeight = 50;
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKH,
            this.soTT,
            this.tenKH,
            this.diaChi,
            this.sdt,
            this.soNo,
            this.ghiChu});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgKhachHang.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgKhachHang.Location = new System.Drawing.Point(0, 128);
            this.dtgKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgKhachHang.MultiSelect = false;
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.ReadOnly = true;
            this.dtgKhachHang.RowTemplate.Height = 40;
            this.dtgKhachHang.Size = new System.Drawing.Size(1124, 213);
            this.dtgKhachHang.TabIndex = 6;
            this.dtgKhachHang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgKhachHang_CellMouseClick);
            this.dtgKhachHang.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgKhachHang_CellMouseDoubleClick);
            this.dtgKhachHang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgKhachHang_DataBindingComplete);
            this.dtgKhachHang.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgKhachHang_DefaultValuesNeeded);
            this.dtgKhachHang.SelectionChanged += new System.EventHandler(this.dtgKhachHang_SelectionChanged);
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "maKH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.maKH.HeaderText = "MaKH";
            this.maKH.Name = "maKH";
            this.maKH.ReadOnly = true;
            // 
            // soTT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.soTT.DefaultCellStyle = dataGridViewCellStyle3;
            this.soTT.FillWeight = 70F;
            this.soTT.HeaderText = "STT";
            this.soTT.MinimumWidth = 30;
            this.soTT.Name = "soTT";
            this.soTT.ReadOnly = true;
            this.soTT.Width = 70;
            // 
            // tenKH
            // 
            this.tenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKH.DataPropertyName = "tenKH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tenKH.DefaultCellStyle = dataGridViewCellStyle4;
            this.tenKH.HeaderText = "Khách Hàng";
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.diaChi.DefaultCellStyle = dataGridViewCellStyle5;
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.NullValue = null;
            this.sdt.DefaultCellStyle = dataGridViewCellStyle6;
            this.sdt.FillWeight = 150F;
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 150;
            // 
            // soNo
            // 
            this.soNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soNo.DataPropertyName = "soNo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Format = "#,##0 đ";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.soNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.soNo.HeaderText = "Số Nợ";
            this.soNo.Name = "soNo";
            this.soNo.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghiChu.DataPropertyName = "ghiChu";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ghiChu.DefaultCellStyle = dataGridViewCellStyle8;
            this.ghiChu.HeaderText = "Ghi Chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.ForeColor = System.Drawing.Color.Navy;
            this.lblMa.Location = new System.Drawing.Point(410, 15);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(46, 17);
            this.lblMa.TabIndex = 7;
            this.lblMa.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.timkiem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(455, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackgroundImage = global::GUI.Properties.Resources.untitled1;
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaKH.Location = new System.Drawing.Point(886, 41);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(93, 63);
            this.btnXoaKH.TabIndex = 1;
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackgroundImage = global::GUI.Properties.Resources.untitled11;
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKH.Location = new System.Drawing.Point(719, 41);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(80, 63);
            this.btnThemKH.TabIndex = 0;
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chọn Cột Muốn Tìm Kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Khách Hàng",
            "Địa Chỉ",
            "SĐT",
            "Số Nợ",
            "Ghi Chú"});
            this.comboBox1.Location = new System.Drawing.Point(11, 70);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 34);
            this.comboBox1.TabIndex = 10;
            // 
            // btnXuat
            // 
            this.btnXuat.BackgroundImage = global::GUI.Properties.Resources.untitled5;
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXuat.Location = new System.Drawing.Point(545, 41);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(80, 63);
            this.btnXuat.TabIndex = 13;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1124, 341);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.dtgKhachHang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnThemKH);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}