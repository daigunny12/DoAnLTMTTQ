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
using GUI.QuanLy.HangHoa;
using GUI.ThongKe.ChiTietBanHang;
using GUI.BanHang;
using GUI.NhapHang;
using DTO;
using GUI.LogIn;

namespace GUI.Main
{
    public delegate void deleSetfrm(Form frm);

    public partial class frmMain : Form
    {
        private bool setVipnAc = true;

        private TaiKhoanDTO taiKhoanDTO = null;

        private frmBanHang frmBanHang = null;
        private frmNhapHang frmNhapHang = null;
        private frmClock frmClock = null;
        private frmDoiPass frmDoiPass = null;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        bool mnuExpanded = false;

        int count = 0;

        public frmMain()
        {
            InitializeComponent();

        }

        public frmMain(TaiKhoanDTO taiKhoanDTO) : this()
        {
            this.taiKhoanDTO = taiKhoanDTO;
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

        #region design menu
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (!bunifuTransition2.IsCompleted) return;
            if (pnMain.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnMain.Visible = false;

                    if (tabManHinhChinh.selected||tabBanHang.selected||tabNhapHang.selected)
                    {
                        pnMain.Width = 340;
                        pnTong.Width = 340;
                        pnMainCon.Width = 0;
                    }
                    else
                    {
                        pnMain.Width = 340;
                        pnTong.Width = 566;
                    }
                    bunifuTransition1.Show(pnMain);
                }
            }

            if (!pnTong.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (mnuExpanded)
                {
                    mnuExpanded = false;
                    pnMain.Visible = false;
                    if (tabManHinhChinh.selected||tabBanHang.selected||tabNhapHang.selected)
                    {
                        pnMain.Width = 50;
                        pnTong.Width = 50;
                        pnMainCon.Width = 0;
                    }
                    else
                    {
                        pnMain.Width = 50;
                        pnTong.Width = 266;
                    }
                    bunifuTransition2.Show(pnMain);

                }
            }

        }
        #endregion


        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (taiKhoanDTO.ChucVu == false)
            {
                tabQuanLy.Visible = false;
                tabBaoCao.Visible = false;
                tabNhapHang.Visible = false;
            }


            pnAccount.Visible = false;
            lblTenNV.Text = taiKhoanDTO.TenNV;
            

            tabManHinhChinh.BackColor = Color.FromArgb(0, 179, 0);
            pnMain.Width = 50;
            pnTong.Width = 50;
            pnMainCon.Width = 0;
            frmClock frmClock = new frmClock();
            setFrm(frmClock);
        }


        private void tabManHinhChinh_Click(object sender, EventArgs e)
        {
            pnMainCon.Width = 0;
            pnTong.Width = 340;
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            if (frmClock == null)
            {
                frmClock = new frmClock();
            }            
            setFrm(frmClock);
        }

        private void tabNhapHang_Click(object sender, EventArgs e)
        {
            pnMainCon.Width = 0;
            pnTong.Width = 340;
            if (frmNhapHang == null)
            {
                frmNhapHang = new frmNhapHang(taiKhoanDTO);
            }
            
            setFrm(frmNhapHang);
        }

        public void setFrm(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnfrm.Controls.Clear();
            pnfrm.Controls.Add(frm);
            pnfrm.Tag = frm;
            lblTileFrm.Text = frm.Text;
            frm.Show();
        }

        private void tabBaoCao_Click(object sender, EventArgs e)
        {                 
                pnMain.Width = 340;
                pnTong.Width = 566;
                VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
                supMenu.deleSetfrm += setFrm;
                pnfrm.Controls.Clear();
                supMenu.GetSellectedThongKe();

        }

        private void tabQuanLy_Click(object sender, EventArgs e)
        {
            pnMain.Width = 340;
            pnTong.Width = 566;
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            supMenu.deleSetfrm += setFrm;
            pnfrm.Controls.Clear();
            supMenu.getSelectedQuanLy();
        }

        private void tabBanHang_Click(object sender, EventArgs e)
        {
            pnMainCon.Width = 0;
            pnTong.Width = 340;
            if(frmBanHang == null)
            {
                frmBanHang = new frmBanHang(taiKhoanDTO);
            }          
            setFrm(frmBanHang);
        }


        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnAccount.Location = new Point(btnAccount.Location.X, btnAccount.Location.Y + btnAccount.Size.Height);
            if(setVipnAc == true)
            {
                pnAccount.Visible = true;
                setVipnAc = false;
            }
            else
            {
                pnAccount.Visible = false;
                setVipnAc = true;
            }
            
        }

        private void pnfrm_MouseClick(object sender, MouseEventArgs e)
        {
            pnAccount.Visible = false;
        }

        private void pnAccount_MouseHover(object sender, EventArgs e)
        {
            pnAccount.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            timer2.Start();
            
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(frmDoiPass == null)
            {
                frmDoiPass = new frmDoiPass(taiKhoanDTO.MaNV, taiKhoanDTO.TenNV);
            }
            frmDoiPass.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            count += 1;
            if (count == 100) timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                frmLogIn frmlogin = new frmLogIn();
                frmlogin.Show();

            }
        }
    }
}
