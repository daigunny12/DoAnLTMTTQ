using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLNhaHang.Model
{
    class KetNoiCSDL
    {
        #region Khai báo biến
        private SqlConnection conn;
        private string ConnStr;
        #endregion
        #region Các hàm tạo
        public KetNoiCSDL()
        {
            conn = new SqlConnection();
            ConnStr = "";
        }
        public KetNoiCSDL(string str)
        {
            ConnStr = str;
            conn = new SqlConnection(str);
        }
        #endregion
        #region Các đặc trưng
        public SqlConnection Connection
        {
            set { conn = value; }
            get { return conn; }
        }
        public String ConnectionString
        {
            set { ConnStr = value; }
            get { return ConnStr; }
        }
        #endregion
        #region Các phương thức
        public void KetNoi()
        {
            conn.Open();
        }
        #endregion
    }
}
