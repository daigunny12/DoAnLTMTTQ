using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace GUI
{
    public partial class supMenu : UserControl
    {
        public supMenu()
        {
            InitializeComponent();

            if (Program.IsInDesignMode()) return;
            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);
            pnChe.Height = 35;
        }
    }
}
