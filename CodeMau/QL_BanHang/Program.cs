using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QL_BanHang.View;

namespace QL_BanHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHoaDon());
        }
    }
}
