using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaHang.Model
{
    class ConnectToSQL
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;
        private string connStr;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return Conn; }
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion
        #region Contrustor
        public ConnectToSQL()
        {
            StrCon = @"Data Source= DESKTOP-SAHD7A7\SQLEXPRESS; ;Initial Catalog = QuanLyNhaHang; User = sa; Password=sa";
            Conn = new SqlConnection(StrCon);
        }

        public ConnectToSQL(string connStr)
        {
            this.connStr = connStr;
        }
        #endregion
        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public DataTable GetData(string proc)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, Conn);
                da.Fill(dt);
                Conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                Conn.Close();
                return null;
            }
        }
        #endregion

    }
}
