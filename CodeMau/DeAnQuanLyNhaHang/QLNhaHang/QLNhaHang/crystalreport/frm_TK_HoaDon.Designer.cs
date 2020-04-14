namespace QLNhaHang.crystal_report
{
    partial class frm_TK_HoaDon
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
            this.cry_TK_HoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cry_TK_HoaDon
            // 
            this.cry_TK_HoaDon.ActiveViewIndex = -1;
            this.cry_TK_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cry_TK_HoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cry_TK_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cry_TK_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.cry_TK_HoaDon.Name = "cry_TK_HoaDon";
            this.cry_TK_HoaDon.Size = new System.Drawing.Size(800, 450);
            this.cry_TK_HoaDon.TabIndex = 0;
            // 

            // frm_TK_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cry_TK_HoaDon);
            this.Name = "frm_TK_HoaDon";
            this.Text = "frm_TK_HoaDon";
            this.Load += new System.EventHandler(this.frm_TK_HoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cry_TK_HoaDon;
    }
}