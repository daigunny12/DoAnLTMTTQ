namespace GUI.BanHang
{
    partial class frmCR_BanHang
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
            this.crBanHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crBanHang
            // 
            this.crBanHang.ActiveViewIndex = -1;
            this.crBanHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crBanHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crBanHang.Location = new System.Drawing.Point(0, 0);
            this.crBanHang.Name = "crBanHang";
            this.crBanHang.Size = new System.Drawing.Size(794, 351);
            this.crBanHang.TabIndex = 0;
            // 
            // frmCR_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 351);
            this.Controls.Add(this.crBanHang);
            this.Name = "frmCR_BanHang";
            this.Text = "Hóa Đơn Bán Hàng";
            this.Load += new System.EventHandler(this.frmCR_BanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crBanHang;
    }
}