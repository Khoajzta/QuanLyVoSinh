using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT_DAO
{
    public class DataProvider
    {
        public static string strKetNoi = "Data Source=.;Initial Catalog=QuanLyVoSinh;Integrated Security=True;";
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strKetNoi);
            return conn;
        }

        public static SqlDataReader TruyVan(string strTruyVan, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            return com.ExecuteReader();
        }

        public static SqlDataReader TruyVan(string strTruyVan, SqlConnection conn, SqlParameter[] pars)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            com.Parameters.AddRange(pars);
            return com.ExecuteReader();
        }

        public static int ThucThiLenh(string strLenh, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strLenh, conn);
            return com.ExecuteNonQuery();
        }

        public static int ThucThiLenh(string strLenh, SqlConnection conn, SqlParameter[] pars)
        {
            SqlCommand com = new SqlCommand(strLenh, conn);
            com.Parameters.AddRange(pars);
            return com.ExecuteNonQuery();
        }
        public static int truyVanScalar(string strlenh, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strlenh, conn);
            int kq = (int)com.ExecuteScalar();
            return kq;
        }
        public static int truyVanScalar(string strlenh, SqlConnection conn, SqlParameter[] pa)
        {
            SqlCommand com = new SqlCommand(strlenh, conn);
            com.Parameters.AddRange(pa);
            int kq = (int)com.ExecuteScalar();
            return kq;
        }
    }
}
