using CrystalDecisions.CrystalReports.Engine;
using QLNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHang.crystalreport
{
    public partial class frmDS_NhanVien : Form
    {
        public frmDS_NhanVien()
        {
            InitializeComponent();
        }
        ConnectToSQL con = new ConnectToSQL();
        private void frmDS_NhanVien_Load(object sender, EventArgs e)
        {
            con.OpenConn();

            SqlConnection sqlcon = con.Connection;

            SqlDataAdapter adapter = new SqlDataAdapter("DS_NhanVien", sqlcon);
            //adapter.SelectCommand.Parameters.AddWithValue();
            //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable da = new DataTable();
            adapter.Fill(da);
            DS_NhanVien ds = new DS_NhanVien();
            
            ds.SetDataSource(da);
            crystalReportViewer5.ReportSource = ds;

            con.CloseConn();
        }
    }
}
