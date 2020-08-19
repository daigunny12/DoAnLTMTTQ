namespace GUI.NhapHang
{
    partial class frmCR_NhapHang
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crNhapHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crNhapHang
            // 
            this.crNhapHang.ActiveViewIndex = -1;
            this.crNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crNhapHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crNhapHang.Location = new System.Drawing.Point(0, 0);
            this.crNhapHang.Name = "crNhapHang";
            this.crNhapHang.Size = new System.Drawing.Size(800, 450);
            this.crNhapHang.TabIndex = 1;
            // 
            // frmCR_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crNhapHang);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmCR_NhapHang";
            this.Text = "frmCR_NhapHang";
            this.Load += new System.EventHandler(this.frmCR_NhapHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crNhapHang;
    }
}