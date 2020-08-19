namespace GUI.QuanLy.HangHoa
{
    partial class HangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgHangHoa = new System.Windows.Forms.DataGridView();
            this.soTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtgHangHoa
            // 
            this.dtgHangHoa.AllowUserToAddRows = false;
            this.dtgHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgHangHoa.ColumnHeadersHeight = 50;
            this.dtgHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soTT,
            this.maHH,
            this.tenHH,
            this.donViTinh,
            this.giaBan,
            this.giaMua,
            this.soLuong,
            this.ghiChu});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHangHoa.DefaultCellStyle = dataGridViewCellStyle21;
            this.dtgHangHoa.Location = new System.Drawing.Point(0, 130);
            this.dtgHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.dtgHangHoa.Name = "dtgHangHoa";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgHangHoa.RowHeadersWidth = 60;
            this.dtgHangHoa.RowTemplate.Height = 40;
            this.dtgHangHoa.Size = new System.Drawing.Size(1075, 211);
            this.dtgHangHoa.TabIndex = 10;
            this.dtgHangHoa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgHangHoa_CellMouseClick_1);
            this.dtgHangHoa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgHangHoa_CellMouseDoubleClick);
            this.dtgHangHoa.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgHangHoa_DataBindingComplete);
            this.dtgHangHoa.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgHangHoa_DefaultValuesNeeded);
            this.dtgHangHoa.SelectionChanged += new System.EventHandler(this.dtgHangHoa_SelectionChanged);
            // 
            // soTT
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.soTT.DefaultCellStyle = dataGridViewCellStyle13;
            this.soTT.FillWeight = 60F;
            this.soTT.HeaderText = "STT";
            this.soTT.MinimumWidth = 30;
            this.soTT.Name = "soTT";
            this.soTT.ReadOnly = true;
            this.soTT.Width = 60;
            // 
            // maHH
            // 
            this.maHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maHH.DataPropertyName = "maHH";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maHH.DefaultCellStyle = dataGridViewCellStyle14;
            this.maHH.FillWeight = 67.83597F;
            this.maHH.HeaderText = "MaHH";
            this.maHH.Name = "maHH";
            this.maHH.ReadOnly = true;
            // 
            // tenHH
            // 
            this.tenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHH.DataPropertyName = "tenHH";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tenHH.DefaultCellStyle = dataGridViewCellStyle15;
            this.tenHH.FillWeight = 67.83597F;
            this.tenHH.HeaderText = "Sản Phẩm";
            this.tenHH.Name = "tenHH";
            this.tenHH.ReadOnly = true;
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.donViTinh.DefaultCellStyle = dataGridViewCellStyle16;
            this.donViTinh.FillWeight = 130F;
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.ReadOnly = true;
            this.donViTinh.Width = 130;
            // 
            // giaBan
            // 
            this.giaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaBan.DataPropertyName = "giaBan";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Format = "#,##0 đ";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.giaBan.DefaultCellStyle = dataGridViewCellStyle17;
            this.giaBan.FillWeight = 67.83597F;
            this.giaBan.HeaderText = "Giá Bán";
            this.giaBan.Name = "giaBan";
            this.giaBan.ReadOnly = true;
            // 
            // giaMua
            // 
            this.giaMua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaMua.DataPropertyName = "giaMua";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Format = "#,##0 đ";
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.giaMua.DefaultCellStyle = dataGridViewCellStyle18;
            this.giaMua.FillWeight = 80.79906F;
            this.giaMua.HeaderText = "Giá Mua";
            this.giaMua.Name = "giaMua";
            this.giaMua.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.soLuong.DefaultCellStyle = dataGridViewCellStyle19;
            this.soLuong.HeaderText = "SL";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghiChu.DataPropertyName = "ghiChu";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ghiChu.DefaultCellStyle = dataGridViewCellStyle20;
            this.ghiChu.FillWeight = 67.83597F;
            this.ghiChu.HeaderText = "Ghi Chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.ForeColor = System.Drawing.Color.Navy;
            this.lblMa.Location = new System.Drawing.Point(411, 15);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(46, 17);
            this.lblMa.TabIndex = 7;
            this.lblMa.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sản Phẩm",
            "Đơn Vị Tính",
            "Giá Bán",
            "Giá Mua",
            "SL",
            "Ghi Chú"});
            this.comboBox1.Location = new System.Drawing.Point(11, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 34);
            this.comboBox1.TabIndex = 10;
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
            // btnXuat
            // 
            this.btnXuat.BackgroundImage = global::GUI.Properties.Resources.untitled5;
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXuat.Location = new System.Drawing.Point(567, 36);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(80, 63);
            this.btnXuat.TabIndex = 12;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.timkiem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(450, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackgroundImage = global::GUI.Properties.Resources.untitled1;
            this.btnXoaSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaSanPham.Location = new System.Drawing.Point(905, 36);
            this.btnXoaSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(93, 63);
            this.btnXoaSanPham.TabIndex = 1;
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackgroundImage = global::GUI.Properties.Resources.untitled11;
            this.btnThemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemSanPham.Location = new System.Drawing.Point(748, 36);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(80, 63);
            this.btnThemSanPham.TabIndex = 0;
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1072, 341);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.dtgHangHoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnThemSanPham);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgHangHoa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}