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

namespace QLNhaHang.crystal_report
{

    public partial class frm_TK_HoaDon : Form
    {
        public frm_TK_HoaDon()
        {
            InitializeComponent();
        }

        ConnectToSQL con = new ConnectToSQL();


        private string _maHD ;

        public frm_TK_HoaDon(string x)
            : this()
        {
            _maHD = x;
        }

        private void frm_TK_HoaDon_Load(object sender, EventArgs e)
        {

            con.OpenConn();

            SqlConnection sqlcon = con.Connection;

            SqlDataAdapter adapter = new SqlDataAdapter("SP_TK_HoaDon", sqlcon);
            adapter.SelectCommand.Parameters.AddWithValue("@maHD", _maHD);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable da = new DataTable();
            adapter.Fill(da);
            ReportDocument rdm = new ReportDocument();
            rdm.Load(@"crystalreport\TK_HoaDon.rpt");
            rdm.SetDataSource(da);
           cry_TK_HoaDon.ReportSource = rdm;

            con.CloseConn();
        }
    }
}
