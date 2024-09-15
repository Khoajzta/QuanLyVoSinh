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
    public class DiemSoDAO
    {
        public static int CapNhatLaiDiem(List<string> danhsachvosinh)
        {
            int kq = 0;
            foreach (string mavossinh in danhsachvosinh)
            {
                string query = $"update DiemSo set Diem = 0 where MaVoSinh = '{mavossinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int ThemDiemSo(VoSinhDTO vosinh)
        {
            string query = $"insert into DiemSo(MaVoSinh,Diem,MaDai,MaCLB) values('{vosinh.MaVoSinh}',0,{vosinh.MaDai},'{vosinh.MaCLB}')";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int XoaDiem(string maCLB)
        {
            string query = $"delete DiemSo where MaCLB = '{maCLB}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }
    }
}
