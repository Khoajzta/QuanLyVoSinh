using QuanLyHocSinhTHPT_DAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhDAO
{
    public class CapDaiDAO
    {
        public static List<CapDaiDTO> LayDanhSachCapDai()
        {
            List<CapDaiDTO> danhSachCapDai = new List<CapDaiDTO>();
            string strTV = "select * from CapDai";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(strTV, conn);
            while (sdr.Read())
            {
                CapDaiDTO capdai = new CapDaiDTO();
                capdai.MaDai = (int)sdr["MaDai"];
                capdai.TenDai = sdr["TenDai"].ToString();
                danhSachCapDai.Add(capdai);
            }
            sdr.Close();
            conn.Close();
            return danhSachCapDai;
        }

        public static CapDaiDTO LayThongTinCapDai(int maDai)
        {
            CapDaiDTO capdai = new CapDaiDTO();
            string query = $"select * from CapDai where MaDai = {maDai}";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            if (sdr.Read())
            {
                capdai.MaDai = maDai;
                capdai.TenDai = sdr["TenDai"].ToString();
            }
            sdr.Close();
            conn.Close();
            return capdai;
        }
    }
}
