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
    public class HuanLuyênVienDAO
    {
        public static List<HuanLuyenVienDTO> LayDanhSach()
        {
            List<HuanLuyenVienDTO> danhsachHLV = new List<HuanLuyenVienDTO>();
            string query = $"select * from HuanLuyenVien";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);

            while (sdr.Read())
            {
                HuanLuyenVienDTO hlv = new HuanLuyenVienDTO();
                hlv.MaHLV = sdr["MaHLV"].ToString();
                hlv.TenHLV = sdr["TenHLV"].ToString();
                hlv.SDT = sdr["SDT"].ToString();

                // Kiểm tra nếu cột HinhAnh là NULL
                if (sdr["HinhAnh"] != DBNull.Value)
                {
                    hlv.HinhAnh = (byte[])sdr["HinhAnh"];
                }
                else
                {
                    hlv.HinhAnh = null; // Gán giá trị null nếu không có hình ảnh
                }

                danhsachHLV.Add(hlv);
            }

            sdr.Close();
            conn.Close();
            return danhsachHLV;
        }

        public static HuanLuyenVienDTO LayThongTin(string maHLV)
        {
            HuanLuyenVienDTO hlv = null;
            string query = $"select * from HuanLuyenVien where MaHLV = '{maHLV}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);

            if (sdr.Read())
            {
                hlv = new HuanLuyenVienDTO();
                hlv.MaHLV = sdr["MaHLV"].ToString();
                hlv.TenHLV = sdr["TenHLV"].ToString();
                hlv.SDT = sdr["SDT"].ToString();

                
                if (sdr["HinhAnh"] != DBNull.Value)
                {
                    hlv.HinhAnh = (byte[])sdr["HinhAnh"];
                }
                else
                {
                    hlv.HinhAnh = null;
                }

            }

            sdr.Close();
            conn.Close();
            return hlv;
        }

        public static int SuaHLV(HuanLuyenVienDTO hlv)
        {
            string query = $"update HuanLuyenVien set TenHLV = @TenHLV ,SDT = N'{hlv.SDT}',HinhAnh = @HinhAnh where MaHLV = @MaHLV";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("MaHLV", hlv.MaHLV);
            pars[1] = new SqlParameter("TenHLV", hlv.TenHLV);
            pars[2] = new SqlParameter("HinhAnh", hlv.HinhAnh);
            int kq = DataProvider.ThucThiLenh(query, conn,pars);
            conn.Close();
            return kq;
        }

        public static int ThemHLV(HuanLuyenVienDTO hlv)
        {
            string query = $"insert into HuanLuyenVien(MaHLV,TenHLV,SDT,HinhAnh) values(@MaHLV,@TenHLV,N'{hlv.SDT}',@HinhAnh)";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("MaHLV",hlv.MaHLV);
            pars[1] = new SqlParameter("TenHLV", hlv.TenHLV);
            pars[2] = new SqlParameter("HinhAnh", hlv.HinhAnh);
            int kq = DataProvider.ThucThiLenh(query, conn,pars);
            conn.Close();
            return kq;
        }

        public static int TrungMaHLV(string maHLV)
        {
            string query = $"select count(*) from HuanLuyenVien where MaHLV = '{maHLV}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);   
            conn.Close();
            return kq;  
        }

        public static int XoaHLV(HuanLuyenVienDTO hlv)
        {
            string query = $"delete HuanLuyenVien where MaHLV = '{hlv.MaHLV}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }
    }
}
