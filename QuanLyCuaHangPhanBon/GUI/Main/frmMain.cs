using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using KimtToo.VisualReactive;

namespace GUI.Main
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        bool mnuExpanded = false;
        bool mnuExpandedCon = false;

        public frmMain()
        {
            InitializeComponent();
        }


        #region design title bar
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnFullscreenExit.BringToFront();
        }

        private void btnFullscreenExit_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnFullscreen.BringToFront();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return ;
            if (pnTong.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnMain.Visible = false;
                    pnMain.Width = 323;
                    bunifuTransition1.Show(pnMain);
                }
            }
            else
            {
                
                if (mnuExpanded)
                {
                    mnuExpanded = false;
                    pnMain.Visible = false;
                    pnMain.Width = 51;
                    bunifuTransition1.Show(pnMain);
                }
            }
            
        }
        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

    }
}
