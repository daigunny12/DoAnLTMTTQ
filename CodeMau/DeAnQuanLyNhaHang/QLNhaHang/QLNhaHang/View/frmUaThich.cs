using QLNhaHang.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaHang.View
{
    public partial class frmUaThich : Form
    {
        public frmUaThich()
        {
            InitializeComponent();
        }
        ConnectToSQL con = new ConnectToSQL();
        private void UaThichcs_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            con.OpenConn();

            SqlConnection sqlcon = con.Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("sp_Getdata", sqlcon);
            adapter.SelectCommand.Parameters.AddWithValue("@FormDate",Convert.ToDateTime (dtFrom.Value));
            adapter.SelectCommand.Parameters.AddWithValue("@ToDate",Convert.ToDateTime( dtTo.Value));
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable da = new DataTable();
            adapter.Fill(da);
            dtgvDS.DataSource = da;
            con.CloseConn();
        }
    }
}
